namespace MaisonDesLiguesAPP
{
    partial class MenuClub
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
            this.metroCreer = new MetroFramework.Controls.MetroTile();
            this.metroMod = new MetroFramework.Controls.MetroTile();
            this.metroDesaffecter = new MetroFramework.Controls.MetroTile();
            this.dataClubs = new System.Windows.Forms.DataGridView();
            this.metroMenuEvents = new MetroFramework.Controls.MetroTile();
            this.btnAffect = new MetroFramework.Controls.MetroTile();
            this.metroStats = new MetroFramework.Controls.MetroTile();
            this.retour = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // metroCreer
            // 
            this.metroCreer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroCreer.Location = new System.Drawing.Point(23, 87);
            this.metroCreer.Name = "metroCreer";
            this.metroCreer.Size = new System.Drawing.Size(105, 55);
            this.metroCreer.Style = MetroFramework.MetroColorStyle.Green;
            this.metroCreer.TabIndex = 0;
            this.metroCreer.Text = "Créer un club";
            this.metroCreer.Click += new System.EventHandler(this.metroCreer_Click);
            this.metroCreer.MouseEnter += new System.EventHandler(this.metroCreer_MouseEnter);
            // 
            // metroMod
            // 
            this.metroMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroMod.Location = new System.Drawing.Point(182, 87);
            this.metroMod.Name = "metroMod";
            this.metroMod.Size = new System.Drawing.Size(126, 55);
            this.metroMod.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroMod.TabIndex = 1;
            this.metroMod.Text = "Modifier un club";
            this.metroMod.Click += new System.EventHandler(this.metroMod_Click);
            // 
            // metroDesaffecter
            // 
            this.metroDesaffecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroDesaffecter.Location = new System.Drawing.Point(567, 87);
            this.metroDesaffecter.Name = "metroDesaffecter";
            this.metroDesaffecter.Size = new System.Drawing.Size(156, 55);
            this.metroDesaffecter.Style = MetroFramework.MetroColorStyle.Red;
            this.metroDesaffecter.TabIndex = 2;
            this.metroDesaffecter.Text = "Désaffecter un adhérent";
            this.metroDesaffecter.Click += new System.EventHandler(this.metroDesaffecter_Click);
            // 
            // dataClubs
            // 
            this.dataClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClubs.Location = new System.Drawing.Point(24, 162);
            this.dataClubs.Name = "dataClubs";
            this.dataClubs.RowHeadersVisible = false;
            this.dataClubs.Size = new System.Drawing.Size(699, 195);
            this.dataClubs.TabIndex = 3;
            // 
            // metroMenuEvents
            // 
            this.metroMenuEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroMenuEvents.Location = new System.Drawing.Point(567, 368);
            this.metroMenuEvents.Name = "metroMenuEvents";
            this.metroMenuEvents.Size = new System.Drawing.Size(156, 38);
            this.metroMenuEvents.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroMenuEvents.TabIndex = 4;
            this.metroMenuEvents.Text = "Gérer les évènements";
            this.metroMenuEvents.Click += new System.EventHandler(this.metroMenuEvents_Click);
            // 
            // btnAffect
            // 
            this.btnAffect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAffect.Location = new System.Drawing.Point(360, 87);
            this.btnAffect.Name = "btnAffect";
            this.btnAffect.Size = new System.Drawing.Size(143, 55);
            this.btnAffect.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnAffect.TabIndex = 5;
            this.btnAffect.Text = "Affecter un adhérent";
            this.btnAffect.Click += new System.EventHandler(this.btnAffect_Click);
            // 
            // metroStats
            // 
            this.metroStats.Location = new System.Drawing.Point(417, 368);
            this.metroStats.Name = "metroStats";
            this.metroStats.Size = new System.Drawing.Size(126, 38);
            this.metroStats.TabIndex = 6;
            this.metroStats.Text = "Statistiques";
            this.metroStats.Click += new System.EventHandler(this.metroStats_Click);
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(23, 368);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(81, 38);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 11;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // MenuClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 418);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.metroStats);
            this.Controls.Add(this.btnAffect);
            this.Controls.Add(this.metroMenuEvents);
            this.Controls.Add(this.dataClubs);
            this.Controls.Add(this.metroDesaffecter);
            this.Controls.Add(this.metroMod);
            this.Controls.Add(this.metroCreer);
            this.Name = "MenuClub";
            this.Text = "Menu des Clubs";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MenuClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroCreer;
        private MetroFramework.Controls.MetroTile metroMod;
        private MetroFramework.Controls.MetroTile metroDesaffecter;
        private System.Windows.Forms.DataGridView dataClubs;
        private MetroFramework.Controls.MetroTile metroMenuEvents;
        private MetroFramework.Controls.MetroTile btnAffect;
        private MetroFramework.Controls.MetroTile metroStats;
        private MetroFramework.Controls.MetroTile retour;
    }
}