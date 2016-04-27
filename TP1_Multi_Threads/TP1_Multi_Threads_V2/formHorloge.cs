using System;
using System.Threading;
using System.Windows.Forms;

namespace TP1_Multi_Threads_V2
{
    public partial class formHorloge : Form
    {
        private Thread leThread;

        public formHorloge()
        {
            InitializeComponent();

            leThread = new Thread(Go);
        }

        private void formHorloge_Load(object sender, EventArgs e)
        {
            leThread.Start();
        }

        private void Quitter()
        {
            leThread.Abort();
            leThread.Join();
        }

        private void formHorloge_FormClosing(object sender, FormClosingEventArgs e)
        {
            Quitter();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AfficherDateHeure()
        {
            if (rbtnDate.Checked)
            {
                lblDateHeure.Invoke(new Action(() => lblDateHeure.Text = DateTime.Now.ToShortDateString()));
            }
            else if (rbtnHeure.Checked)
            {
                lblDateHeure.Invoke(new Action(() => lblDateHeure.Text = DateTime.Now.ToLongTimeString()));
            }
            else
            {
                lblDateHeure.Invoke(new Action(() => lblDateHeure.Text = DateTime.Now.ToString()));
            }
        }

        private void Go()
        {
            while(true)
            {
                AfficherDateHeure();

                Thread.Sleep(1000);
            }
        }

        private void rbtnDateHeure_Click(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }
    }
}
