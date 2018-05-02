namespace MaisonDesLiguesAPP.View
{
    partial class DessafecterAdh
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
            this.listBoxClub = new System.Windows.Forms.ListBox();
            this.btnClub = new MaterialSkin.Controls.MaterialFlatButton();
            this.listBoxAdh = new System.Windows.Forms.ListBox();
            this.btnAdh = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // listBoxClub
            // 
            this.listBoxClub.FormattingEnabled = true;
            this.listBoxClub.Location = new System.Drawing.Point(78, 71);
            this.listBoxClub.Name = "listBoxClub";
            this.listBoxClub.Size = new System.Drawing.Size(214, 160);
            this.listBoxClub.TabIndex = 14;
            // 
            // btnClub
            // 
            this.btnClub.AutoSize = true;
            this.btnClub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClub.Depth = 0;
            this.btnClub.Icon = null;
            this.btnClub.Location = new System.Drawing.Point(119, 240);
            this.btnClub.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClub.Name = "btnClub";
            this.btnClub.Primary = false;
            this.btnClub.Size = new System.Drawing.Size(130, 36);
            this.btnClub.TabIndex = 15;
            this.btnClub.Text = "Choisir le club";
            this.btnClub.UseVisualStyleBackColor = true;
            this.btnClub.Click += new System.EventHandler(this.btnClub_Click);
            // 
            // listBoxAdh
            // 
            this.listBoxAdh.Enabled = false;
            this.listBoxAdh.FormattingEnabled = true;
            this.listBoxAdh.Location = new System.Drawing.Point(78, 285);
            this.listBoxAdh.Name = "listBoxAdh";
            this.listBoxAdh.Size = new System.Drawing.Size(214, 160);
            this.listBoxAdh.TabIndex = 16;
            this.listBoxAdh.SelectedIndexChanged += new System.EventHandler(this.listBoxAdh_SelectedIndexChanged);
            // 
            // btnAdh
            // 
            this.btnAdh.AutoSize = true;
            this.btnAdh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdh.Depth = 0;
            this.btnAdh.Enabled = false;
            this.btnAdh.Icon = null;
            this.btnAdh.Location = new System.Drawing.Point(78, 454);
            this.btnAdh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdh.Name = "btnAdh";
            this.btnAdh.Primary = false;
            this.btnAdh.Size = new System.Drawing.Size(214, 36);
            this.btnAdh.TabIndex = 17;
            this.btnAdh.Text = "Désaffecter cet adhérent";
            this.btnAdh.UseVisualStyleBackColor = true;
            this.btnAdh.Click += new System.EventHandler(this.btnAdh_Click);
            // 
            // DessafecterAdh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 523);
            this.Controls.Add(this.btnAdh);
            this.Controls.Add(this.listBoxAdh);
            this.Controls.Add(this.btnClub);
            this.Controls.Add(this.listBoxClub);
            this.Name = "DessafecterAdh";
            this.Text = "Désaffecter un adhérent";
            this.Load += new System.EventHandler(this.DessafecterAdh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClub;
        private MaterialSkin.Controls.MaterialFlatButton btnClub;
        private System.Windows.Forms.ListBox listBoxAdh;
        private MaterialSkin.Controls.MaterialFlatButton btnAdh;
    }
}