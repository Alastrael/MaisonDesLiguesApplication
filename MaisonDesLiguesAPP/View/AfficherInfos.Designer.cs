namespace MaisonDesLiguesAPP.View
{
    partial class AfficherInfos
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
            this.listBoxAdh = new System.Windows.Forms.ListBox();
            this.btnChoisir = new MaterialSkin.Controls.MaterialFlatButton();
            this.retour = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // listBoxAdh
            // 
            this.listBoxAdh.FormattingEnabled = true;
            this.listBoxAdh.Location = new System.Drawing.Point(35, 115);
            this.listBoxAdh.Name = "listBoxAdh";
            this.listBoxAdh.Size = new System.Drawing.Size(327, 108);
            this.listBoxAdh.TabIndex = 1;
            // 
            // btnChoisir
            // 
            this.btnChoisir.AutoSize = true;
            this.btnChoisir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChoisir.Depth = 0;
            this.btnChoisir.Icon = null;
            this.btnChoisir.Location = new System.Drawing.Point(144, 232);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChoisir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Primary = false;
            this.btnChoisir.Size = new System.Drawing.Size(121, 36);
            this.btnChoisir.TabIndex = 7;
            this.btnChoisir.Text = "Voir les infos";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // retour
            // 
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.retour.Location = new System.Drawing.Point(12, 81);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(63, 28);
            this.retour.Style = MetroFramework.MetroColorStyle.Silver;
            this.retour.TabIndex = 11;
            this.retour.Text = "Retour";
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // AfficherInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 283);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.listBoxAdh);
            this.Name = "AfficherInfos";
            this.Text = "Afficher les infos";
            this.Load += new System.EventHandler(this.AfficherInfos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAdh;
        private MaterialSkin.Controls.MaterialFlatButton btnChoisir;
        private MetroFramework.Controls.MetroTile retour;
    }
}