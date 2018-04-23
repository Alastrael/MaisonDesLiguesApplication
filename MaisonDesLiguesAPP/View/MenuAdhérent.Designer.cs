namespace MaisonDesLiguesAPP.View
{
    partial class MenuAdhérent
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
            this.metroTileCreer = new MetroFramework.Controls.MetroTile();
            this.metroTileModifier = new MetroFramework.Controls.MetroTile();
            this.metroTileAffecter = new MetroFramework.Controls.MetroTile();
            this.metroTileSupprimer = new MetroFramework.Controls.MetroTile();
            this.dataAdherent = new System.Windows.Forms.DataGridView();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdherent)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileCreer
            // 
            this.metroTileCreer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileCreer.Location = new System.Drawing.Point(23, 77);
            this.metroTileCreer.Name = "metroTileCreer";
            this.metroTileCreer.Size = new System.Drawing.Size(113, 89);
            this.metroTileCreer.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileCreer.TabIndex = 0;
            this.metroTileCreer.Text = "Créer";
            this.metroTileCreer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileCreer.Click += new System.EventHandler(this.metroTileCreer_Click);
            this.metroTileCreer.MouseEnter += new System.EventHandler(this.metroTileCreer_MouseEnter);
            this.metroTileCreer.MouseLeave += new System.EventHandler(this.metroTileCreer_MouseLeave);
            // 
            // metroTileModifier
            // 
            this.metroTileModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileModifier.Location = new System.Drawing.Point(183, 77);
            this.metroTileModifier.Name = "metroTileModifier";
            this.metroTileModifier.Size = new System.Drawing.Size(113, 89);
            this.metroTileModifier.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileModifier.TabIndex = 1;
            this.metroTileModifier.Text = "Modifier";
            this.metroTileModifier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileModifier.Click += new System.EventHandler(this.metroTileModifier_Click);
            // 
            // metroTileAffecter
            // 
            this.metroTileAffecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileAffecter.Location = new System.Drawing.Point(349, 77);
            this.metroTileAffecter.Name = "metroTileAffecter";
            this.metroTileAffecter.Size = new System.Drawing.Size(113, 89);
            this.metroTileAffecter.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileAffecter.TabIndex = 2;
            this.metroTileAffecter.Text = "Affecter";
            this.metroTileAffecter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAffecter.Click += new System.EventHandler(this.metroTileAffecter_Click);
            this.metroTileAffecter.MouseEnter += new System.EventHandler(this.metroTileAffecter_MouseEnter);
            this.metroTileAffecter.MouseLeave += new System.EventHandler(this.metroTileAffecter_MouseLeave);
            // 
            // metroTileSupprimer
            // 
            this.metroTileSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileSupprimer.Location = new System.Drawing.Point(509, 77);
            this.metroTileSupprimer.Name = "metroTileSupprimer";
            this.metroTileSupprimer.Size = new System.Drawing.Size(113, 89);
            this.metroTileSupprimer.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileSupprimer.TabIndex = 3;
            this.metroTileSupprimer.Text = "Supprimer";
            this.metroTileSupprimer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileSupprimer.Click += new System.EventHandler(this.metroTileSupprimer_Click);
            this.metroTileSupprimer.MouseEnter += new System.EventHandler(this.metroTileSupprimer_MouseEnter);
            this.metroTileSupprimer.MouseLeave += new System.EventHandler(this.metroTileSupprimer_MouseLeave);
            // 
            // dataAdherent
            // 
            this.dataAdherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdherent.Location = new System.Drawing.Point(23, 183);
            this.dataAdherent.Name = "dataAdherent";
            this.dataAdherent.RowHeadersVisible = false;
            this.dataAdherent.Size = new System.Drawing.Size(599, 205);
            this.dataAdherent.TabIndex = 4;
            // 
            // metroTile1
            // 
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(374, 394);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(248, 31);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Afficher les informations d\'un salarié";
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // MenuAdhérent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 444);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.dataAdherent);
            this.Controls.Add(this.metroTileSupprimer);
            this.Controls.Add(this.metroTileAffecter);
            this.Controls.Add(this.metroTileModifier);
            this.Controls.Add(this.metroTileCreer);
            this.Name = "MenuAdhérent";
            this.Text = "Menu de gestion des adhérents";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MenuAdhérent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAdherent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileCreer;
        private MetroFramework.Controls.MetroTile metroTileModifier;
        private MetroFramework.Controls.MetroTile metroTileAffecter;
        private MetroFramework.Controls.MetroTile metroTileSupprimer;
        private System.Windows.Forms.DataGridView dataAdherent;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}