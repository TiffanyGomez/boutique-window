namespace gomezBoutique
{
    partial class FrmComptePro
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
            this.btnConfirmez = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtQui = new System.Windows.Forms.TextBox();
            this.lblQui = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxCP = new System.Windows.Forms.TextBox();
            this.txtBoxRue = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmez
            // 
            this.btnConfirmez.Location = new System.Drawing.Point(184, 321);
            this.btnConfirmez.Name = "btnConfirmez";
            this.btnConfirmez.Size = new System.Drawing.Size(75, 43);
            this.btnConfirmez.TabIndex = 68;
            this.btnConfirmez.Text = "Confirmez";
            this.btnConfirmez.UseVisualStyleBackColor = true;
            this.btnConfirmez.Visible = false;
            this.btnConfirmez.Click += new System.EventHandler(this.btnConfirmez_Click);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(201, 65);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 23);
            this.btnOk.TabIndex = 67;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtQui
            // 
            this.txtQui.Location = new System.Drawing.Point(172, 35);
            this.txtQui.Name = "txtQui";
            this.txtQui.Size = new System.Drawing.Size(100, 20);
            this.txtQui.TabIndex = 1;
            this.txtQui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQui_KeyPress);
            // 
            // lblQui
            // 
            this.lblQui.AutoSize = true;
            this.lblQui.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQui.Location = new System.Drawing.Point(33, 32);
            this.lblQui.Name = "lblQui";
            this.lblQui.Size = new System.Drawing.Size(123, 34);
            this.lblQui.TabIndex = 65;
            this.lblQui.Text = "Qui êtes vous ? \r\n( Nom )";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(9, 6);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 64;
            this.btnRetour.Text = "retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(43, 321);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 43);
            this.btnSupprimer.TabIndex = 63;
            this.btnSupprimer.Text = "Supprimer \r\nmon compte";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(138, 94);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 2;
            this.txtNom.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(113, 64);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 13);
            this.lblId.TabIndex = 61;
            this.lblId.Text = "Identifiant";
            this.lblId.Visible = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(184, 321);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 43);
            this.btn.TabIndex = 60;
            this.btn.Text = "Modifier\r\nmon compte";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Enabled = false;
            this.txtBoxMail.Location = new System.Drawing.Point(138, 265);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(121, 20);
            this.txtBoxMail.TabIndex = 8;
            this.txtBoxMail.Visible = false;
            this.txtBoxMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMail_KeyPress);
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Enabled = false;
            this.txtBoxTel.Location = new System.Drawing.Point(138, 235);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(121, 20);
            this.txtBoxTel.TabIndex = 7;
            this.txtBoxTel.Visible = false;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Enabled = false;
            this.txtBoxVille.Location = new System.Drawing.Point(138, 203);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(121, 20);
            this.txtBoxVille.TabIndex = 6;
            this.txtBoxVille.Visible = false;
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.Enabled = false;
            this.txtBoxCP.Location = new System.Drawing.Point(138, 175);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(121, 20);
            this.txtBoxCP.TabIndex = 5;
            this.txtBoxCP.Visible = false;
            // 
            // txtBoxRue
            // 
            this.txtBoxRue.Enabled = false;
            this.txtBoxRue.Location = new System.Drawing.Point(138, 147);
            this.txtBoxRue.Name = "txtBoxRue";
            this.txtBoxRue.Size = new System.Drawing.Size(121, 20);
            this.txtBoxRue.TabIndex = 4;
            this.txtBoxRue.Visible = false;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Enabled = false;
            this.txtBoxPrenom.Location = new System.Drawing.Point(138, 120);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPrenom.TabIndex = 3;
            this.txtBoxPrenom.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Téléphone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Code Postal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Rue :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nom :";
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompte.Location = new System.Drawing.Point(90, 34);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(114, 18);
            this.lblCompte.TabIndex = 46;
            this.lblCompte.Text = "Mon compte :";
            this.lblCompte.Visible = false;
            // 
            // FrmComptePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 370);
            this.Controls.Add(this.btnConfirmez);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtQui);
            this.Controls.Add(this.lblQui);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtBoxTel);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxCP);
            this.Controls.Add(this.txtBoxRue);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCompte);
            this.Name = "FrmComptePro";
            this.Text = "FrmComptePro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmez;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtQui;
        private System.Windows.Forms.Label lblQui;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxCP;
        private System.Windows.Forms.TextBox txtBoxRue;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompte;
    }
}