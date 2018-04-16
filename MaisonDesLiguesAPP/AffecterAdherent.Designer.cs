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
            this.SuspendLayout();
            // 
            // listBoxAdherents
            // 
            this.listBoxAdherents.FormattingEnabled = true;
            this.listBoxAdherents.Location = new System.Drawing.Point(15, 52);
            this.listBoxAdherents.Name = "listBoxAdherents";
            this.listBoxAdherents.Size = new System.Drawing.Size(206, 95);
            this.listBoxAdherents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slectionnez l\'adhérent à affecter";
            // 
            // listBoxClubs
            // 
            this.listBoxClubs.FormattingEnabled = true;
            this.listBoxClubs.Location = new System.Drawing.Point(12, 185);
            this.listBoxClubs.Name = "listBoxClubs";
            this.listBoxClubs.Size = new System.Drawing.Size(209, 95);
            this.listBoxClubs.TabIndex = 2;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(12, 301);
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
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sélectionnez le club où sera affecté cet adhérent";
            // 
            // AffecterAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listBoxClubs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAdherents);
            this.Name = "AffecterAdherent";
            this.Text = "AffecterAdherent";
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
    }
}