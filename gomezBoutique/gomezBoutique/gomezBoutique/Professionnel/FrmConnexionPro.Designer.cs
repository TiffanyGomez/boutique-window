namespace gomezBoutique
{
    partial class FrmConnexionPro
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
            this.lblErreur = new System.Windows.Forms.Label();
            this.lblErp = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.boxMdp = new System.Windows.Forms.TextBox();
            this.boxId = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(93, 141);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(115, 26);
            this.lblErreur.TabIndex = 15;
            this.lblErreur.Text = "Veuillez réessayer !";
            this.lblErreur.Visible = false;
            // 
            // lblErp
            // 
            this.lblErp.AutoSize = true;
            this.lblErp.Location = new System.Drawing.Point(40, 145);
            this.lblErp.Name = "lblErp";
            this.lblErp.Size = new System.Drawing.Size(0, 13);
            this.lblErp.TabIndex = 14;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(97, 167);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Valider";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // boxMdp
            // 
            this.boxMdp.Location = new System.Drawing.Point(123, 106);
            this.boxMdp.Name = "boxMdp";
            this.boxMdp.PasswordChar = '*';
            this.boxMdp.Size = new System.Drawing.Size(134, 20);
            this.boxMdp.TabIndex = 12;
            this.boxMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMdp_KeyPress);
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(123, 59);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(134, 20);
            this.boxId.TabIndex = 11;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(19, 106);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(98, 15);
            this.lblMdp.TabIndex = 10;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(19, 59);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 15);
            this.lblIdentifiant.TabIndex = 9;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(84, 17);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(119, 17);
            this.lblConnexion.TabIndex = 8;
            this.lblConnexion.Text = "Se connecter =";
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // FrmConnexionPro
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
            this.Name = "FrmConnexionPro";
            this.Text = "FrmConnexionPro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConnexionPro_FormClosing);
            this.Load += new System.EventHandler(this.FrmConnexionPro_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmConnexionPro_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Label lblErp;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox boxMdp;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.ErrorProvider erp;
    }
}