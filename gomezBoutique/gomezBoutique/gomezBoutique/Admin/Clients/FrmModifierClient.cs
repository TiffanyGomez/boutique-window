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
    public partial class FrmModifierClient : Form
    {
        DataGridViewRow selectedClient;

        public FrmModifierClient()
        {
            InitializeComponent();
        }
        public FrmModifierClient(DataGridViewRow selectedClient)
        {
            InitializeComponent();

            this.selectedClient = selectedClient;
        }
        
        private void FrmModifierClient_Load(object sender, EventArgs e)
        {
            values_rempli();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            string nom = txtNom.Text;
            string prenom = txtBoxPrenom.Text;
            string rue = txtBoxRue.Text;
            string codePostal = txtBoxCP.Text;
            string ville = txtBoxVille.Text;
            string tel = txtBoxTel.Text;
            string email = txtBoxMail.Text;
            if (comboBox.Text == "Modifier")
            {
                GestionClients.modifier(id, nom, prenom, rue, codePostal, ville, tel, email);
                MessageBox.Show("Vous avez bien modifier le client avec le nom :" + nom);
            }
            else if (comboBox.Text == "Ajouter")
            {
                GestionClients.ajouter(nom, prenom, rue, codePostal, ville, tel, email);
                MessageBox.Show("Vous avez bien ajouter le client avec le nom : " + nom);
            }
            else
            {
                GestionClients.supprimer(id);
                MessageBox.Show("Vous avez bien supprimer le client avec le nom : " + nom);
            }

            FrmClients form = new FrmClients();
            form.Show();
            this.Hide();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox.Text == "Ajouter")
                {
                    enabled_true();
                    values_null();
                    btn.Text = "Ajouter";
                }
                else if (comboBox.Text == "Supprimer")
                {
                    values_rempli();
                    enabled_false();
                    btn.Text = "Supprimer";
                }
                else
                {
                    values_rempli();
                    enabled_true();
                    btn.Text = "Modifier";
                }
        }

        private void lblRetour_Click(object sender, EventArgs e)
        {
            FrmClients form = new FrmClients();
            form.Show();
            this.Hide();
        }

        public void enabled_true()
        {
            txtBoxCP.Enabled = true;
            txtBoxMail.Enabled = true;
            txtNom.Enabled = true;
            txtBoxPrenom.Enabled = true;
            txtBoxRue.Enabled = true;
            txtBoxTel.Enabled = true;
            txtBoxVille.Enabled = true;
        }

        public void enabled_false()
        {
            txtBoxCP.Enabled = false;
            txtBoxMail.Enabled = false;
            txtNom.Enabled = false;
            txtBoxPrenom.Enabled = false;
            txtBoxRue.Enabled = false;
            txtBoxTel.Enabled = false;
            txtBoxVille.Enabled = false;
        }

        public void values_null()
        {
            txtBoxCP.Text = "";
            txtBoxMail.Text = "";
            txtNom.Text = "";
            txtBoxPrenom.Text = "";
            txtBoxRue.Text = "";
            txtBoxTel.Text = "";
            txtBoxVille.Text = "";
        }

        public void values_rempli()
        {
            lblId.Text = selectedClient.Cells[0].Value.ToString();
            txtNom.Text = selectedClient.Cells[1].Value.ToString();
            txtBoxPrenom.Text = selectedClient.Cells[7].Value.ToString();
            txtBoxRue.Text = selectedClient.Cells[2].Value.ToString();
            txtBoxCP.Text = selectedClient.Cells[3].Value.ToString();
            txtBoxVille.Text = selectedClient.Cells[4].Value.ToString();
            txtBoxTel.Text = selectedClient.Cells[5].Value.ToString();
            txtBoxMail.Text = selectedClient.Cells[6].Value.ToString();
        }

    }
}
