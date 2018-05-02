﻿namespace MaisonDesLiguesAPP.View
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
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.btnValider = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModifier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCreer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listBoxClubs
            // 
            this.listBoxClubs.FormattingEnabled = true;
            this.listBoxClubs.Location = new System.Drawing.Point(98, 132);
            this.listBoxClubs.Name = "listBoxClubs";
            this.listBoxClubs.Size = new System.Drawing.Size(200, 108);
            this.listBoxClubs.TabIndex = 1;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Enabled = false;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(98, 310);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(200, 108);
            this.listBoxEvents.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValider.Depth = 0;
            this.btnValider.Icon = null;
            this.btnValider.Location = new System.Drawing.Point(162, 257);
            this.btnValider.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValider.Name = "btnValider";
            this.btnValider.Primary = true;
            this.btnValider.Size = new System.Drawing.Size(74, 36);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Choisir";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.AutoSize = true;
            this.btnModifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifier.Depth = 0;
            this.btnModifier.Enabled = false;
            this.btnModifier.Icon = null;
            this.btnModifier.Location = new System.Drawing.Point(12, 424);
            this.btnModifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Primary = true;
            this.btnModifier.Size = new System.Drawing.Size(176, 36);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier l\'évènement";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Depth = 0;
            this.button2.Enabled = false;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(203, 424);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Primary = true;
            this.button2.Size = new System.Drawing.Size(190, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Supprimer l\'évènement";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.Enabled = false;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(57, 466);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(288, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Affecter un adhérent à l\'évènement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCreer
            // 
            this.btnCreer.AutoSize = true;
            this.btnCreer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreer.Depth = 0;
            this.btnCreer.Icon = null;
            this.btnCreer.Location = new System.Drawing.Point(115, 81);
            this.btnCreer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Primary = true;
            this.btnCreer.Size = new System.Drawing.Size(168, 36);
            this.btnCreer.TabIndex = 12;
            this.btnCreer.Text = "Créer un évènement";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // GérerEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 514);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxClubs);
            this.Name = "GérerEvents";
            this.Text = "Gérer les Evènements";
            this.Load += new System.EventHandler(this.GérerEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClubs;
        private System.Windows.Forms.ListBox listBoxEvents;
        private MaterialSkin.Controls.MaterialRaisedButton btnValider;
        private MaterialSkin.Controls.MaterialRaisedButton btnModifier;
        private MaterialSkin.Controls.MaterialRaisedButton button2;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreer;
    }
}