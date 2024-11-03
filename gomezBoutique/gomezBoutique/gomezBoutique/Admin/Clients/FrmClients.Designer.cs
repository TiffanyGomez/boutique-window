namespace gomezBoutique
{
    partial class FrmClients
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
            this.dataClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClient
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            this.dataClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClient.Location = new System.Drawing.Point(-12, 1);
            this.dataClient.Name = "dataClient";
            this.dataClient.Size = new System.Drawing.Size(824, 449);
            this.dataClient.TabIndex = 1;
            this.dataClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClient_CellContentClick);
            this.dataClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClient_CellDoubleClick);
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataClient);
            this.Name = "FrmClients";
            this.Text = "FrmClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClient_FormClosing);
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClient;
    }
}