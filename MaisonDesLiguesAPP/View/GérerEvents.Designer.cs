namespace MaisonDesLiguesAPP.View
{
    partial class GérerEvents
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
            this.listBoxClubs = new System.Windows.Forms.ListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.créerUnNouvelÉvènementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClubs
            // 
            this.listBoxClubs.FormattingEnabled = true;
            this.listBoxClubs.Location = new System.Drawing.Point(12, 27);
            this.listBoxClubs.Name = "listBoxClubs";
            this.listBoxClubs.Size = new System.Drawing.Size(167, 108);
            this.listBoxClubs.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(185, 110);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(91, 25);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 139);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(167, 108);
            this.listBoxEvents.TabIndex = 3;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 253);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(167, 25);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier l\'évènement";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Supprimer l\'évènement";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnNouvelÉvènementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // créerUnNouvelÉvènementToolStripMenuItem
            // 
            this.créerUnNouvelÉvènementToolStripMenuItem.Name = "créerUnNouvelÉvènementToolStripMenuItem";
            this.créerUnNouvelÉvènementToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.créerUnNouvelÉvènementToolStripMenuItem.Text = "Créer un nouvel évènement";
            this.créerUnNouvelÉvènementToolStripMenuItem.Click += new System.EventHandler(this.créerUnNouvelÉvènementToolStripMenuItem_Click);
            // 
            // GérerEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 285);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listBoxClubs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GérerEvents";
            this.Text = "GérerEvents";
            this.Load += new System.EventHandler(this.GérerEvents_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClubs;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem créerUnNouvelÉvènementToolStripMenuItem;
    }
}