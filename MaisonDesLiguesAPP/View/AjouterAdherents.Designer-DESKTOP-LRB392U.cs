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
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.labelDATE = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.materialFlatValider = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxCP = new System.Windows.Forms.MaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // labelNOM
            // 
            this.labelNOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNOM.AutoSize = true;
            this.labelNOM.Location = new System.Drawing.Point(12, 81);
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
            this.labelPRENOM.Location = new System.Drawing.Point(180, 84);
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
            this.textBoxNOM.Location = new System.Drawing.Point(50, 81);
            this.textBoxNOM.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxNOM.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxNOM.Name = "textBoxNOM";
            this.textBoxNOM.Size = new System.Drawing.Size(87, 20);
            this.textBoxNOM.TabIndex = 2;
            // 
            // textBoxPRENOM
            // 
            this.textBoxPRENOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPRENOM.Location = new System.Drawing.Point(262, 81);
            this.textBoxPRENOM.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxPRENOM.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxPRENOM.Name = "textBoxPRENOM";
            this.textBoxPRENOM.Size = new System.Drawing.Size(87, 20);
            this.textBoxPRENOM.TabIndex = 3;
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(123, 131);
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
            this.labelDATE.Location = new System.Drawing.Point(11, 131);
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
            this.labelAdresse.Location = new System.Drawing.Point(11, 171);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 7;
            this.labelAdresse.Text = "Adresse";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdresse.Location = new System.Drawing.Point(62, 168);
            this.textBoxAdresse.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxAdresse.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdresse.TabIndex = 10;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVille.Location = new System.Drawing.Point(107, 228);
            this.textBoxVille.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxVille.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(87, 20);
            this.textBoxVille.TabIndex = 12;
            // 
            // materialFlatValider
            // 
            this.materialFlatValider.AutoSize = true;
            this.materialFlatValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatValider.Depth = 0;
            this.materialFlatValider.Icon = null;
            this.materialFlatValider.Location = new System.Drawing.Point(324, 255);
            this.materialFlatValider.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatValider.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatValider.Name = "materialFlatValider";
            this.materialFlatValider.Primary = false;
            this.materialFlatValider.Size = new System.Drawing.Size(76, 36);
            this.materialFlatValider.TabIndex = 13;
            this.materialFlatValider.Text = "Valider";
            this.materialFlatValider.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 229);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Ville";
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(107, 202);
            this.textBoxCP.Mask = "00000";
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(38, 20);
            this.textBoxCP.TabIndex = 15;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 203);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Code Postal";
            // 
            // AjouterAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 306);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialFlatValider);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelDATE);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.textBoxPRENOM);
            this.Controls.Add(this.textBoxNOM);
            this.Controls.Add(this.labelPRENOM);
            this.Controls.Add(this.labelNOM);
            this.Name = "AjouterAdherents";
            this.Text = "Ajouter un adhérent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNOM;
        private System.Windows.Forms.Label labelPRENOM;
        private System.Windows.Forms.TextBox textBoxNOM;
        private System.Windows.Forms.TextBox textBoxPRENOM;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.Label labelDATE;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxVille;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatValider;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaskedTextBox textBoxCP;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}