﻿namespace newGym
{
    partial class AddStudent
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
            this.id_box = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.firstName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.birth_label = new System.Windows.Forms.Label();
            this.start_date_label = new System.Windows.Forms.Label();
            this.end_date_label = new System.Windows.Forms.Label();
            this.medcart_lable = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.mail_label = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.med_cart_date = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.firstname_box = new System.Windows.Forms.TextBox();
            this.lastname_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.tb_repeatPass = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.verPassWorod_label = new System.Windows.Forms.Label();
            this.passWord_label = new System.Windows.Forms.Label();
            this.userName_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.Location = new System.Drawing.Point(399, 51);
            this.id_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_box.MaxLength = 9;
            this.id_box.Multiline = true;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(230, 27);
            this.id_box.TabIndex = 1;
            this.id_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(261, 51);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(38, 24);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "ID:";
            this.id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.Navy;
            this.s.Location = new System.Drawing.Point(323, 9);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(247, 36);
            this.s.TabIndex = 2;
            this.s.Text = "Add New Student";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_label.Location = new System.Drawing.Point(261, 96);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(113, 24);
            this.firstName_label.TabIndex = 3;
            this.firstName_label.Text = "First Name:";
            this.firstName_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_label.Location = new System.Drawing.Point(261, 140);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(110, 24);
            this.lastName_label.TabIndex = 5;
            this.lastName_label.Text = "Last name:";
            this.lastName_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(261, 377);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(105, 24);
            this.birth_label.TabIndex = 8;
            this.birth_label.Text = "Birth date:";
            this.birth_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.Location = new System.Drawing.Point(261, 424);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(141, 24);
            this.start_date_label.TabIndex = 9;
            this.start_date_label.Text = "Start Contract:";
            this.start_date_label.Click += new System.EventHandler(this.label7_Click);
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_date_label.Location = new System.Drawing.Point(264, 480);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(128, 24);
            this.end_date_label.TabIndex = 10;
            this.end_date_label.Text = "End contract:";
            // 
            // medcart_lable
            // 
            this.medcart_lable.AutoSize = true;
            this.medcart_lable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medcart_lable.Location = new System.Drawing.Point(260, 558);
            this.medcart_lable.Name = "medcart_lable";
            this.medcart_lable.Size = new System.Drawing.Size(228, 24);
            this.medcart_lable.TabIndex = 14;
            this.medcart_lable.Text = "valid medical certificate:";
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.ForeColor = System.Drawing.Color.Navy;
            this.enter_button.Location = new System.Drawing.Point(399, 636);
            this.enter_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(154, 33);
            this.enter_button.TabIndex = 12;
            this.enter_button.Text = "Accept";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_label.Location = new System.Drawing.Point(261, 186);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(66, 24);
            this.mail_label.TabIndex = 18;
            this.mail_label.Text = "Email:";
            this.mail_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // birth_date
            // 
            this.birth_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Location = new System.Drawing.Point(429, 369);
            this.birth_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(200, 32);
            this.birth_date.TabIndex = 5;
            this.birth_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // end_date
            // 
            this.end_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Location = new System.Drawing.Point(429, 480);
            this.end_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 32);
            this.end_date.TabIndex = 7;
            this.end_date.ValueChanged += new System.EventHandler(this.end_date_ValueChanged);
            // 
            // med_cart_date
            // 
            this.med_cart_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Location = new System.Drawing.Point(495, 550);
            this.med_cart_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.med_cart_date.Name = "med_cart_date";
            this.med_cart_date.Size = new System.Drawing.Size(134, 32);
            this.med_cart_date.TabIndex = 8;
            // 
            // start_date
            // 
            this.start_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(429, 424);
            this.start_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(200, 32);
            this.start_date.TabIndex = 6;
            // 
            // firstname_box
            // 
            this.firstname_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_box.Location = new System.Drawing.Point(399, 96);
            this.firstname_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname_box.Multiline = true;
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(230, 27);
            this.firstname_box.TabIndex = 2;
            this.firstname_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastname_box
            // 
            this.lastname_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_box.Location = new System.Drawing.Point(399, 140);
            this.lastname_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname_box.Multiline = true;
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(230, 27);
            this.lastname_box.TabIndex = 3;
            this.lastname_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(399, 186);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_box.Multiline = true;
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(230, 27);
            this.email_box.TabIndex = 4;
            this.email_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_repeatPass
            // 
            this.tb_repeatPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repeatPass.Location = new System.Drawing.Point(399, 318);
            this.tb_repeatPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_repeatPass.Name = "tb_repeatPass";
            this.tb_repeatPass.Size = new System.Drawing.Size(230, 32);
            this.tb_repeatPass.TabIndex = 11;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(399, 273);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(230, 32);
            this.tb_pass.TabIndex = 10;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(399, 223);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(230, 32);
            this.tb_username.TabIndex = 9;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // verPassWorod_label
            // 
            this.verPassWorod_label.AutoSize = true;
            this.verPassWorod_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verPassWorod_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verPassWorod_label.Location = new System.Drawing.Point(260, 318);
            this.verPassWorod_label.Name = "verPassWorod_label";
            this.verPassWorod_label.Size = new System.Drawing.Size(137, 24);
            this.verPassWorod_label.TabIndex = 26;
            this.verPassWorod_label.Text = "Ver password:";
            this.verPassWorod_label.Click += new System.EventHandler(this.verPassWorod_label_Click);
            // 
            // passWord_label
            // 
            this.passWord_label.AutoSize = true;
            this.passWord_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passWord_label.Location = new System.Drawing.Point(260, 276);
            this.passWord_label.Name = "passWord_label";
            this.passWord_label.Size = new System.Drawing.Size(101, 24);
            this.passWord_label.TabIndex = 25;
            this.passWord_label.Text = "Password:";
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.Location = new System.Drawing.Point(261, 226);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(113, 24);
            this.userName_label.TabIndex = 24;
            this.userName_label.Text = "User name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(392, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 39);
            this.label9.TabIndex = 7;
            this.label9.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(861, 720);
            this.Controls.Add(this.tb_repeatPass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.verPassWorod_label);
            this.Controls.Add(this.passWord_label);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.med_cart_date);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.mail_label);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.medcart_lable);
            this.Controls.Add(this.end_date_label);
            this.Controls.Add(this.start_date_label);
            this.Controls.Add(this.birth_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lastName_label);
            this.Controls.Add(this.firstName_label);
            this.Controls.Add(this.s);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.lastname_box);
            this.Controls.Add(this.firstname_box);
            this.Controls.Add(this.id_box);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStudent";
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.Label start_date_label;
        private System.Windows.Forms.Label end_date_label;
        private System.Windows.Forms.Label medcart_lable;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker med_cart_date;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.TextBox firstname_box;
        private System.Windows.Forms.TextBox lastname_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox tb_repeatPass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label verPassWorod_label;
        private System.Windows.Forms.Label passWord_label;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Label label9;
    }
}