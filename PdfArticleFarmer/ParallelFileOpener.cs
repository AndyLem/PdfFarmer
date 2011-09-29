using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using org.pdfbox.pdmodel;
using org.pdfbox.util;

namespace PdfArticleFarmer
{
    public class ParallelFileOpener
    {
        protected string _fileName;
        protected bool _success;
        protected string _result;
        protected BackgroundWorker worker;
        public event EventHandler Completed;
        protected ProgressBarForm form;

        public bool Ready
        {
            get
            {
                return !worker.IsBusy;
            }
        }

        public string Result
        {
            get 
            { 
                return _result; 
            }
        }

        public bool Success
        {
            get 
            { 
                return _success; 
            }
        }

        public string FileName
        {
            get
            {
                return _fileName;
            }
        }

        private delegate void EmptyMethod();

        public ParallelFileOpener()
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;

            form = new ProgressBarForm();
        }

        public void Run(string fileName)
        {
            _fileName = fileName;
            worker.RunWorkerAsync();
            form.ShowDialog();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Completed != null)
                Completed(this, EventArgs.Empty);
            if (form.Visible) 
                form.Close(); // нереальная ситуация. мы никогда не должны тут оказаться
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                PDDocument doc = PDDocument.load(_fileName);
                EmptyMethod step = StepForm;
                if (step != null)
                {
                    form.Invoke(step);
                }
                PDFTextStripper stripper = new PDFTextStripper();
                _result = stripper.getText(doc);
                _success = true;
            }
            catch
            {
                _success = false;
            }
            finally
            {
                EmptyMethod hide = HideForm;
                if (hide != null)
                {
                    form.Invoke(hide);
                }
            }

        }

        protected void HideForm()
        {
            if (form.Visible)
                form.Close();
        }

        protected void StepForm()
        {
            if (form.Visible)
                form.progressBar.PerformStep();
        }
    }
}
