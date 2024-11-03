namespace gomezBoutique
{
    partial class FrmAPropos
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMyname = new System.Windows.Forms.Label();
            this.lblmaj = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.grpModule = new System.Windows.Forms.GroupBox();
            this.lblNomProf = new System.Windows.Forms.Label();
            this.lblNomEnseignant = new System.Windows.Forms.Label();
            this.lblBaseprog = new System.Windows.Forms.Label();
            this.pbZiknco = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZiknco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(18, 237);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(165, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(118, 130);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "13/04/2023";
            // 
            // lblMyname
            // 
            this.lblMyname.AutoSize = true;
            this.lblMyname.Location = new System.Drawing.Point(65, 103);
            this.lblMyname.Name = "lblMyname";
            this.lblMyname.Size = new System.Drawing.Size(81, 13);
            this.lblMyname.TabIndex = 13;
            this.lblMyname.Text = "Tiffany GOMEZ";
            // 
            // lblmaj
            // 
            this.lblmaj.AutoSize = true;
            this.lblmaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaj.Location = new System.Drawing.Point(15, 130);
            this.lblmaj.Name = "lblmaj";
            this.lblmaj.Size = new System.Drawing.Size(107, 13);
            this.lblmaj.TabIndex = 12;
            this.lblmaj.Text = "Derniere Mise à jour :";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(15, 103);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(44, 13);
            this.lblAuteur.TabIndex = 11;
            this.lblAuteur.Text = "Auteur :";
            // 
            // grpModule
            // 
            this.grpModule.Controls.Add(this.lblNomProf);
            this.grpModule.Controls.Add(this.lblNomEnseignant);
            this.grpModule.Controls.Add(this.lblBaseprog);
            this.grpModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModule.Location = new System.Drawing.Point(18, 146);
            this.grpModule.Name = "grpModule";
            this.grpModule.Size = new System.Drawing.Size(165, 85);
            this.grpModule.TabIndex = 10;
            this.grpModule.TabStop = false;
            this.grpModule.Text = "Module SI4";
            // 
            // lblNomProf
            // 
            this.lblNomProf.AutoSize = true;
            this.lblNomProf.Location = new System.Drawing.Point(78, 58);
            this.lblNomProf.Name = "lblNomProf";
            this.lblNomProf.Size = new System.Drawing.Size(68, 13);
            this.lblNomProf.TabIndex = 7;
            this.lblNomProf.Text = "O.ALBERT";
            // 
            // lblNomEnseignant
            // 
            this.lblNomEnseignant.AutoSize = true;
            this.lblNomEnseignant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEnseignant.Location = new System.Drawing.Point(6, 58);
            this.lblNomEnseignant.Name = "lblNomEnseignant";
            this.lblNomEnseignant.Size = new System.Drawing.Size(66, 13);
            this.lblNomEnseignant.TabIndex = 7;
            this.lblNomEnseignant.Text = "Enseignant :";
            // 
            // lblBaseprog
            // 
            this.lblBaseprog.AutoSize = true;
            this.lblBaseprog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseprog.Location = new System.Drawing.Point(26, 27);
            this.lblBaseprog.Name = "lblBaseprog";
            this.lblBaseprog.Size = new System.Drawing.Size(102, 13);
            this.lblBaseprog.TabIndex = 7;
            this.lblBaseprog.Text = "\"Boutique personel\"";
            // 
            // pbZiknco
            // 
            this.pbZiknco.Image = global::gomezBoutique.Properties.Resources.boutique_logo_4_01_;
            this.pbZiknco.Location = new System.Drawing.Point(27, 25);
            this.pbZiknco.Name = "pbZiknco";
            this.pbZiknco.Size = new System.Drawing.Size(150, 52);
            this.pbZiknco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZiknco.TabIndex = 9;
            this.pbZiknco.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(59, 7);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(87, 15);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Ma Boutique";
            // 
            // FrmAPropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 269);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMyname);
            this.Controls.Add(this.lblmaj);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.grpModule);
            this.Controls.Add(this.pbZiknco);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAPropos";
            this.Text = "FrmAPropos";
            this.grpModule.ResumeLayout(false);
            this.grpModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZiknco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMyname;
        private System.Windows.Forms.Label lblmaj;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.GroupBox grpModule;
        private System.Windows.Forms.Label lblNomProf;
        private System.Windows.Forms.Label lblNomEnseignant;
        private System.Windows.Forms.Label lblBaseprog;
        private System.Windows.Forms.PictureBox pbZiknco;
        private System.Windows.Forms.Label lblTitre;
    }
}