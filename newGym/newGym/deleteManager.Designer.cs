namespace newGym
{
    partial class deleteManager
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
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteManageById = new GButton();
            this.SuspendLayout();
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(117, 66);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(121, 21);
            this.deleteComboBox.TabIndex = 41;
            this.deleteComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "choose manager:";
            // 
            // deleteManageById
            // 
            this.deleteManageById.Location = new System.Drawing.Point(71, 118);
            this.deleteManageById.Name = "deleteManageById";
            this.deleteManageById.Size = new System.Drawing.Size(116, 23);
            this.deleteManageById.TabIndex = 39;
            this.deleteManageById.Text = "מחיקה";
            this.deleteManageById.UseVisualStyleBackColor = true;
            this.deleteManageById.Click += new System.EventHandler(this.deleteManageById_Click);
            // 
            // deleteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.deleteComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deleteManageById);
            this.Name = "deleteManager";
            this.Text = "deleteManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteManageById;
    }
}