﻿using System;
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
    public partial class FrmAjoutCompte : Form
    {
        public FrmAjoutCompte()
        {
            InitializeComponent();
        }

        private void btnConfirmez_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(lblId.Text);
            string nom = txtNom.Text;
            string prenom = txtBoxPrenom.Text;
            string rue = txtBoxRue.Text;
            string codePostal = txtBoxCP.Text;
            string ville = txtBoxVille.Text;
            string tel = txtBoxTel.Text;
            string email = txtBoxMail.Text;
            GestionClients.ajouter(nom, prenom, rue, codePostal, ville, tel, email);
            MessageBox.Show("Vous avez bien creez votre compte : " + nom);
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
