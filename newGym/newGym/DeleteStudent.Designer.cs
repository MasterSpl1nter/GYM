namespace newGym
{
    partial class DeleteStudent
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
            this.delete_comb = new System.Windows.Forms.ComboBox();
            this.choose_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_comb
            // 
            this.delete_comb.FormattingEnabled = true;
            this.delete_comb.Location = new System.Drawing.Point(128, 45);
            this.delete_comb.Name = "delete_comb";
            this.delete_comb.Size = new System.Drawing.Size(154, 24);
            this.delete_comb.TabIndex = 0;
            this.delete_comb.SelectedIndexChanged += new System.EventHandler(this.delete_comb_SelectedIndexChanged);
            // 
            // choose_id
            // 
            this.choose_id.AutoSize = true;
            this.choose_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.choose_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.choose_id.Location = new System.Drawing.Point(26, 45);
            this.choose_id.Name = "choose_id";
            this.choose_id.Size = new System.Drawing.Size(96, 24);
            this.choose_id.TabIndex = 1;
            this.choose_id.Text = "Choose id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choose_id);
            this.Controls.Add(this.delete_comb);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delete_comb;
        private System.Windows.Forms.Label choose_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}