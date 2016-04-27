using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_Multi_Threads_Partie2
{
    public partial class frmTri : Form
    {
        public double[] tableau { get; private set; }

        public frmTri(double[] tableau)
        {
            InitializeComponent();

            this.tableau = tableau;
        }

        private void Trier(double[] tableau, DoWorkEventArgs e)
        {
            int i, iRech, iMin;
            double tmp;
            int N = tableau.Length;

            for (i = 0; i < N; i++)
            {
                for (iRech = iMin = i; iRech < N; iRech++)
                    if (tableau[iRech] < tableau[iMin])
                        iMin = iRech;
                if (iMin != i)
                {
                    tmp = tableau[iMin];
                    tableau[iMin] = tableau[i];
                    tableau[i] = tmp;
                }

                backgroundWorker1.ReportProgress((i * 100) / (N - 1));

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;

                    return;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Trier(tableau, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void frmTri_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Tri annulé");
            }
            else
            {
                MessageBox.Show("Tri effectué");
                btnOK.Enabled = true;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
