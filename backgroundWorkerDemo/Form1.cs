using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace backgroundWorkerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //BackgroundWorker worker = (BackgroundWorker)sender;
            for (int i = 0; i < 10; i++)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(500);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = (e.ProgressPercentage+1)*10;

            //this.label1.Text = e.UserState.ToString();

            this.label1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RadMessageBox.Show("complete!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (!backgroundWorker1.IsBusy)
                {
                    progressBar1.Value = 0;
                    backgroundWorker1.WorkerReportsProgress = true;
                    backgroundWorker1.RunWorkerAsync("start working");
                }
                else
                {
                    MessageBox.Show("backgroundworker is busy!");
                }
            

        }
    }
}
