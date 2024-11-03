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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string login = boxId.Text;
            string mdp = boxMdp.Text;     
            if (GestionConnexion.VerifConnexion(login, mdp))            
            { 
                FrmAccueil formulaire = new FrmAccueil();
                formulaire.Show();
                this.Hide();
            }
            else
            {
                erp.SetError(lblErp, "Login ou mot de passe incorrect !");
                lblErreur.Visible = true;
            }
        }

        private void boxMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnOk.PerformClick();
        }

        private void boxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnOk.PerformClick();
        }

        private void FrmConnexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPreAccueil form = new FrmPreAccueil();
            form.Show();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
