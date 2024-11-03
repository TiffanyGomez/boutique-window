using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBD.MySQL;

namespace gomezBoutique
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void retourTools_Click(object sender, EventArgs e)
        {
            FrmPreAccueil formulaire = new FrmPreAccueil();
            formulaire.Show();
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "boutiqueGomez : question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Hide();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClients formulaire = new FrmClients();
            formulaire.Show();
            this.Hide();
        }

        private void afficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFournisseur formulaire = new FrmFournisseur();
            formulaire.Show();
            this.Hide();
        }

        private void côtéClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccueilPerso form = new FrmAccueilPerso();
            form.Show();
        }

        private void voirLesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCommandes form = new FrmCommandes();
            form.Show();
        }

        private void côtéProfessionelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccueilPro form = new FrmAccueilPro();
            form.Show();
        }
    }
}
