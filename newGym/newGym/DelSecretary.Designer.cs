namespace newGym
{
    partial class DelSecretary
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
            this.enter_button = new System.Windows.Forms.Button();
            this.id_comboBox1 = new System.Windows.Forms.ComboBox();
            this.id_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enter_button.Location = new System.Drawing.Point(130, 100);
            this.enter_button.Margin = new System.Windows.Forms.Padding(4);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(79, 32);
            this.enter_button.TabIndex = 2;
            this.enter_button.Text = "Delete";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // id_comboBox1
            // 
            this.id_comboBox1.FormattingEnabled = true;
            this.id_comboBox1.Location = new System.Drawing.Point(147, 44);
            this.id_comboBox1.Name = "id_comboBox1";
            this.id_comboBox1.Size = new System.Drawing.Size(171, 21);
            this.id_comboBox1.TabIndex = 1;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.id_label.Location = new System.Drawing.Point(23, 46);
            this.id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(117, 19);
            this.id_label.TabIndex = 12;
            this.id_label.Text = "Choose Worker";
            // 
            // DelSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 176);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.id_comboBox1);
            this.Controls.Add(this.id_label);
            this.Name = "DelSecretary";
            this.Text = "DelSecretary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.ComboBox id_comboBox1;
        private System.Windows.Forms.Label id_label;
    }
}