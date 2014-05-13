namespace newGym
{
    partial class GuideSearch
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
            this.searchResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // searchResult
            // 
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AllowUserToDeleteRows = false;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.Enabled = false;
            this.searchResult.Location = new System.Drawing.Point(12, 12);
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.Size = new System.Drawing.Size(578, 231);
            this.searchResult.TabIndex = 0;
            // 
            // GuideSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 255);
            this.Controls.Add(this.searchResult);
            this.Name = "GuideSearch";
            this.Text = "GuideSearch";
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchResult;
    }
}