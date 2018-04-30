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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListerToolTipMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClub = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesAdhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesÉvènementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTileClub = new MetroFramework.Controls.MetroTile();
            this.metroTileAdh = new MetroFramework.Controls.MetroTile();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adhérentsToolStripMenuItem,
            this.clubMenu});
            this.menuStrip1.Location = new System.Drawing.Point(326, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 40, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(124, 357);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adhérentsToolStripMenuItem
            // 
            this.adhérentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.ListerToolTipMenuStrip,
            this.supprimerToolStripMenuItem,
            this.affecterToolStripMenuItem});
            this.adhérentsToolStripMenuItem.Name = "adhérentsToolStripMenuItem";
            this.adhérentsToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.adhérentsToolStripMenuItem.Text = "Adhérents";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(455, 28);
            this.ajouterToolStripMenuItem.Text = "Créer un nouvel adhérent";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // ListerToolTipMenuStrip
            // 
            this.ListerToolTipMenuStrip.Name = "ListerToolTipMenuStrip";
            this.ListerToolTipMenuStrip.Size = new System.Drawing.Size(455, 28);
            this.ListerToolTipMenuStrip.Text = "Afficher les informations d\'un adhérent";
            this.ListerToolTipMenuStrip.Click += new System.EventHandler(this.ListerToolTipMenuStrip_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(455, 28);
            this.supprimerToolStripMenuItem.Text = "Supprimer un adhérent";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // affecterToolStripMenuItem
            // 
            this.affecterToolStripMenuItem.Name = "affecterToolStripMenuItem";
            this.affecterToolStripMenuItem.Size = new System.Drawing.Size(455, 28);
            this.affecterToolStripMenuItem.Text = "Affecter un adhérent à un club";
            this.affecterToolStripMenuItem.Click += new System.EventHandler(this.affecterToolStripMenuItem_Click);
            // 
            // clubMenu
            // 
            this.clubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClub,
            this.gérerLesAdhérentsToolStripMenuItem,
            this.gérerLesÉvènementsToolStripMenuItem});
            this.clubMenu.Name = "clubMenu";
            this.clubMenu.Size = new System.Drawing.Size(111, 27);
            this.clubMenu.Text = "Clubs";
            // 
            // ajouterClub
            // 
            this.ajouterClub.Name = "ajouterClub";
            this.ajouterClub.Size = new System.Drawing.Size(383, 28);
            this.ajouterClub.Text = "Créer un nouveau club";
            this.ajouterClub.Click += new System.EventHandler(this.ajouterClub_Click);
            // 
            // gérerLesAdhérentsToolStripMenuItem
            // 
            this.gérerLesAdhérentsToolStripMenuItem.Name = "gérerLesAdhérentsToolStripMenuItem";
            this.gérerLesAdhérentsToolStripMenuItem.Size = new System.Drawing.Size(383, 28);
            this.gérerLesAdhérentsToolStripMenuItem.Text = "Gérer les adhérents d\'un club";
            this.gérerLesAdhérentsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesAdhérentsToolStripMenuItem_Click);
            // 
            // gérerLesÉvènementsToolStripMenuItem
            // 
            this.gérerLesÉvènementsToolStripMenuItem.Name = "gérerLesÉvènementsToolStripMenuItem";
            this.gérerLesÉvènementsToolStripMenuItem.Size = new System.Drawing.Size(383, 28);
            this.gérerLesÉvènementsToolStripMenuItem.Text = "Gérer les évènements d\'un club";
            this.gérerLesÉvènementsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesÉvènementsToolStripMenuItem_Click);
            // 
            // metroTileClub
            // 
            this.metroTileClub.BackColor = System.Drawing.Color.Black;
            this.metroTileClub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileClub.Location = new System.Drawing.Point(205, 63);
            this.metroTileClub.Name = "metroTileClub";
            this.metroTileClub.Size = new System.Drawing.Size(68, 67);
            this.metroTileClub.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileClub.TabIndex = 5;
            this.metroTileClub.Text = "Clubs";
            this.metroTileClub.TileImage = global::MaisonDesLiguesAPP.Properties.Resources.group;
            this.metroTileClub.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClub.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileClub.UseTileImage = true;
            // 
            // metroTileAdh
            // 
            this.metroTileAdh.BackColor = System.Drawing.Color.Black;
            this.metroTileAdh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileAdh.Location = new System.Drawing.Point(23, 60);
            this.metroTileAdh.Name = "metroTileAdh";
            this.metroTileAdh.Size = new System.Drawing.Size(78, 70);
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
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 437);
            this.Controls.Add(this.metroTileClub);
            this.Controls.Add(this.metroTileAdh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PagePrincipale";
            this.Text = "Maison des Ligues";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.PagePrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListerToolTipMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubMenu;
        private System.Windows.Forms.ToolStripMenuItem ajouterClub;
        private System.Windows.Forms.ToolStripMenuItem affecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesAdhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesÉvènementsToolStripMenuItem;
        private MetroFramework.Controls.MetroTile metroTileAdh;
        private MetroFramework.Controls.MetroTile metroTileClub;
    }
}

