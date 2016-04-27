using System;
using System.Threading;
using System.Windows.Forms;

namespace TP1_Multi_Threads
{
    public partial class formHorloge : Form
    {
        public formHorloge()
        {
            InitializeComponent();
        }

        private void formHorloge_Load(object sender, EventArgs e)
        {
            lblDateHeure.Text = DateTime.Now.ToString();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfficherDateHeure()
        {
            if (rbtnDate.Checked)
            {
                lblDateHeure.Text = DateTime.Now.ToShortDateString();
            }
            else if (rbtnHeure.Checked)
            {
                lblDateHeure.Text = DateTime.Now.ToLongTimeString();
            }
            else
            {
                lblDateHeure.Text = DateTime.Now.ToString();
            }
        }

        private void btnRaffraichir_Click(object sender, EventArgs e)
        {
            while(true)
            {
                AfficherDateHeure();
                this.Refresh();

                Thread.Sleep(1000);
            }
        }
    }
}
