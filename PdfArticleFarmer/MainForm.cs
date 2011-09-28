using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using org.pdfbox.pdmodel;
using org.pdfbox.util;
using System.Collections;
using System.IO;
using System.Diagnostics;


namespace PdfArticleFarmer
{
    public partial class MainForm : Form
    {
        protected Label[] _labels;
        protected ArrayList _files = new ArrayList();
        protected int _curFileIndex = -1;
        protected int _lineIndex = 0;
        protected string _dbFileName = "pdf_db.txt";
        protected ParallelFileOpener _fileOpener = new ParallelFileOpener();

        public MainForm()
        {
            InitializeComponent();
        }
         
        private void MainForm_Load(object sender, EventArgs e)
        {
            _labels = new Label[] { line1Box, line2Box, line3Box, line4Box, line5Box };
            SetWindowTitle();
            _fileOpener.Completed += new EventHandler(fileOpener_Completed);
            ClearFields();
        }

        private void titleBox_DragDrop(object sender, DragEventArgs e)
        {
            TextBox box = (TextBox) sender;
            if (e.Effect == DragDropEffects.None) return;
            string text = (string)e.Data.GetData(typeof(string));
            if (e.Effect == DragDropEffects.Move)
                box.Text = text;
            else if (e.Effect == DragDropEffects.Copy)
                box.AppendText(" " + text);
        }

        private void line1Box_MouseDown(object sender, MouseEventArgs e)
        {
            Label lab = sender as Label;
            lab.DoDragDrop(lab.Text, DragDropEffects.All);
        }

