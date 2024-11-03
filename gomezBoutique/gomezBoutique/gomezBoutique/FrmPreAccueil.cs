using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gomezBoutique
{
    public partial class FrmPreAccueil : Form
    {
        public FrmPreAccueil()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmConnexion formulaire = new FrmConnexion();
            formulaire.Show();
            this.Hide();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            FrmConnexionPro formulaire = new FrmConnexionPro();
            formulaire.Show();
            this.Hide();
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            FrmConnexionPerso formulaire = new FrmConnexionPerso();
            formulaire.Show();
            this.Hide();
        }

        private void FrmPreAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
