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
            this.SuspendLayout();
            // 
            // listBoxSupprimerAdh
            // 
            this.listBoxSupprimerAdh.FormattingEnabled = true;
            this.listBoxSupprimerAdh.Location = new System.Drawing.Point(12, 12);
            this.listBoxSupprimerAdh.Name = "listBoxSupprimerAdh";
            this.listBoxSupprimerAdh.Size = new System.Drawing.Size(174, 160);
            this.listBoxSupprimerAdh.TabIndex = 0;
            // 
            // buttonSuppression
            // 
            this.buttonSuppression.Location = new System.Drawing.Point(43, 187);
            this.buttonSuppression.Name = "buttonSuppression";
            this.buttonSuppression.Size = new System.Drawing.Size(111, 33);
            this.buttonSuppression.TabIndex = 1;
            this.buttonSuppression.Text = "Supprimer";
            this.buttonSuppression.UseVisualStyleBackColor = true;
            this.buttonSuppression.Click += new System.EventHandler(this.buttonSuppression_Click);
            // 
            // SupprimerAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 273);
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
    }
}