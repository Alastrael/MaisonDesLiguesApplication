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
            ((System.ComponentModel.ISupportInitialize)(this.dataClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // metroCreer
            // 
            this.metroCreer.Location = new System.Drawing.Point(23, 87);
            this.metroCreer.Name = "metroCreer";
            this.metroCreer.Size = new System.Drawing.Size(105, 55);
            this.metroCreer.Style = MetroFramework.MetroColorStyle.Green;
            this.metroCreer.TabIndex = 0;
            this.metroCreer.Text = "Créer un club";
            this.metroCreer.Click += new System.EventHandler(this.metroCreer_Click);
            // 
            // metroMod
            // 
            this.metroMod.Location = new System.Drawing.Point(281, 87);
            this.metroMod.Name = "metroMod";
            this.metroMod.Size = new System.Drawing.Size(126, 55);
            this.metroMod.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroMod.TabIndex = 1;
            this.metroMod.Text = "Modifier un club";
            // 
            // metroDesaffecter
            // 
            this.metroDesaffecter.Location = new System.Drawing.Point(567, 87);
            this.metroDesaffecter.Name = "metroDesaffecter";
            this.metroDesaffecter.Size = new System.Drawing.Size(156, 55);
            this.metroDesaffecter.Style = MetroFramework.MetroColorStyle.Red;
            this.metroDesaffecter.TabIndex = 2;
            this.metroDesaffecter.Text = "Désaffecter un adhérent";
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
            this.metroMenuEvents.Location = new System.Drawing.Point(567, 368);
            this.metroMenuEvents.Name = "metroMenuEvents";
            this.metroMenuEvents.Size = new System.Drawing.Size(156, 38);
            this.metroMenuEvents.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroMenuEvents.TabIndex = 4;
            this.metroMenuEvents.Text = "Menu des évènements";
            // 
            // MenuClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 418);
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
    }
}