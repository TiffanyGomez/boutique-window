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
    public partial class FrmConnexionPerso : Form
    {
        public FrmConnexionPerso()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string login = boxId.Text;
            string mdp = boxMdp.Text;
            if (GestionConnexion.VerifConnexion(login, mdp))
            {
                FrmAccueilPerso formulaire = new FrmAccueilPerso();
                formulaire.Show();
                this.Hide();
            }
            else
            {
                erp.SetError(lblErp, "Login ou mot de passe incorrect !");
                lblErreur.Visible = true;
            }
        }

        private void boxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnOk.PerformClick();
        }

        private void boxMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnOk.PerformClick();
        }
    }
}
