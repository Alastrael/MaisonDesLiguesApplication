namespace MaisonDesLiguesAPP
{
    partial class SupprimerAdherents
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
            this.listBoxSupprimerAdh = new System.Windows.Forms.ListBox();
            this.buttonSuppression = new System.Windows.Forms.Button();
            this.retour = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // listBoxSupprimerAdh
            // 
            this.listBoxSupprimerAdh.FormattingEnabled = true;
            this.listBoxSupprimerAdh.Location = new System.Drawing.Point(33, 109);
            this.listBoxSupprimerAdh.Name = "listBoxSupprimerAdh";
            this.listBoxSupprimerAdh.Size = new System.Drawing.Size(174, 160);
            this.listBoxSupprimerAdh.TabIndex = 0;
            // 
            // buttonSuppression
            // 
            this.buttonSuppression.Location = new System.Drawing.Point(75, 275);
            this.buttonSuppression.Name = "buttonSuppression";
            this.buttonSuppression.Size = new System.Drawing.Size(111, 33);
            this.buttonSuppression.TabIndex = 1;
            this.buttonSuppression.Text = "Supprimer";
            this.buttonSuppression.UseVisualStyleBackColor = true;
            this.buttonSuppression.Click += new System.EventHandler(this.buttonSuppression_Click);
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(12, 73);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(63, 28);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 11;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // SupprimerAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 320);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.buttonSuppression);
            this.Controls.Add(this.listBoxSupprimerAdh);
            this.Name = "SupprimerAdherents";
            this.Text = "Supprimer un Adhérent";
            this.Load += new System.EventHandler(this.supprimer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSupprimerAdh;
        private System.Windows.Forms.Button buttonSuppression;
        private MetroFramework.Controls.MetroTile retour;
    }
}