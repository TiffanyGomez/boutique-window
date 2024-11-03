namespace gomezBoutique
{
    partial class FrmAccueilPerso
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boutiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProduits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.côtéProfessionelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.retourTools = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.creerMonCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outilsToolStripMenuItem,
            this.boutiqueToolStripMenuItem,
            this.retourTools,
            this.clientsToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(476, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.toolStripSeparator1});
            this.outilsToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // boutiqueToolStripMenuItem
            // 
            this.boutiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProduits,
            this.toolStripSeparator4,
            this.côtéProfessionelToolStripMenuItem,
            this.toolStripSeparator5});
            this.boutiqueToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutiqueToolStripMenuItem.Name = "boutiqueToolStripMenuItem";
            this.boutiqueToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.boutiqueToolStripMenuItem.Text = "Boutique";
            // 
            // toolStripProduits
            // 
            this.toolStripProduits.Name = "toolStripProduits";
            this.toolStripProduits.Size = new System.Drawing.Size(126, 22);
            this.toolStripProduits.Text = "Produits";
            this.toolStripProduits.Click += new System.EventHandler(this.côtéClientToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(123, 6);
            // 
            // côtéProfessionelToolStripMenuItem
            // 
            this.côtéProfessionelToolStripMenuItem.Name = "côtéProfessionelToolStripMenuItem";
            this.côtéProfessionelToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.côtéProfessionelToolStripMenuItem.Text = "A Propos";
            this.côtéProfessionelToolStripMenuItem.Click += new System.EventHandler(this.côtéProfessionelToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(123, 6);
            // 
            // retourTools
            // 
            this.retourTools.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.retourTools.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retourTools.Name = "retourTools";
            this.retourTools.Size = new System.Drawing.Size(57, 20);
            this.retourTools.Text = "Retour";
            this.retourTools.Click += new System.EventHandler(this.retourTools_Click);
            // 
            // clientsToolStripMenuItem1
            // 
            this.clientsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem2,
            this.toolStripSeparator3,
            this.creerMonCompteToolStripMenuItem});
            this.clientsToolStripMenuItem1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsToolStripMenuItem1.Name = "clientsToolStripMenuItem1";
            this.clientsToolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.clientsToolStripMenuItem1.Text = "Mon compte";
            // 
            // clientsToolStripMenuItem2
            // 
            this.clientsToolStripMenuItem2.Name = "clientsToolStripMenuItem2";
            this.clientsToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.clientsToolStripMenuItem2.Text = "Mes informations";
            this.clientsToolStripMenuItem2.Click += new System.EventHandler(this.clientsToolStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // creerMonCompteToolStripMenuItem
            // 
            this.creerMonCompteToolStripMenuItem.Name = "creerMonCompteToolStripMenuItem";
            this.creerMonCompteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creerMonCompteToolStripMenuItem.Text = "Creer mon compte";
            this.creerMonCompteToolStripMenuItem.Click += new System.EventHandler(this.creerMonCompteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // FrmAccueilPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(476, 268);
            this.Controls.Add(this.menuStrip);
            this.Name = "FrmAccueilPerso";
            this.Text = "FrmAccueilPerso";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem boutiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripProduits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem côtéProfessionelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem retourTools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creerMonCompteToolStripMenuItem;
    }
}