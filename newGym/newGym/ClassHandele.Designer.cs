namespace newGym
{
    partial class ClassHandele
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
            this.button22 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button22.Location = new System.Drawing.Point(34, 103);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(158, 26);
            this.button22.TabIndex = 1;
            this.button22.Text = "Edit Class";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(34, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Class";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(34, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete Class";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClassHandele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 224);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button22);
            this.Name = "ClassHandele";
            this.Text = "Class Handele";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}