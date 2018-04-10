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
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListerToolTipMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClub = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerClub = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.adhérentsToolStripMenuItem,
            this.clubMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // adhérentsToolStripMenuItem
            // 
            this.adhérentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.ListerToolTipMenuStrip,
            this.supprimerToolStripMenuItem});
            this.adhérentsToolStripMenuItem.Name = "adhérentsToolStripMenuItem";
            this.adhérentsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.adhérentsToolStripMenuItem.Text = "Adhérents";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // ListerToolTipMenuStrip
            // 
            this.ListerToolTipMenuStrip.Name = "ListerToolTipMenuStrip";
            this.ListerToolTipMenuStrip.Size = new System.Drawing.Size(129, 22);
            this.ListerToolTipMenuStrip.Text = "Lister";
            this.ListerToolTipMenuStrip.Click += new System.EventHandler(this.ListerToolTipMenuStrip_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // clubMenu
            // 
            this.clubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClub,
            this.supprimerClub});
            this.clubMenu.Name = "clubMenu";
            this.clubMenu.Size = new System.Drawing.Size(44, 20);
            this.clubMenu.Text = "Club";
            // 
            // ajouterClub
            // 
            this.ajouterClub.Name = "ajouterClub";
            this.ajouterClub.Size = new System.Drawing.Size(129, 22);
            this.ajouterClub.Text = "Ajouter";
            this.ajouterClub.Click += new System.EventHandler(this.ajouterClub_Click);
            // 
            // supprimerClub
            // 
            this.supprimerClub.Name = "supprimerClub";
            this.supprimerClub.Size = new System.Drawing.Size(129, 22);
            this.supprimerClub.Text = "Supprimer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 272);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PagePrincipale";
            this.Text = "Maison des Ligues";
            this.Load += new System.EventHandler(this.PagePrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListerToolTipMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubMenu;
        private System.Windows.Forms.ToolStripMenuItem ajouterClub;
        private System.Windows.Forms.ToolStripMenuItem supprimerClub;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

