namespace gomezBoutique
{
    partial class FrmPreAccueil
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnPerso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdmin.FlatAppearance.BorderSize = 3;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdmin.Location = new System.Drawing.Point(194, 159);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(183, 63);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrateur";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(12, 30);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(350, 24);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Bienvenu dans ma boutique !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Je veux me renseigner en tant que :";
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.SystemColors.Control;
            this.btnPro.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnPro.FlatAppearance.BorderSize = 3;
            this.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPro.Location = new System.Drawing.Point(8, 159);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(183, 63);
            this.btnPro.TabIndex = 4;
            this.btnPro.Text = "Professionnel";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnPerso
            // 
            this.btnPerso.BackColor = System.Drawing.SystemColors.Control;
            this.btnPerso.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPerso.FlatAppearance.BorderSize = 3;
            this.btnPerso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPerso.Location = new System.Drawing.Point(383, 159);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(183, 63);
            this.btnPerso.TabIndex = 5;
            this.btnPerso.Text = "Particulier";
            this.btnPerso.UseVisualStyleBackColor = false;
            this.btnPerso.Click += new System.EventHandler(this.btnPerso_Click);
            // 
            // FrmPreAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(585, 245);
            this.Controls.Add(this.btnPerso);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdmin);
            this.Name = "FrmPreAccueil";
            this.Text = "FrmPreAccueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPreAccueil_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnPerso;
    }
}