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

    public partial class FrmModifierFournisseur : Form
    {
        DataGridViewRow selectedFournisseur;

        public FrmModifierFournisseur()
        {
            InitializeComponent();    
        }

        public FrmModifierFournisseur(DataGridViewRow selectedFournisseur)
        {
            InitializeComponent();

            this.selectedFournisseur = selectedFournisseur;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            string nom = txtBoxNom.Text;
            string prenom = txtBoxPrenom.Text;
            string rue = txtBoxRue.Text;
            string codePostal = txtBoxCP.Text;
            string ville = txtBoxVille.Text;
            string tel = txtBoxTel.Text;
            string email = txtBoxMail.Text;
            if (comboBox.Text == "Modifier")
            {
                GestionFournisseur.modifier(id, nom, prenom, rue, codePostal, ville, tel, email);
                MessageBox.Show("Vous avez bien modifier le fournisseur avec le nom :" + nom);
            }
            else if (comboBox.Text == "Ajouter")
            {

                GestionFournisseur.ajouter(nom, prenom, rue, codePostal, ville, tel, email);
                MessageBox.Show("Vous avez bien ajouter le fournisseur avec le nom : " + nom);
            }
            else
            {
                GestionFournisseur.supprimer(id);
                MessageBox.Show("Vous avez bien supprimer le fournisseur avec le nom : " + nom);
            }

            FrmFournisseur form = new FrmFournisseur();
            form.Show();
            this.Hide();
        }

        private void FrmModifierFournisseur_Load(object sender, EventArgs e)
        {
            lblId.Text = selectedFournisseur.Cells[0].Value.ToString();
            txtBoxNom.Text = selectedFournisseur.Cells[1].Value.ToString();
            txtBoxRue.Text = selectedFournisseur.Cells[2].Value.ToString();
            txtBoxCP.Text = selectedFournisseur.Cells[3].Value.ToString();
            txtBoxVille.Text = selectedFournisseur.Cells[4].Value.ToString();
            txtBoxTel.Text = selectedFournisseur.Cells[5].Value.ToString();
            txtBoxMail.Text = selectedFournisseur.Cells[6].Value.ToString();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text == "Ajouter")
            {
                txtBoxCP.Text = "";
                txtBoxMail.Text = "";
                txtBoxNom.Text = "";
                txtBoxPrenom.Text = "";
                txtBoxRue.Text = "";
                txtBoxTel.Text = "";
                txtBoxVille.Text = "";
                btn.Text = "Ajouter";
            }

            else if (comboBox.Text == "Supprimer")
            {
                txtBoxCP.Enabled = false;
                txtBoxMail.Enabled = false;
                txtBoxNom.Enabled = false;
                txtBoxPrenom.Enabled = false;
                txtBoxRue.Enabled = false;
                txtBoxTel.Enabled = false;
                txtBoxVille.Enabled = false;
                btn.Text = "Supprimer";
            }

        }

        private void lblRetour_Click(object sender, EventArgs e)
        {
            FrmFournisseur form = new FrmFournisseur();
            form.Show();
            this.Hide();
        }

        private void txtBoxNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

