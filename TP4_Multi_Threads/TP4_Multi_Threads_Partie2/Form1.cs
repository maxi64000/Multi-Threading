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
    public partial class Form1 : Form
    {
        private double[] tableau;

        public Form1()
        {
            InitializeComponent();
        }

        private void Initialiser(double[] tableau)
        {
            Random r = new Random();
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = r.NextDouble() * tableau.Length;
            }
        }

        private void Afficher(double[] tableau, ListBox liste)
        {
            liste.Items.Clear();

            foreach(var e in tableau)
            {
                liste.Items.Add(e);
            }
        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            int taille;

            if (int.TryParse(txtTaille.Text, out taille)) {
                tableau = new double[taille];
                Initialiser(tableau);
                Afficher(tableau, lstValeursNonTriees);
            }
            else
            {
                MessageBox.Show("Taille incorrecte");
            }
        }

        private void btnTrier_Click(object sender, EventArgs e)
        {
            frmTri f = new frmTri(tableau);

            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Afficher(f.tableau, lstValeurstriees);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
