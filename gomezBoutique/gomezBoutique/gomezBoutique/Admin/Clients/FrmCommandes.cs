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
    public partial class FrmCommandes : Form
    {
        public FrmCommandes()
        {
            InitializeComponent();
        }

        private void FrmCommandes_Load(object sender, EventArgs e)
        {
            dataCommande.DataSource = GestionCommandes.getTuples();
        }
    }
}
