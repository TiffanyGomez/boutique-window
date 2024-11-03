namespace gomezBoutique
{
    partial class FrmConnexion
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
            this.components = new System.ComponentModel.Container();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxMdp = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErp = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(77, 22);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(119, 17);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Se connecter =";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(12, 64);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 15);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(12, 111);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(98, 15);
            this.lblMdp.TabIndex = 2;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(116, 64);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(134, 20);
            this.boxId.TabIndex = 3;
            this.boxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxId_KeyPress);
            // 
            // boxMdp
            // 
            this.boxMdp.Location = new System.Drawing.Point(116, 111);
            this.boxMdp.Name = "boxMdp";
            this.boxMdp.PasswordChar = '*';
            this.boxMdp.Size = new System.Drawing.Size(134, 20);
            this.boxMdp.TabIndex = 4;
            this.boxMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMdp_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(90, 172);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Valider";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // lblErp
            // 
            this.lblErp.AutoSize = true;
            this.lblErp.Location = new System.Drawing.Point(33, 150);
            this.lblErp.Name = "lblErp";
            this.lblErp.Size = new System.Drawing.Size(0, 13);
            this.lblErp.TabIndex = 6;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(86, 146);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(115, 26);
            this.lblErreur.TabIndex = 7;
            this.lblErreur.Text = "Veuillez réessayer !";
            this.lblErreur.Visible = false;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 207);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.lblErp);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.boxMdp);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblConnexion);
            this.Name = "FrmConnexion";
            this.Text = "FrmConnexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConnexion_FormClosing);
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxMdp;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblErp;
        private System.Windows.Forms.Label lblErreur;
    }
}