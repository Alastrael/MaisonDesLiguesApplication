using System;
using System.Windows.Forms;

namespace MaisonDesLiguesAPP
{
    partial class AjouterAdherents
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
            this.labelNOM = new System.Windows.Forms.Label();
            this.labelPRENOM = new System.Windows.Forms.Label();
            this.textBoxNOM = new System.Windows.Forms.TextBox();
            this.textBoxPRENOM = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.labelDATE = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNOM
            // 
            this.labelNOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNOM.AutoSize = true;
            this.labelNOM.Location = new System.Drawing.Point(12, 31);
            this.labelNOM.Name = "labelNOM";
            this.labelNOM.Size = new System.Drawing.Size(29, 13);
            this.labelNOM.TabIndex = 0;
            this.labelNOM.Text = "Nom";
            // 
            // labelPRENOM
            // 
            this.labelPRENOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPRENOM.AutoSize = true;
            this.labelPRENOM.Location = new System.Drawing.Point(266, 31);
            this.labelPRENOM.Name = "labelPRENOM";
            this.labelPRENOM.Size = new System.Drawing.Size(43, 13);
            this.labelPRENOM.TabIndex = 1;
            this.labelPRENOM.Text = "Prénom";
            // 
            // textBoxNOM
            // 
            this.textBoxNOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNOM.Location = new System.Drawing.Point(50, 28);
            this.textBoxNOM.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxNOM.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxNOM.Name = "textBoxNOM";
            this.textBoxNOM.Size = new System.Drawing.Size(81, 20);
            this.textBoxNOM.TabIndex = 2;
            // 
            // textBoxPRENOM
            // 
            this.textBoxPRENOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPRENOM.Location = new System.Drawing.Point(315, 28);
            this.textBoxPRENOM.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxPRENOM.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxPRENOM.Name = "textBoxPRENOM";
            this.textBoxPRENOM.Size = new System.Drawing.Size(81, 20);
            this.textBoxPRENOM.TabIndex = 3;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouter.Location = new System.Drawing.Point(315, 232);
            this.buttonAjouter.MaximumSize = new System.Drawing.Size(80, 30);
            this.buttonAjouter.MinimumSize = new System.Drawing.Size(40, 30);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(80, 30);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Valider";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(177, 74);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(200, 20);
            this.dateNaissance.TabIndex = 5;
            // 
            // labelDATE
            // 
            this.labelDATE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDATE.AutoSize = true;
            this.labelDATE.Location = new System.Drawing.Point(75, 74);
            this.labelDATE.Name = "labelDATE";
            this.labelDATE.Size = new System.Drawing.Size(96, 13);
            this.labelDATE.TabIndex = 6;
            this.labelDATE.Text = "Date de naissance";
            // 
            // labelAdresse
            // 
            this.labelAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(12, 127);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 7;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelCP
            // 
            this.labelCP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(269, 127);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(63, 13);
            this.labelCP.TabIndex = 8;
            this.labelCP.Text = "Code postal";
            // 
            // labelVille
            // 
            this.labelVille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(105, 153);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(26, 13);
            this.labelVille.TabIndex = 9;
            this.labelVille.Text = "Ville";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdresse.Location = new System.Drawing.Point(63, 124);
            this.textBoxAdresse.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxAdresse.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdresse.TabIndex = 10;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCP.Location = new System.Drawing.Point(338, 124);
            this.textBoxCP.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxCP.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(58, 20);
            this.textBoxCP.TabIndex = 11;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVille.Location = new System.Drawing.Point(142, 150);
            this.textBoxVille.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxVille.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(81, 20);
            this.textBoxVille.TabIndex = 12;
            // 
            // AjouterAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 274);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelDATE);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxPRENOM);
            this.Controls.Add(this.textBoxNOM);
            this.Controls.Add(this.labelPRENOM);
            this.Controls.Add(this.labelNOM);
            this.Name = "AjouterAdherents";
            this.Text = "ajouterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNOM;
        private System.Windows.Forms.Label labelPRENOM;
        private System.Windows.Forms.TextBox textBoxNOM;
        private System.Windows.Forms.TextBox textBoxPRENOM;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.Label labelDATE;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxVille;
    }
}