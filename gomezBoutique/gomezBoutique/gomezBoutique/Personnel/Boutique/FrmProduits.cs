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
    public partial class FrmProduits : Form
    {
        public FrmProduits()
        {
            InitializeComponent();
        }

        private void FrmProduits_Load(object sender, EventArgs e)
        {
            dataproduits.DataSource = GestionProduits.getTuples();
            dataproduits.Columns[0].Width = 100;
            dataproduits.Columns[2].Width = 450;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            rafraichirDataGrid();

        }

        private void rafraichirDataGrid()
        {
            string recherche = txtRecherche.Text;
            GestionProduits.getTuplesByRecherche(recherche);
            dataproduits.DataSource = GestionProduits.getTuplesByRecherche(recherche);
            dataproduits.Columns[0].Width = 100;
            dataproduits.Columns[2].Width = 450;
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            rafraichirDataGrid();
        }

        private void dataproduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
