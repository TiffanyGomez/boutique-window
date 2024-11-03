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
    public partial class FrmFournisseur : Form
    {
        public FrmFournisseur()
        {
            InitializeComponent();
        }

        private void FrmFournisseur_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            dataFournisseur.DataSource = GestionFournisseur.getTuples();
        }

        private void FrmFournisseur_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAccueil formulaire = new FrmAccueil();
            formulaire.Show();
            this.Hide();
        }

        private void dataFournisseur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModifierFournisseur form = new FrmModifierFournisseur(dataFournisseur.CurrentRow);
            form.Show();
            this.Hide();
        }
    }
}
