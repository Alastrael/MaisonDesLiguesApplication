namespace MaisonDesLiguesAPP.View
{
    partial class Statistiques
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnChoisir = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cotisationElevee = new MaterialSkin.Controls.MaterialLabel();
            this.totalCotisations = new MaterialSkin.Controls.MaterialLabel();
            this.nbrAdh = new MaterialSkin.Controls.MaterialLabel();
            this.retour = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(182, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 108);
            this.listBox1.TabIndex = 0;
            // 
            // btnChoisir
            // 
            this.btnChoisir.AutoSize = true;
            this.btnChoisir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChoisir.Depth = 0;
            this.btnChoisir.Icon = null;
            this.btnChoisir.Location = new System.Drawing.Point(206, 190);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChoisir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Primary = false;
            this.btnChoisir.Size = new System.Drawing.Size(130, 36);
            this.btnChoisir.TabIndex = 7;
            this.btnChoisir.Text = "Choisir le club";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 256);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(317, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "La personne avec la cotisation la plus élevée :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 289);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(246, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Total des cotisations pour ce club :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 321);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(236, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Nombre d\'adhérents dans le club :";
            // 
            // cotisationElevee
            // 
            this.cotisationElevee.AutoSize = true;
            this.cotisationElevee.Depth = 0;
            this.cotisationElevee.Font = new System.Drawing.Font("Roboto", 11F);
            this.cotisationElevee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cotisationElevee.Location = new System.Drawing.Point(352, 256);
            this.cotisationElevee.MouseState = MaterialSkin.MouseState.HOVER;
            this.cotisationElevee.Name = "cotisationElevee";
            this.cotisationElevee.Size = new System.Drawing.Size(0, 19);
            this.cotisationElevee.TabIndex = 11;
            // 
            // totalCotisations
            // 
            this.totalCotisations.AutoSize = true;
            this.totalCotisations.Depth = 0;
            this.totalCotisations.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalCotisations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalCotisations.Location = new System.Drawing.Point(264, 289);
            this.totalCotisations.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalCotisations.Name = "totalCotisations";
            this.totalCotisations.Size = new System.Drawing.Size(0, 19);
            this.totalCotisations.TabIndex = 12;
            // 
            // nbrAdh
            // 
            this.nbrAdh.AutoSize = true;
            this.nbrAdh.Depth = 0;
            this.nbrAdh.Font = new System.Drawing.Font("Roboto", 11F);
            this.nbrAdh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nbrAdh.Location = new System.Drawing.Point(254, 321);
            this.nbrAdh.MouseState = MaterialSkin.MouseState.HOVER;
            this.nbrAdh.Name = "nbrAdh";
            this.nbrAdh.Size = new System.Drawing.Size(0, 19);
            this.nbrAdh.TabIndex = 13;
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(16, 389);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(63, 28);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 14;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 429);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.nbrAdh);
            this.Controls.Add(this.totalCotisations);
            this.Controls.Add(this.cotisationElevee);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.listBox1);
            this.Name = "Statistiques";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Statistiques_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnChoisir;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel cotisationElevee;
        private MaterialSkin.Controls.MaterialLabel totalCotisations;
        private MaterialSkin.Controls.MaterialLabel nbrAdh;
        private MetroFramework.Controls.MetroTile retour;
    }
}