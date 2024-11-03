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
    public partial class FrmInfos : Form
    {
        public FrmInfos()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            string nom = txtNom.Text;
            GestionClients.supprimer(id);
            MessageBox.Show("Vous avez bien supprimer votre compte : " + nom);
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nom = txtQui.Text;
            DataTable leClient = GestionClients.getTuplesByNom(nom);

            if (leClient.Rows.Count == 0)
            {
                MessageBox.Show("personne...");
                txtQui.Clear();
            }
            else
            {
                lblQui.Visible = false;
                btnOk.Visible = false;
                txtQui.Visible = false;
                lblCompte.Visible = true;
                txtNom.Visible = true;
                txtBoxVille.Visible = true;
                txtBoxTel.Visible = true;
                txtBoxRue.Visible = true;
                txtBoxPrenom.Visible = true;
                txtBoxMail.Visible = true;
                txtBoxCP.Visible = true;
                txtNom.Text = leClient.Rows[0]["nom"].ToString();
                txtBoxPrenom.Text = leClient.Rows[0]["prenom"].ToString();
                txtBoxMail.Text = leClient.Rows[0]["email"].ToString();
                txtBoxCP.Text = leClient.Rows[0]["codePostal"].ToString();
                txtBoxRue.Text = leClient.Rows[0]["rue"].ToString();
                txtBoxTel.Text = leClient.Rows[0]["tel"].ToString();
                txtBoxVille.Text = leClient.Rows[0]["ville"].ToString();
                lblId.Text = leClient.Rows[0]["id"].ToString();
            }

        }

        private void FrmInfos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtBoxCP.Enabled = true;
            txtBoxMail.Enabled = true;
            txtBoxPrenom.Enabled = true;
            txtBoxRue.Enabled = true;
            txtBoxTel.Enabled = true;
            txtBoxVille.Enabled = true;
            txtNom.Enabled = true;
            btnConfirmez.Visible = true;
            btn.Enabled = false;
        }

        private void btnConfirmez_Click(object sender, EventArgs e)
        {

            int id = int.Parse(lblId.Text);
            string nom = txtNom.Text;
            string prenom = txtBoxPrenom.Text;
            string rue = txtBoxRue.Text;
            string codePostal = txtBoxCP.Text;
            string ville = txtBoxVille.Text;
            string tel = txtBoxTel.Text;
            string email = txtBoxMail.Text;
            GestionClients.modifier(id, nom, prenom, rue, codePostal, ville, tel, email);
            MessageBox.Show("Vous avez bien modifier le client avec le nom :" + nom);
            this.Hide();

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
