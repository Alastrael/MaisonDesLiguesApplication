namespace MaisonDesLiguesAPP
{
    partial class SupprimerClub
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
            this.listBoxSupprimerClb = new System.Windows.Forms.ListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSupprimerClb
            // 
            this.listBoxSupprimerClb.FormattingEnabled = true;
            this.listBoxSupprimerClb.Location = new System.Drawing.Point(43, 12);
            this.listBoxSupprimerClb.Name = "listBoxSupprimerClb";
            this.listBoxSupprimerClb.Size = new System.Drawing.Size(201, 121);
            this.listBoxSupprimerClb.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(107, 157);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // SupprimerClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 214);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listBoxSupprimerClb);
            this.Name = "SupprimerClub";
            this.Text = "SupprimerClub";
            this.Load += new System.EventHandler(this.SupprimerClub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSupprimerClb;
        private System.Windows.Forms.Button btnValider;
    }
}