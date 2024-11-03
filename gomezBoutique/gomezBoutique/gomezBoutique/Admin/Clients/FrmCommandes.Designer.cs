namespace gomezBoutique
{
    partial class FrmCommandes
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
            this.dataCommande = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCommande
            // 
            this.dataCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCommande.Location = new System.Drawing.Point(0, 0);
            this.dataCommande.Name = "dataCommande";
            this.dataCommande.Size = new System.Drawing.Size(801, 453);
            this.dataCommande.TabIndex = 0;
            // 
            // FrmCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 178);
            this.Controls.Add(this.dataCommande);
            this.Name = "FrmCommandes";
            this.Text = "FrmCommandes";
            this.Load += new System.EventHandler(this.FrmCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCommande;
    }
}