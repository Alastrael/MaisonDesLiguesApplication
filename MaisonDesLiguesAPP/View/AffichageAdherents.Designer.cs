namespace MaisonDesLiguesAPP
{
    partial class AffichageAdherents
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
            this.listBoxadh = new System.Windows.Forms.ListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.retour = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // listBoxadh
            // 
            this.listBoxadh.FormattingEnabled = true;
            this.listBoxadh.Location = new System.Drawing.Point(59, 123);
            this.listBoxadh.Name = "listBoxadh";
            this.listBoxadh.Size = new System.Drawing.Size(181, 82);
            this.listBoxadh.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(113, 220);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(12, 76);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(63, 28);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 11;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // AffichageAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 255);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listBoxadh);
            this.Name = "AffichageAdherents";
            this.Text = "Infos Adhérent";
            this.Load += new System.EventHandler(this.ListerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxadh;
        private System.Windows.Forms.Button btnValider;
        private MetroFramework.Controls.MetroTile retour;
    }
}