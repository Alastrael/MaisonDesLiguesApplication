namespace MaisonDesLiguesAPP
{
    partial class AjouterAdherents
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
            this.labelNOM = new System.Windows.Forms.Label();
            this.labelPRENOM = new System.Windows.Forms.Label();
            this.textBoxNOM = new System.Windows.Forms.TextBox();
            this.textBoxPRENOM = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelNOM
            // 
            this.labelNOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNOM.AutoSize = true;
            this.labelNOM.Location = new System.Drawing.Point(12, 31);
            this.labelNOM.Name = "labelNOM";
            this.labelNOM.Size = new System.Drawing.Size(32, 13);
            this.labelNOM.TabIndex = 0;
            this.labelNOM.Text = "NOM";
            // 
            // labelPRENOM
            // 
            this.labelPRENOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPRENOM.AutoSize = true;
            this.labelPRENOM.Location = new System.Drawing.Point(12, 63);
            this.labelPRENOM.Name = "labelPRENOM";
            this.labelPRENOM.Size = new System.Drawing.Size(54, 13);
            this.labelPRENOM.TabIndex = 1;
            this.labelPRENOM.Text = "PRENOM";
            // 
            // textBoxNOM
            // 
            this.textBoxNOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNOM.Location = new System.Drawing.Point(73, 28);
            this.textBoxNOM.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxNOM.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxNOM.Name = "textBoxNOM";
            this.textBoxNOM.Size = new System.Drawing.Size(81, 20);
            this.textBoxNOM.TabIndex = 2;
            // 
            // textBoxPRENOM
            // 
            this.textBoxPRENOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPRENOM.Location = new System.Drawing.Point(73, 60);
            this.textBoxPRENOM.MaximumSize = new System.Drawing.Size(200, 20);
            this.textBoxPRENOM.MinimumSize = new System.Drawing.Size(40, 20);
            this.textBoxPRENOM.Name = "textBoxPRENOM";
            this.textBoxPRENOM.Size = new System.Drawing.Size(81, 20);
            this.textBoxPRENOM.TabIndex = 3;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouter.Location = new System.Drawing.Point(315, 232);
            this.buttonAjouter.MaximumSize = new System.Drawing.Size(80, 30);
            this.buttonAjouter.MinimumSize = new System.Drawing.Size(40, 30);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(80, 30);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Valider";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // AjouterAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 274);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxPRENOM);
            this.Controls.Add(this.textBoxNOM);
            this.Controls.Add(this.labelPRENOM);
            this.Controls.Add(this.labelNOM);
            this.Name = "AjouterAdherents";
            this.Text = "ajouterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNOM;
        private System.Windows.Forms.Label labelPRENOM;
        private System.Windows.Forms.TextBox textBoxNOM;
        private System.Windows.Forms.TextBox textBoxPRENOM;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}