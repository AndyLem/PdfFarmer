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
        public bool Ready
        {
            get
            {
                return !worker.IsBusy;
            }
        }
        public string Result;
        public bool Success;
        BackgroundWorker worker;
        public event EventHandler Completed;
        protected ProgressBarForm form;
        protected delegate void EmptyMethod();

        public string FileName
        {
            get
            {
                return _fileName;
            }
        }

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

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Completed != null)
                Completed(this, EventArgs.Empty);
            if (form.Visible) 
                form.Close(); // нереальная ситуация. мы никогда не должны тут оказаться
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
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
                Result = stripper.getText(doc);
                Success = true;
            }
            catch
            {
                Success = false;
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
