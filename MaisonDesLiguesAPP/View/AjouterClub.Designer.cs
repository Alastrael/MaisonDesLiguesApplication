namespace MaisonDesLiguesAPP
{
    partial class AjouterClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterClub));
            this.buttonValiderAjoutClub = new System.Windows.Forms.Button();
            this.textBoxNomClub = new System.Windows.Forms.TextBox();
            this.textBoxLienClub = new System.Windows.Forms.TextBox();
            this.textBoxAdresseClub = new System.Windows.Forms.TextBox();
            this.textBoxVilleClub = new System.Windows.Forms.TextBox();
            this.textBoxEmailClub = new System.Windows.Forms.TextBox();
            this.labelNomClub = new System.Windows.Forms.Label();
            this.labelLienClub = new System.Windows.Forms.Label();
            this.labelAdresseClub = new System.Windows.Forms.Label();
            this.labelDepartementClub = new System.Windows.Forms.Label();
            this.labelVilleClub = new System.Windows.Forms.Label();
            this.labelTelephoneClub = new System.Windows.Forms.Label();
            this.labelEmailClub = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxtype = new System.Windows.Forms.ListBox();
            this.textBoxDepartementClub = new System.Windows.Forms.MaskedTextBox();
            this.textboxTel = new System.Windows.Forms.MaskedTextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonValiderAjoutClub
            // 
            this.buttonValiderAjoutClub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonValiderAjoutClub.Location = new System.Drawing.Point(366, 327);
            this.buttonValiderAjoutClub.Name = "buttonValiderAjoutClub";
            this.buttonValiderAjoutClub.Size = new System.Drawing.Size(75, 23);
            this.buttonValiderAjoutClub.TabIndex = 0;
            this.buttonValiderAjoutClub.Text = "Valider";
            this.buttonValiderAjoutClub.UseVisualStyleBackColor = false;
            this.buttonValiderAjoutClub.Click += new System.EventHandler(this.buttonValiderAjoutClub_Click);
            // 
            // textBoxNomClub
            // 
            this.textBoxNomClub.BackColor = System.Drawing.Color.LightGray;
            this.textBoxNomClub.Location = new System.Drawing.Point(103, 66);
            this.textBoxNomClub.Name = "textBoxNomClub";
            this.textBoxNomClub.Size = new System.Drawing.Size(312, 20);
            this.textBoxNomClub.TabIndex = 1;
            this.textBoxNomClub.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLienClub
            // 
            this.textBoxLienClub.BackColor = System.Drawing.Color.LightGray;
            this.textBoxLienClub.Location = new System.Drawing.Point(103, 92);
            this.textBoxLienClub.Name = "textBoxLienClub";
            this.textBoxLienClub.Size = new System.Drawing.Size(312, 20);
            this.textBoxLienClub.TabIndex = 2;
            // 
            // textBoxAdresseClub
            // 
            this.textBoxAdresseClub.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAdresseClub.Location = new System.Drawing.Point(103, 126);
            this.textBoxAdresseClub.Name = "textBoxAdresseClub";
            this.textBoxAdresseClub.Size = new System.Drawing.Size(296, 20);
            this.textBoxAdresseClub.TabIndex = 3;
            // 
            // textBoxVilleClub
            // 
            this.textBoxVilleClub.BackColor = System.Drawing.Color.LightGray;
            this.textBoxVilleClub.Location = new System.Drawing.Point(103, 184);
            this.textBoxVilleClub.Name = "textBoxVilleClub";
            this.textBoxVilleClub.Size = new System.Drawing.Size(127, 20);
            this.textBoxVilleClub.TabIndex = 5;
            // 
            // textBoxEmailClub
            // 
            this.textBoxEmailClub.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEmailClub.Location = new System.Drawing.Point(103, 236);
            this.textBoxEmailClub.Name = "textBoxEmailClub";
            this.textBoxEmailClub.Size = new System.Drawing.Size(306, 20);
            this.textBoxEmailClub.TabIndex = 7;
            // 
            // labelNomClub
            // 
            this.labelNomClub.AutoSize = true;
            this.labelNomClub.Location = new System.Drawing.Point(1, 66);
            this.labelNomClub.Name = "labelNomClub";
            this.labelNomClub.Size = new System.Drawing.Size(67, 13);
            this.labelNomClub.TabIndex = 8;
            this.labelNomClub.Text = "Nom du club";
            // 
            // labelLienClub
            // 
            this.labelLienClub.AutoSize = true;
            this.labelLienClub.Location = new System.Drawing.Point(1, 99);
            this.labelLienClub.Name = "labelLienClub";
            this.labelLienClub.Size = new System.Drawing.Size(65, 13);
            this.labelLienClub.TabIndex = 9;
            this.labelLienClub.Text = "Lien du club";
            // 
            // labelAdresseClub
            // 
            this.labelAdresseClub.AutoSize = true;
            this.labelAdresseClub.Location = new System.Drawing.Point(3, 129);
            this.labelAdresseClub.Name = "labelAdresseClub";
            this.labelAdresseClub.Size = new System.Drawing.Size(83, 13);
            this.labelAdresseClub.TabIndex = 10;
            this.labelAdresseClub.Text = "Adresse du club";
            // 
            // labelDepartementClub
            // 
            this.labelDepartementClub.AutoSize = true;
            this.labelDepartementClub.Location = new System.Drawing.Point(3, 155);
            this.labelDepartementClub.Name = "labelDepartementClub";
            this.labelDepartementClub.Size = new System.Drawing.Size(165, 13);
            this.labelDepartementClub.TabIndex = 11;
            this.labelDepartementClub.Text = "Département du club (ex : 92140)";
            // 
            // labelVilleClub
            // 
            this.labelVilleClub.AutoSize = true;
            this.labelVilleClub.Location = new System.Drawing.Point(3, 190);
            this.labelVilleClub.Name = "labelVilleClub";
            this.labelVilleClub.Size = new System.Drawing.Size(64, 13);
            this.labelVilleClub.TabIndex = 12;
            this.labelVilleClub.Text = "Ville du club";
            // 
            // labelTelephoneClub
            // 
            this.labelTelephoneClub.AutoSize = true;
            this.labelTelephoneClub.Location = new System.Drawing.Point(1, 213);
            this.labelTelephoneClub.Name = "labelTelephoneClub";
            this.labelTelephoneClub.Size = new System.Drawing.Size(96, 13);
            this.labelTelephoneClub.TabIndex = 13;
            this.labelTelephoneClub.Text = "Téléphone du club";
            // 
            // labelEmailClub
            // 
            this.labelEmailClub.AutoSize = true;
            this.labelEmailClub.Location = new System.Drawing.Point(5, 239);
            this.labelEmailClub.Name = "labelEmailClub";
            this.labelEmailClub.Size = new System.Drawing.Size(70, 13);
            this.labelEmailClub.TabIndex = 14;
            this.labelEmailClub.Text = "Email du club";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type de club";
            // 
            // listBoxtype
            // 
            this.listBoxtype.BackColor = System.Drawing.Color.LightGray;
            this.listBoxtype.FormattingEnabled = true;
            this.listBoxtype.Location = new System.Drawing.Point(103, 264);
            this.listBoxtype.Name = "listBoxtype";
            this.listBoxtype.Size = new System.Drawing.Size(160, 56);
            this.listBoxtype.TabIndex = 16;
            // 
            // textBoxDepartementClub
            // 
            this.textBoxDepartementClub.BackColor = System.Drawing.Color.LightGray;
            this.textBoxDepartementClub.Location = new System.Drawing.Point(174, 152);
            this.textBoxDepartementClub.Mask = "00000";
            this.textBoxDepartementClub.Name = "textBoxDepartementClub";
            this.textBoxDepartementClub.Size = new System.Drawing.Size(40, 20);
            this.textBoxDepartementClub.TabIndex = 17;
            // 
            // textboxTel
            // 
            this.textboxTel.BackColor = System.Drawing.Color.LightGray;
            this.textboxTel.Location = new System.Drawing.Point(103, 210);
            this.textboxTel.Mask = "00 00 00 00 00";
            this.textboxTel.Name = "textboxTel";
            this.textboxTel.Size = new System.Drawing.Size(111, 20);
            this.textboxTel.TabIndex = 18;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnuler.Location = new System.Drawing.Point(6, 327);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // AjouterClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 373);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.textboxTel);
            this.Controls.Add(this.textBoxDepartementClub);
            this.Controls.Add(this.listBoxtype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmailClub);
            this.Controls.Add(this.labelTelephoneClub);
            this.Controls.Add(this.labelVilleClub);
            this.Controls.Add(this.labelDepartementClub);
            this.Controls.Add(this.labelAdresseClub);
            this.Controls.Add(this.labelLienClub);
            this.Controls.Add(this.labelNomClub);
            this.Controls.Add(this.textBoxEmailClub);
            this.Controls.Add(this.textBoxVilleClub);
            this.Controls.Add(this.textBoxAdresseClub);
            this.Controls.Add(this.textBoxLienClub);
            this.Controls.Add(this.textBoxNomClub);
            this.Controls.Add(this.buttonValiderAjoutClub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterClub";
            this.Text = "Ajouter un club";
            this.Load += new System.EventHandler(this.AjouterClub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValiderAjoutClub;
        private System.Windows.Forms.TextBox textBoxNomClub;
        private System.Windows.Forms.TextBox textBoxLienClub;
        private System.Windows.Forms.TextBox textBoxAdresseClub;
        private System.Windows.Forms.TextBox textBoxVilleClub;
        private System.Windows.Forms.TextBox textBoxEmailClub;
        private System.Windows.Forms.Label labelNomClub;
        private System.Windows.Forms.Label labelLienClub;
        private System.Windows.Forms.Label labelAdresseClub;
        private System.Windows.Forms.Label labelDepartementClub;
        private System.Windows.Forms.Label labelVilleClub;
        private System.Windows.Forms.Label labelTelephoneClub;
        private System.Windows.Forms.Label labelEmailClub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxtype;
        private System.Windows.Forms.MaskedTextBox textBoxDepartementClub;
        private System.Windows.Forms.MaskedTextBox textboxTel;
        private System.Windows.Forms.Button btnAnnuler;
    }
}