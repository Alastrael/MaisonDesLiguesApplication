﻿namespace MaisonDesLiguesAPP.View
{
    partial class AffecterAdhEvent
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
            this.listBoxAdh = new System.Windows.Forms.ListBox();
            this.btnAffecter = new System.Windows.Forms.Button();
            this.retour = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // listBoxAdh
            // 
            this.listBoxAdh.FormattingEnabled = true;
            this.listBoxAdh.Location = new System.Drawing.Point(12, 128);
            this.listBoxAdh.Name = "listBoxAdh";
            this.listBoxAdh.Size = new System.Drawing.Size(327, 108);
            this.listBoxAdh.TabIndex = 0;
            // 
            // btnAffecter
            // 
            this.btnAffecter.Location = new System.Drawing.Point(74, 242);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(203, 26);
            this.btnAffecter.TabIndex = 1;
            this.btnAffecter.Text = "Affecter";
            this.btnAffecter.UseVisualStyleBackColor = true;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(12, 81);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(63, 28);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 10;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // AffecterAdhEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 282);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.btnAffecter);
            this.Controls.Add(this.listBoxAdh);
            this.Name = "AffecterAdhEvent";
            this.Text = "Affecter un adhérent à un évènement";
            this.Load += new System.EventHandler(this.AffecterAdhEvent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAdh;
        private System.Windows.Forms.Button btnAffecter;
        private MetroFramework.Controls.MetroTile retour;
    }
}