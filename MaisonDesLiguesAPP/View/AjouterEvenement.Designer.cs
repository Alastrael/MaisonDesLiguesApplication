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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterEvenement));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.maskTitre = new System.Windows.Forms.MaskedTextBox();
            this.listBoxclub = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCréer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.retour = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date de fin de l\'évènement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date du début de l\'évènement";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(303, 176);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(210, 20);
            this.dtpFin.TabIndex = 10;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(12, 176);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(209, 20);
            this.dtpDebut.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titre de l\'évènement";
            // 
            // maskTitre
            // 
            this.maskTitre.Location = new System.Drawing.Point(3, 121);
            this.maskTitre.Name = "maskTitre";
            this.maskTitre.Size = new System.Drawing.Size(493, 20);
            this.maskTitre.TabIndex = 7;
            // 
            // listBoxclub
            // 
            this.listBoxclub.FormattingEnabled = true;
            this.listBoxclub.Location = new System.Drawing.Point(157, 237);
            this.listBoxclub.Name = "listBoxclub";
            this.listBoxclub.Size = new System.Drawing.Size(189, 121);
            this.listBoxclub.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cet évènement appartient au club :";
            // 
            // btnCréer
            // 
            this.btnCréer.AutoSize = true;
            this.btnCréer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCréer.Depth = 0;
            this.btnCréer.Icon = null;
            this.btnCréer.Location = new System.Drawing.Point(225, 364);
            this.btnCréer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCréer.Name = "btnCréer";
            this.btnCréer.Primary = true;
            this.btnCréer.Size = new System.Drawing.Size(63, 36);
            this.btnCréer.TabIndex = 16;
            this.btnCréer.Text = "Créer";
            this.btnCréer.UseVisualStyleBackColor = true;
            this.btnCréer.Click += new System.EventHandler(this.btnCréer_Click);
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(3, 70);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(63, 28);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 17;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // AjouterEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 412);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.btnCréer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxclub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterEvenement";
            this.Text = "Ajouter un Evènement";
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
        private MaterialSkin.Controls.MaterialRaisedButton btnCréer;
        private MetroFramework.Controls.MetroTile retour;
    }
}