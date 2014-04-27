namespace newGym
{
    partial class FormRemoveTrainer
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.delete_butten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 1;
<<<<<<< HEAD
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            // 
            // delete_butten
            // 
            this.delete_butten.Location = new System.Drawing.Point(210, 209);
            this.delete_butten.Name = "delete_butten";
            this.delete_butten.Size = new System.Drawing.Size(100, 23);
            this.delete_butten.TabIndex = 2;
            this.delete_butten.Text = "Delete Trainer";
            this.delete_butten.UseVisualStyleBackColor = true;
            this.delete_butten.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(181, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chose Trainers Name to delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Delete Trainer";
            // 
            // FormRemoveTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 375);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_butten);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormRemoveTrainer";
            this.Text = "FormRemoveTrainer";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.FormRemoveTrainer_Load);
=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delete_butten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}