namespace MaisonDesLiguesAPP
{
    partial class PagePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagePrincipale));
            this.metroTileClub = new MetroFramework.Controls.MetroTile();
            this.metroTileAdh = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileClub
            // 
            this.metroTileClub.BackColor = System.Drawing.Color.Black;
            this.metroTileClub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileClub.Location = new System.Drawing.Point(334, 315);
            this.metroTileClub.Name = "metroTileClub";
            this.metroTileClub.Size = new System.Drawing.Size(82, 70);
            this.metroTileClub.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileClub.TabIndex = 5;
            this.metroTileClub.Text = "Clubs";
            this.metroTileClub.TileImage = global::MaisonDesLiguesAPP.Properties.Resources.group;
            this.metroTileClub.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClub.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClub.UseTileImage = true;
            this.metroTileClub.Click += new System.EventHandler(this.metroTileClub_Click);
            // 
            // metroTileAdh
            // 
            this.metroTileAdh.BackColor = System.Drawing.Color.Black;
            this.metroTileAdh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileAdh.Location = new System.Drawing.Point(60, 315);
            this.metroTileAdh.Name = "metroTileAdh";
            this.metroTileAdh.Size = new System.Drawing.Size(82, 70);
            this.metroTileAdh.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileAdh.TabIndex = 4;
            this.metroTileAdh.Text = "Adhérent";
            this.metroTileAdh.TileImage = global::MaisonDesLiguesAPP.Properties.Resources.l;
            this.metroTileAdh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAdh.UseTileImage = true;
            this.metroTileAdh.Click += new System.EventHandler(this.metroTileAdh_Click);
            this.metroTileAdh.MouseEnter += new System.EventHandler(this.metroTileAdh_MouseEnter);
            this.metroTileAdh.MouseLeave += new System.EventHandler(this.metroTileAdh_MouseLeave);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.Black;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(60, 75);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(356, 206);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseTileImage = true;
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 437);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTileClub);
            this.Controls.Add(this.metroTileAdh);
            this.Name = "PagePrincipale";
            this.Text = "Maison des Ligues";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.PagePrincipale_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTileAdh;
        private MetroFramework.Controls.MetroTile metroTileClub;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

