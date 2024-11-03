namespace gomezBoutique
{
    partial class FrmFournisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataFournisseur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFournisseur
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataFournisseur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFournisseur.Location = new System.Drawing.Point(0, 0);
            this.dataFournisseur.Name = "dataFournisseur";
            this.dataFournisseur.Size = new System.Drawing.Size(832, 450);
            this.dataFournisseur.TabIndex = 0;
            this.dataFournisseur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFournisseur_CellDoubleClick);
            // 
            // FrmFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.dataFournisseur);
            this.Name = "FrmFournisseur";
            this.Text = "FrmFournisseur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFournisseur_FormClosing);
            this.Load += new System.EventHandler(this.FrmFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFournisseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFournisseur;
    }
}