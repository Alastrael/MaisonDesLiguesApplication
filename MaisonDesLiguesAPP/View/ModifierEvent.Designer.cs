﻿namespace MaisonDesLiguesAPP.View
{
    partial class ModifierEvent
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
            this.maskTitre = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskTitre
            // 
            this.maskTitre.Location = new System.Drawing.Point(12, 33);
            this.maskTitre.Name = "maskTitre";
            this.maskTitre.Size = new System.Drawing.Size(476, 20);
            this.maskTitre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre de l\'évènement";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(12, 93);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 2;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(289, 93);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(199, 20);
            this.dtpFin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date du début de l\'évènement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date de fin de l\'évènement";
            // 
            // ModifierEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskTitre);
            this.Name = "ModifierEvent";
            this.Text = "ModifierEvent";
            this.Load += new System.EventHandler(this.ModifierEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}