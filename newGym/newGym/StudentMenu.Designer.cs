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
            this.edit_d_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.userName_label = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.med_cart_date = new System.Windows.Forms.DateTimePicker();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.mail_label = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.medcart_lable = new System.Windows.Forms.Label();
            this.end_date_label = new System.Windows.Forms.Label();
            this.start_date_label = new System.Windows.Forms.Label();
            this.birth_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.firstName_label = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.lastname_box = new System.Windows.Forms.TextBox();
            this.firstname_box = new System.Windows.Forms.TextBox();
            this.edit_d_panel.SuspendLayout();
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
            this.add_course.Click += new System.EventHandler(this.add_course_Click);
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
            // edit_d_panel
            // 
            this.edit_d_panel.Controls.Add(this.button1);
            this.edit_d_panel.Location = new System.Drawing.Point(3, 3);
            this.edit_d_panel.Name = "edit_d_panel";
            this.edit_d_panel.Size = new System.Drawing.Size(332, 430);
            this.edit_d_panel.TabIndex = 6;
            this.edit_d_panel.Visible = false;
            this.edit_d_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.edit_d_panel_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(362, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 513);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_username);
            this.panel3.Controls.Add(this.userName_label);
            this.panel3.Controls.Add(this.edit_d_panel);
            this.panel3.Controls.Add(this.start_date);
            this.panel3.Controls.Add(this.med_cart_date);
            this.panel3.Controls.Add(this.end_date);
            this.panel3.Controls.Add(this.birth_date);
            this.panel3.Controls.Add(this.mail_label);
            this.panel3.Controls.Add(this.enter_button);
            this.panel3.Controls.Add(this.medcart_lable);
            this.panel3.Controls.Add(this.end_date_label);
            this.panel3.Controls.Add(this.start_date_label);
            this.panel3.Controls.Add(this.birth_label);
            this.panel3.Controls.Add(this.lastName_label);
            this.panel3.Controls.Add(this.firstName_label);
            this.panel3.Controls.Add(this.email_box);
            this.panel3.Controls.Add(this.lastname_box);
            this.panel3.Controls.Add(this.firstname_box);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(142, 185);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(178, 26);
            this.tb_username.TabIndex = 58;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.Location = new System.Drawing.Point(54, 185);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(85, 18);
            this.userName_label.TabIndex = 64;
            this.userName_label.Text = "User name:";
            // 
            // start_date
            // 
            this.start_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(142, 277);
            this.start_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(219, 26);
            this.start_date.TabIndex = 54;
            // 
            // med_cart_date
            // 
            this.med_cart_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Location = new System.Drawing.Point(144, 364);
            this.med_cart_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.med_cart_date.Name = "med_cart_date";
            this.med_cart_date.Size = new System.Drawing.Size(217, 26);
            this.med_cart_date.TabIndex = 56;
            // 
            // end_date
            // 
            this.end_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Location = new System.Drawing.Point(144, 318);
            this.end_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(217, 26);
            this.end_date.TabIndex = 55;
            // 
            // birth_date
            // 
            this.birth_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Location = new System.Drawing.Point(144, 237);
            this.birth_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(217, 26);
            this.birth_date.TabIndex = 52;
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_label.Location = new System.Drawing.Point(85, 143);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(46, 18);
            this.mail_label.TabIndex = 63;
            this.mail_label.Text = "Email:";
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.ForeColor = System.Drawing.Color.Navy;
            this.enter_button.Location = new System.Drawing.Point(166, 433);
            this.enter_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(154, 33);
            this.enter_button.TabIndex = 61;
            this.enter_button.Text = "edit";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // medcart_lable
            // 
            this.medcart_lable.AutoSize = true;
            this.medcart_lable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medcart_lable.Location = new System.Drawing.Point(-28, 370);
            this.medcart_lable.Name = "medcart_lable";
            this.medcart_lable.Size = new System.Drawing.Size(161, 18);
            this.medcart_lable.TabIndex = 62;
            this.medcart_lable.Text = "valid medical certificate:";
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_date_label.Location = new System.Drawing.Point(38, 324);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(95, 18);
            this.end_date_label.TabIndex = 60;
            this.end_date_label.Text = "End contract:";
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.Location = new System.Drawing.Point(29, 277);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(104, 18);
            this.start_date_label.TabIndex = 59;
            this.start_date_label.Text = "Start Contract:";
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(57, 237);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(76, 18);
            this.birth_label.TabIndex = 57;
            this.birth_label.Text = "Birth date:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_label.Location = new System.Drawing.Point(51, 96);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(82, 18);
            this.lastName_label.TabIndex = 53;
            this.lastName_label.Text = "Last name:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_label.Location = new System.Drawing.Point(49, 60);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(84, 18);
            this.firstName_label.TabIndex = 50;
            this.firstName_label.Text = "First Name:";
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(144, 140);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_box.Multiline = true;
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(176, 28);
            this.email_box.TabIndex = 51;
            // 
            // lastname_box
            // 
            this.lastname_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_box.Location = new System.Drawing.Point(144, 86);
            this.lastname_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname_box.Multiline = true;
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(176, 28);
            this.lastname_box.TabIndex = 49;
            // 
            // firstname_box
            // 
            this.firstname_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_box.Location = new System.Drawing.Point(144, 51);
            this.firstname_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname_box.Multiline = true;
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(176, 27);
            this.firstname_box.TabIndex = 48;
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Cancel_course);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_course);
            this.Controls.Add(this.edit_button);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.edit_d_panel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel edit_d_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.DateTimePicker med_cart_date;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label medcart_lable;
        private System.Windows.Forms.Label end_date_label;
        private System.Windows.Forms.Label start_date_label;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox lastname_box;
        private System.Windows.Forms.TextBox firstname_box;
    }
}