        private void titleBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = (((e.KeyState & 1) != 0) ? DragDropEffects.Move : DragDropEffects.Copy);
            // первый бит - левая кнопка мыши - значит тупо заполняем поле. 
            // второй бит - правая кнопка - копируем (дописываем в конец)
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                dropPanel.Visible = true;
            }
            else
            {
                dropPanel.Visible = false;
            }
            e.Effect = DragDropEffects.None;
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            dropPanel.Visible = false;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                ProcessFiles(fileList);
            }
        }

        private void ProcessFiles(string[] fileList)
        {
            _files.Clear();
            foreach (string file in fileList)
                if (Path.GetExtension(file) == ".pdf")
                    _files.Add(file);
            if (_files.Count == 0)
            {
                _curFileIndex = -1;
                ClearFields();
                MessageBox.Show("No pdf files");
            }
            else
            {
                _curFileIndex = 0;
                FillFields();
            }
        }

        private void ClearFields()
        {
            rawBox.Text = titleBox.Text = authorsBox.Text = journalBox.Text = infoBox.Text = "";
            foreach (Label lab in _labels)
                lab.Text = "";
            fileNameBox.Text = "- no file -";
        }

        private void FillFields()
        {
            ClearFields();
            _lineIndex = 0;
            if ((_curFileIndex >= _files.Count) || (_curFileIndex < 0))
            {
                _curFileIndex = -1;
                return;
            }
            string file = GetCurFileName();
            fileNameBox.Text = Path.GetFileNameWithoutExtension(file) + string.Format(", {0} of {1}", _curFileIndex + 1, _files.Count);
            try
            {
                _fileOpener.Run(file);
                //PDDocument doc = PDDocument.load(file);
                //PDFTextStripper stripper = new PDFTextStripper();
                //rawBox.Text = stripper.getText(doc);
            }
            catch
            {
            }
            //fileNameBox.Text = Path.GetFileNameWithoutExtension(file) + string.Format(", {0} of {1}", curFileIndex + 1, files.Count);
            //FillLines();
        }

        void fileOpener_Completed(object sender, EventArgs e)
        {
            if (_fileOpener.Success)
            {
                rawBox.Text = _fileOpener.Result;
                FillLines();
            }
            else
            {
                ClearFields();
                fileNameBox.Text = "error open file: " + _fileOpener.FileName;
                return;
            }
        }
        
        private string GetCurFileName()
        {
            if ((_curFileIndex >= 0) && (_curFileIndex < _files.Count))
                return (string)_files[_curFileIndex];
            return "";
        }

        private void FillLines()
        {
            
            for (int i = 0; i < _labels.Length; i++)
            {
                FillLine(_labels[i], _lineIndex, i);
            }
            prevLinesBtn.Enabled = _lineIndex != 0;
            nextLinesBtn.Enabled = _lineIndex + _labels.Length < rawBox.Lines.Length;
        }

        private void FillLine(Label label, int startLineIndex, int lineShift)
        {
            if (startLineIndex + lineShift < rawBox.Lines.Length)
                label.Text = rawBox.Lines[startLineIndex + lineShift];
        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            dropPanel.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            dropPanel.Visible = false;
        }

        private void MainForm_DragLeave(object sender, EventArgs e)
        {
            dropPanel.Visible = false;
        }

        private void prevLinesBtn_Click(object sender, EventArgs e)
        {
            _lineIndex -= 5;
            if (_lineIndex < 0) _lineIndex = 0;
            FillLines();
        }

        private void nextLinesBtn_Click(object sender, EventArgs e)
        {
            _lineIndex += 5;
            if (_lineIndex > rawBox.Lines.Length)
            {
                _lineIndex = rawBox.Lines.Length - 5;
                if (_lineIndex < 0) 
                    _lineIndex = 0;
            }
            FillLines();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            Proceed(true);
        }

        private void Proceed(bool rename)
        {
            SaveToDB();
            if (rename)
                RenameFile();
            NextFile();
        }

        private void NextFile()
        {
            if (_curFileIndex != -1)
                _curFileIndex++;
            FillFields();
        }

        private void RenameFile()
        {
            string file = (string)_files[_curFileIndex];
            string path = Path.GetDirectoryName(file);
            string newName = Path.Combine(path, titleBox.Text + ".pdf");
            try
            {
                System.IO.File.Move(file, newName);
            }
            catch
            {
            }
        }

        private void SaveToDB()
        {
            //FileStream stream = File.OpenWrite(dbFileName);
            StreamWriter dbWriter = new StreamWriter(_dbFileName, true);
            dbWriter.WriteLine(authorsBox.Text);
            dbWriter.WriteLine(titleBox.Text);
            dbWriter.WriteLine(journalBox.Text);
            dbWriter.WriteLine(infoBox.Text);
            dbWriter.WriteLine("---");
            dbWriter.Close();
        }

        private void rawBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (rawBox.SelectionLength > 0)
                rawBox.DoDragDrop(rawBox.SelectedText, DragDropEffects.All);
        }

        private void dontRenameBtn_Click(object sender, EventArgs e)
        {
            Proceed(false);
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            NextFile();
        }

        private void selectDBBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = _dbFileName;
            dlg.DefaultExt = ".txt";
            dlg.CheckPathExists = true;
            dlg.Multiselect = false;
            dlg.Title = "Database file";
            string defPath = Path.GetDirectoryName(_dbFileName);
            if (defPath == "")
                defPath = Path.GetDirectoryName(Application.ExecutablePath);
            dlg.InitialDirectory = defPath;
            if (dlg.ShowDialog() != DialogResult.OK) return;
            _dbFileName = dlg.FileName;
            SetWindowTitle();
        }

        private void SetWindowTitle()
        {
            Text = Path.GetFileName(_dbFileName) + " - " + Application.ProductName;
        }

        private void scanFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
            dlg.ShowNewFolderButton = false;
            if (dlg.ShowDialog() != DialogResult.OK) return;
            string path = dlg.SelectedPath;
            string[] files = Directory.GetFiles(path, "*.pdf");
            ProcessFiles(files);
        }

        private void scanFilesBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".pdf";
            dlg.CheckPathExists = true;
            dlg.CheckFileExists = true;
            dlg.Multiselect = true; ;
            dlg.Title = "Pdf to scan";
            dlg.Filter = "PDF|*.pdf";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            string[] files = dlg.FileNames;
            ProcessFiles(files);
        }

        private void fileNameBox_MouseEnter(object sender, EventArgs e)
        {
            fileNameBox.ForeColor = Color.Blue;
        }

        private void fileNameBox_MouseLeave(object sender, EventArgs e)
        {
            fileNameBox.ForeColor = Color.Black;
        }

        private void fileNameBox_Click(object sender, EventArgs e)
        {
            string file = GetCurFileName();
            if (file == "") return;
            Process.Start(file);
        }
    }
}
