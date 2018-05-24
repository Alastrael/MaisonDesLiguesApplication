namespace MaisonDesLiguesAPP.View
{
    partial class GérerAdhérentsClubs
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
            this.listBoxClubs = new System.Windows.Forms.ListBox();
            this.btnSelectClubs = new System.Windows.Forms.Button();
            this.listBoxAdh = new System.Windows.Forms.ListBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.retour = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // listBoxClubs
            // 
            this.listBoxClubs.FormattingEnabled = true;
            this.listBoxClubs.Location = new System.Drawing.Point(12, 120);
            this.listBoxClubs.Name = "listBoxClubs";
            this.listBoxClubs.Size = new System.Drawing.Size(167, 108);
            this.listBoxClubs.TabIndex = 0;
            // 
            // btnSelectClubs
            // 
            this.btnSelectClubs.Location = new System.Drawing.Point(185, 202);
            this.btnSelectClubs.Name = "btnSelectClubs";
            this.btnSelectClubs.Size = new System.Drawing.Size(75, 26);
            this.btnSelectClubs.TabIndex = 1;
            this.btnSelectClubs.Text = "Valider";
            this.btnSelectClubs.UseVisualStyleBackColor = true;
            this.btnSelectClubs.Click += new System.EventHandler(this.btnSelectClubs_Click);
            // 
            // listBoxAdh
            // 
            this.listBoxAdh.FormattingEnabled = true;
            this.listBoxAdh.Location = new System.Drawing.Point(12, 253);
            this.listBoxAdh.Name = "listBoxAdh";
            this.listBoxAdh.Size = new System.Drawing.Size(167, 108);
            this.listBoxAdh.TabIndex = 2;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(104, 377);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 23);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Editer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(12, 77);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(63, 28);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 11;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // GérerAdhérentsClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 416);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.listBoxAdh);
            this.Controls.Add(this.btnSelectClubs);
            this.Controls.Add(this.listBoxClubs);
            this.Name = "GérerAdhérentsClubs";
            this.Text = "GérerAdhérentsClubs";
            this.Load += new System.EventHandler(this.GérerAdhérentsClubs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClubs;
        private System.Windows.Forms.Button btnSelectClubs;
        private System.Windows.Forms.ListBox listBoxAdh;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroTile retour;
    }
}