namespace MaisonDesLiguesAPP
{
    partial class AffecterAdherent
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
            this.listBoxAdherents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxClubs = new System.Windows.Forms.ListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCotisation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.retour = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // listBoxAdherents
            // 
            this.listBoxAdherents.FormattingEnabled = true;
            this.listBoxAdherents.Location = new System.Drawing.Point(84, 96);
            this.listBoxAdherents.Name = "listBoxAdherents";
            this.listBoxAdherents.Size = new System.Drawing.Size(206, 95);
            this.listBoxAdherents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionnez l\'adhérent à affecter";
            // 
            // listBoxClubs
            // 
            this.listBoxClubs.FormattingEnabled = true;
            this.listBoxClubs.Location = new System.Drawing.Point(84, 219);
            this.listBoxClubs.Name = "listBoxClubs";
            this.listBoxClubs.Size = new System.Drawing.Size(209, 95);
            this.listBoxClubs.TabIndex = 2;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(147, 393);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(78, 34);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sélectionnez le club où sera affecté cet adhérent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Séléctionnez le montant de la cotisation de cet Adhérent pour ce Club";
            // 
            // textBoxCotisation
            // 
            this.textBoxCotisation.Location = new System.Drawing.Point(134, 356);
            this.textBoxCotisation.Name = "textBoxCotisation";
            this.textBoxCotisation.Size = new System.Drawing.Size(100, 20);
            this.textBoxCotisation.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "€";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(155, 401);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 23);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "metroTile1";
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(3, 69);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(63, 28);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 9;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // AffecterAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 439);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCotisation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listBoxClubs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAdherents);
            this.Name = "AffecterAdherent";
            this.Text = "Affecter un Adherent";
            this.Load += new System.EventHandler(this.AffecterAdherent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAdherents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxClubs;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCotisation;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile retour;
    }
}