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
            this.supprimerClub = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAdherents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataClubs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gérerLesAdhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesÉvènementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdherents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adhérentsToolStripMenuItem,
            this.clubMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
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
            this.adhérentsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.adhérentsToolStripMenuItem.Text = "Adhérents";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.ajouterToolStripMenuItem.Text = "Créer un nouvel adhérent";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // ListerToolTipMenuStrip
            // 
            this.ListerToolTipMenuStrip.Name = "ListerToolTipMenuStrip";
            this.ListerToolTipMenuStrip.Size = new System.Drawing.Size(281, 22);
            this.ListerToolTipMenuStrip.Text = "Afficher les informations d\'un adhérent";
            this.ListerToolTipMenuStrip.Click += new System.EventHandler(this.ListerToolTipMenuStrip_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer un adhérent";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // affecterToolStripMenuItem
            // 
            this.affecterToolStripMenuItem.Name = "affecterToolStripMenuItem";
            this.affecterToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.affecterToolStripMenuItem.Text = "Affecter un adhérent à un club";
            this.affecterToolStripMenuItem.Click += new System.EventHandler(this.affecterToolStripMenuItem_Click);
            // 
            // clubMenu
            // 
            this.clubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClub,
            this.supprimerClub,
            this.gérerLesAdhérentsToolStripMenuItem,
            this.gérerLesÉvènementsToolStripMenuItem});
            this.clubMenu.Name = "clubMenu";
            this.clubMenu.Size = new System.Drawing.Size(49, 20);
            this.clubMenu.Text = "Clubs";
            // 
            // ajouterClub
            // 
            this.ajouterClub.Name = "ajouterClub";
            this.ajouterClub.Size = new System.Drawing.Size(239, 22);
            this.ajouterClub.Text = "Créer un nouveau club";
            this.ajouterClub.Click += new System.EventHandler(this.ajouterClub_Click);
            // 
            // supprimerClub
            // 
            this.supprimerClub.Name = "supprimerClub";
            this.supprimerClub.Size = new System.Drawing.Size(239, 22);
            this.supprimerClub.Text = "Supprimer un club";
            this.supprimerClub.Click += new System.EventHandler(this.supprimerClub_Click);
            // 
            // dataAdherents
            // 
            this.dataAdherents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdherents.Location = new System.Drawing.Point(12, 61);
            this.dataAdherents.Name = "dataAdherents";
            this.dataAdherents.Size = new System.Drawing.Size(397, 150);
            this.dataAdherents.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tous les adhérents";
            // 
            // dataClubs
            // 
            this.dataClubs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClubs.Location = new System.Drawing.Point(12, 248);
            this.dataClubs.Name = "dataClubs";
            this.dataClubs.Size = new System.Drawing.Size(397, 150);
            this.dataClubs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tous les clubs";
            // 
            // gérerLesAdhérentsToolStripMenuItem
            // 
            this.gérerLesAdhérentsToolStripMenuItem.Name = "gérerLesAdhérentsToolStripMenuItem";
            this.gérerLesAdhérentsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.gérerLesAdhérentsToolStripMenuItem.Text = "Gérer les adhérents d\'un club";
            // 
            // gérerLesÉvènementsToolStripMenuItem
            // 
            this.gérerLesÉvènementsToolStripMenuItem.Name = "gérerLesÉvènementsToolStripMenuItem";
            this.gérerLesÉvènementsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.gérerLesÉvènementsToolStripMenuItem.Text = "Gérer les évènements d\'un club";
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataClubs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataAdherents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PagePrincipale";
            this.Text = "Maison des Ligues";
            this.Load += new System.EventHandler(this.PagePrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdherents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClubs)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem supprimerClub;
        private System.Windows.Forms.DataGridView dataAdherents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataClubs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem affecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesAdhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesÉvènementsToolStripMenuItem;
    }
}

