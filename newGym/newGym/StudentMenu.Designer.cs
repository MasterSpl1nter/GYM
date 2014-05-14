namespace newGym
{
    partial class StudentMenu
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
            this.edit_button = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.add_course = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.Label();
            this.Cancel_course = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(24, 287);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(139, 44);
            this.edit_button.TabIndex = 0;
            this.edit_button.Text = "Edit details";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(24, 86);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // add_course
            // 
            this.add_course.Location = new System.Drawing.Point(24, 337);
            this.add_course.Name = "add_course";
            this.add_course.Size = new System.Drawing.Size(139, 44);
            this.add_course.TabIndex = 2;
            this.add_course.Text = "Add course";
            this.add_course.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Location = new System.Drawing.Point(87, 28);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(46, 17);
            this.student_name.TabIndex = 4;
            this.student_name.Text = "label2";
            // 
            // Cancel_course
            // 
            this.Cancel_course.Location = new System.Drawing.Point(24, 387);
            this.Cancel_course.Name = "Cancel_course";
            this.Cancel_course.Size = new System.Drawing.Size(139, 44);
            this.Cancel_course.TabIndex = 5;
            this.Cancel_course.Text = "Cancel course";
            this.Cancel_course.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(319, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 516);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 513);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 516);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 540);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel_course);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_course);
            this.Controls.Add(this.edit_button);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button add_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.Button Cancel_course;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}