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
            this.id_label = new GLabel();
            this.firstName_label = new GLabel();
            this.lastName_label = new GLabel();
            this.birth_label = new GLabel();
            this.start_date_label = new GLabel();
            this.end_date_label = new GLabel();
            this.medcart_lable = new GLabel();
            this.enter_button = new GButton();
            this.mail_label = new GLabel();
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
            this.verPassWorod_label = new GLabel();
            this.passWord_label = new GLabel();
            this.userName_label = new GLabel();
            this.button1 = new GButton();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.Location = new System.Drawing.Point(151, 41);
            this.id_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_box.MaxLength = 9;
            this.id_box.Multiline = true;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(145, 18);
            this.id_box.TabIndex = 1;
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(44, 41);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 14);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "ID:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_label.Location = new System.Drawing.Point(44, 70);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(68, 14);
            this.firstName_label.TabIndex = 3;
            this.firstName_label.Text = "First Name:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_label.Location = new System.Drawing.Point(44, 98);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(67, 14);
            this.lastName_label.TabIndex = 5;
            this.lastName_label.Text = "Last name:";
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(75, 249);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(65, 14);
            this.birth_label.TabIndex = 8;
            this.birth_label.Text = "Birth date:";
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.Location = new System.Drawing.Point(55, 281);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(89, 14);
            this.start_date_label.TabIndex = 9;
            this.start_date_label.Text = "Start Contract:";
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_date_label.Location = new System.Drawing.Point(62, 309);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(82, 14);
            this.end_date_label.TabIndex = 10;
            this.end_date_label.Text = "End contract:";
            // 
            // medcart_lable
            // 
            this.medcart_lable.AutoSize = true;
            this.medcart_lable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medcart_lable.Location = new System.Drawing.Point(9, 344);
            this.medcart_lable.Name = "medcart_lable";
            this.medcart_lable.Size = new System.Drawing.Size(136, 14);
            this.medcart_lable.TabIndex = 14;
            this.medcart_lable.Text = "valid medical certificate:";
            // 
            // enter_button
            // 
           // this.enter_button.BackColor = System.Drawing.SystemColors.Highlight;
         //   this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
         //   this.enter_button.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          //  this.enter_button.ForeColor = System.Drawing.Color.Navy;
            this.enter_button.Location = new System.Drawing.Point(118, 382);
            this.enter_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(80, 33);
            this.enter_button.TabIndex = 12;
            this.enter_button.Text = "Add ";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_label.Location = new System.Drawing.Point(44, 126);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(38, 14);
            this.mail_label.TabIndex = 18;
            this.mail_label.Text = "Email:";
            // 
            // birth_date
            // 
            this.birth_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Location = new System.Drawing.Point(150, 243);
            this.birth_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(130, 19);
            this.birth_date.TabIndex = 8;
            // 
            // end_date
            // 
            this.end_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Location = new System.Drawing.Point(151, 301);
            this.end_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(130, 19);
            this.end_date.TabIndex = 10;
            // 
            // med_cart_date
            // 
            this.med_cart_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Location = new System.Drawing.Point(150, 338);
            this.med_cart_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.med_cart_date.Name = "med_cart_date";
            this.med_cart_date.Size = new System.Drawing.Size(130, 19);
            this.med_cart_date.TabIndex = 11;
            // 
            // start_date
            // 
            this.start_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(151, 275);
            this.start_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(130, 19);
            this.start_date.TabIndex = 9;
            // 
            // firstname_box
            // 
            this.firstname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_box.Location = new System.Drawing.Point(151, 67);
            this.firstname_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname_box.MaxLength = 29;
            this.firstname_box.Multiline = true;
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(145, 20);
            this.firstname_box.TabIndex = 2;
            // 
            // lastname_box
            // 
            this.lastname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_box.Location = new System.Drawing.Point(151, 95);
            this.lastname_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname_box.MaxLength = 29;
            this.lastname_box.Multiline = true;
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(145, 20);
            this.lastname_box.TabIndex = 3;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(151, 123);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_box.MaxLength = 29;
            this.email_box.Multiline = true;
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(145, 20);
            this.email_box.TabIndex = 4;
            // 
            // tb_repeatPass
            // 
            this.tb_repeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repeatPass.Location = new System.Drawing.Point(151, 206);
            this.tb_repeatPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_repeatPass.MaxLength = 29;
            this.tb_repeatPass.Name = "tb_repeatPass";
            this.tb_repeatPass.Size = new System.Drawing.Size(145, 19);
            this.tb_repeatPass.TabIndex = 7;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(151, 175);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.MaxLength = 29;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(145, 19);
            this.tb_pass.TabIndex = 6;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(150, 149);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_username.MaxLength = 29;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(146, 19);
            this.tb_username.TabIndex = 5;
            // 
            // verPassWorod_label
            // 
            this.verPassWorod_label.AutoSize = true;
            this.verPassWorod_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verPassWorod_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verPassWorod_label.Location = new System.Drawing.Point(44, 214);
            this.verPassWorod_label.Name = "verPassWorod_label";
            this.verPassWorod_label.Size = new System.Drawing.Size(85, 14);
            this.verPassWorod_label.TabIndex = 26;
            this.verPassWorod_label.Text = "Ver password:";
            // 
            // passWord_label
            // 
            this.passWord_label.AutoSize = true;
            this.passWord_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passWord_label.Location = new System.Drawing.Point(44, 183);
            this.passWord_label.Name = "passWord_label";
            this.passWord_label.Size = new System.Drawing.Size(62, 14);
            this.passWord_label.TabIndex = 25;
            this.passWord_label.Text = "Password:";
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.Location = new System.Drawing.Point(43, 157);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(69, 14);
            this.userName_label.TabIndex = 24;
            this.userName_label.Text = "User name:";
            // 
            // button1
            // 
            //this.button1.BackColor = System.Drawing.SystemColors.Highlight;
           // this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
          ///  this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(206, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(339, 440);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.lastName_label);
            this.Controls.Add(this.firstName_label);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_box;
        private GLabel id_label;
        private GLabel firstName_label;
        private GLabel lastName_label;
        private GLabel birth_label;
        private GLabel start_date_label;
        private GLabel end_date_label;
        private GLabel medcart_lable;
        private GButton enter_button;
        private GLabel mail_label;
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
        private GLabel verPassWorod_label;
        private GLabel passWord_label;
        private GLabel userName_label;
        private GButton button1;
    }
}