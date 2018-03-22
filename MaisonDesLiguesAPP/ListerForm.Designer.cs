namespace MaisonDesLiguesAPP
{
    partial class ListerForm
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
            this.dataGridLister = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLister)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLister
            // 
            this.dataGridLister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLister.Location = new System.Drawing.Point(12, 12);
            this.dataGridLister.Name = "dataGridLister";
            this.dataGridLister.Size = new System.Drawing.Size(349, 217);
            this.dataGridLister.TabIndex = 0;
            // 
            // ListerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 241);
            this.Controls.Add(this.dataGridLister);
            this.Name = "ListerForm";
            this.Text = "ListerForm";
            this.Load += new System.EventHandler(this.ListerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLister;
    }
}