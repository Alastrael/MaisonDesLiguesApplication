namespace MaisonDesLiguesAPP.View
{
    partial class GérerEvents
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
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClubs
            // 
            this.listBoxClubs.FormattingEnabled = true;
            this.listBoxClubs.Location = new System.Drawing.Point(12, 12);
            this.listBoxClubs.Name = "listBoxClubs";
            this.listBoxClubs.Size = new System.Drawing.Size(167, 108);
            this.listBoxClubs.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(185, 12);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(91, 25);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // GérerEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listBoxClubs);
            this.Name = "GérerEvents";
            this.Text = "GérerEvents";
            this.Load += new System.EventHandler(this.GérerEvents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClubs;
        private System.Windows.Forms.Button btnValider;
    }
}