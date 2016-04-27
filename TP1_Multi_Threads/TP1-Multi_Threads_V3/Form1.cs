using System;
using System.Windows.Forms;

namespace TP1_Multi_Threads_V3
{
    public partial class formHorloge : Form
    {
        public formHorloge()
        {
            InitializeComponent();
        }

        private void formHorloge_Load(object sender, EventArgs e)
        {
            tmrChaquesSecondes.Enabled = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
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

        private void tmrChaquesSecondes_Tick(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }
    }
}
