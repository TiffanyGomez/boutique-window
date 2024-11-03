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
    public partial class FrmAccueilPro : Form
    {
        public FrmAccueilPro()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "boutiqueGomez : question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void toolStripProduits_Click(object sender, EventArgs e)
        {
            FrmProduits form = new FrmProduits();
            form.Show();
        }

        private void retourTools_Click(object sender, EventArgs e)
        {
            FrmPreAccueil formulaire = new FrmPreAccueil();
            formulaire.Show();
            this.Hide();
        }

        private void côtéProfessionelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPropos form = new FrmAPropos();
            form.Show();
        }

        private void clientsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmComptePro form = new FrmComptePro();
            form.Show();
        }

        private void creerMonCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutPro form = new FrmAjoutPro();
            form.Show();
        }
    }
}
