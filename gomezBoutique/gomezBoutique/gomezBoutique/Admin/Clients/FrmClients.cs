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
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            dataClient.DataSource = GestionClients.getTuples();
        }

        private void FrmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAccueil formulaire = new FrmAccueil();
            formulaire.Show();
            this.Hide();
        }

        private void dataClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModifierClient form = new FrmModifierClient(dataClient.CurrentRow);
            form.Show();
            this.Hide();
        }

        private void dataClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
