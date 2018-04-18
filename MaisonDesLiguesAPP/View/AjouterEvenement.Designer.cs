namespace MaisonDesLiguesAPP.View
{
    partial class AjouterEvenement
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
            System.Windows.Forms.Button btnCréer;
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.maskTitre = new System.Windows.Forms.MaskedTextBox();
            this.listBoxclub = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            btnCréer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCréer
            // 
            btnCréer.Location = new System.Drawing.Point(219, 282);
            btnCréer.Name = "btnCréer";
            btnCréer.Size = new System.Drawing.Size(90, 40);
            btnCréer.TabIndex = 13;
            btnCréer.Text = "Créer";
            btnCréer.UseVisualStyleBackColor = true;
            btnCréer.Click += new System.EventHandler(this.btnCréer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date de fin de l\'évènement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date du début de l\'évènement";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(306, 100);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(199, 20);
            this.dtpFin.TabIndex = 10;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(29, 100);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titre de l\'évènement";
            // 
            // maskTitre
            // 
            this.maskTitre.Location = new System.Drawing.Point(29, 40);
            this.maskTitre.Name = "maskTitre";
            this.maskTitre.Size = new System.Drawing.Size(476, 20);
            this.maskTitre.TabIndex = 7;
            // 
            // listBoxclub
            // 
            this.listBoxclub.FormattingEnabled = true;
            this.listBoxclub.Location = new System.Drawing.Point(185, 148);
            this.listBoxclub.Name = "listBoxclub";
            this.listBoxclub.Size = new System.Drawing.Size(189, 121);
            this.listBoxclub.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cet évènement appartient au club :";
            // 
            // AjouterEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxclub);
            this.Controls.Add(btnCréer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskTitre);
            this.Name = "AjouterEvenement";
            this.Text = "AjouterEvenement";
            this.Load += new System.EventHandler(this.AjouterEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskTitre;
        private System.Windows.Forms.ListBox listBoxclub;
        private System.Windows.Forms.Label label4;
    }
}