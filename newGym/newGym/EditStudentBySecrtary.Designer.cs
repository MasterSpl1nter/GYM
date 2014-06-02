namespace newGym
{
    partial class EditStudentBySecrtary
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
            this.student_search = new System.Windows.Forms.ComboBox();
            this.edit_by_id = new GLabel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.userName_label = new GLabel();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.med_cart_date = new System.Windows.Forms.DateTimePicker();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.mail_label = new GLabel();
            this.enter_button = new newGym.GButton();
            this.medcart_lable = new GLabel();
            this.end_date_label = new GLabel();
            this.start_date_label = new GLabel();
            this.birth_label = new GLabel();
            this.lastName_label = new GLabel();
            this.firstName_label = new GLabel();
            this.id_label = new GLabel();
            this.email_box = new System.Windows.Forms.TextBox();
            this.lastname_box = new System.Windows.Forms.TextBox();
            this.firstname_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // student_search
            // 
            this.student_search.FormattingEnabled = true;
            this.student_search.Location = new System.Drawing.Point(164, 29);
            this.student_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.student_search.Name = "student_search";
            this.student_search.Size = new System.Drawing.Size(133, 21);
            this.student_search.TabIndex = 0;
            this.student_search.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // edit_by_id
            // 
            this.edit_by_id.AutoSize = true;
            this.edit_by_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edit_by_id.Location = new System.Drawing.Point(80, 28);
            this.edit_by_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edit_by_id.Name = "edit_by_id";
            this.edit_by_id.Size = new System.Drawing.Size(79, 19);
            this.edit_by_id.TabIndex = 1;
            this.edit_by_id.Text = "Choose ID:";
            this.edit_by_id.Click += new System.EventHandler(this.edit_by_id_Click);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(162, 198);
            this.tb_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(134, 22);
            this.tb_username.TabIndex = 39;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.Location = new System.Drawing.Point(96, 198);
            this.userName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(69, 14);
            this.userName_label.TabIndex = 47;
            this.userName_label.Text = "User name:";
            // 
            // start_date
            // 
            this.start_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(162, 273);
            this.start_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(165, 22);
            this.start_date.TabIndex = 35;
            // 
            // med_cart_date
            // 
            this.med_cart_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Location = new System.Drawing.Point(164, 344);
            this.med_cart_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.med_cart_date.Name = "med_cart_date";
            this.med_cart_date.Size = new System.Drawing.Size(164, 22);
            this.med_cart_date.TabIndex = 37;
            // 
            // end_date
            // 
            this.end_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Location = new System.Drawing.Point(164, 306);
            this.end_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(164, 22);
            this.end_date.TabIndex = 36;
            // 
            // birth_date
            // 
            this.birth_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Location = new System.Drawing.Point(164, 240);
            this.birth_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(164, 22);
            this.birth_date.TabIndex = 33;
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_label.Location = new System.Drawing.Point(124, 162);
            this.mail_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(38, 14);
            this.mail_label.TabIndex = 46;
            this.mail_label.Text = "Email:";
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.ForeColor = System.Drawing.Color.AliceBlue;
            this.enter_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enter_button.Location = new System.Drawing.Point(180, 400);
            this.enter_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(116, 27);
            this.enter_button.TabIndex = 44;
            this.enter_button.Text = "Edit";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // medcart_lable
            // 
            this.medcart_lable.AutoSize = true;
            this.medcart_lable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medcart_lable.Location = new System.Drawing.Point(34, 349);
            this.medcart_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medcart_lable.Name = "medcart_lable";
            this.medcart_lable.Size = new System.Drawing.Size(136, 14);
            this.medcart_lable.TabIndex = 45;
            this.medcart_lable.Text = "valid medical certificate:";
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_date_label.Location = new System.Drawing.Point(84, 311);
            this.end_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(82, 14);
            this.end_date_label.TabIndex = 42;
            this.end_date_label.Text = "End contract:";
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.Location = new System.Drawing.Point(77, 273);
            this.start_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(89, 14);
            this.start_date_label.TabIndex = 40;
            this.start_date_label.Text = "Start Contract:";
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(98, 240);
            this.birth_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(65, 14);
            this.birth_label.TabIndex = 38;
            this.birth_label.Text = "Birth date:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_label.Location = new System.Drawing.Point(94, 126);
            this.lastName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(67, 14);
            this.lastName_label.TabIndex = 34;
            this.lastName_label.Text = "Last name:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_label.Location = new System.Drawing.Point(92, 97);
            this.firstName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(68, 14);
            this.firstName_label.TabIndex = 31;
            this.firstName_label.Text = "First Name:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(134, 68);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 14);
            this.id_label.TabIndex = 28;
            this.id_label.Text = "ID:";
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(164, 156);
            this.email_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.email_box.Multiline = true;
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(133, 24);
            this.email_box.TabIndex = 32;
            // 
            // lastname_box
            // 
            this.lastname_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_box.Location = new System.Drawing.Point(164, 118);
            this.lastname_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastname_box.Multiline = true;
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(133, 24);
            this.lastname_box.TabIndex = 30;
            // 
            // firstname_box
            // 
            this.firstname_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_box.Location = new System.Drawing.Point(164, 89);
            this.firstname_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstname_box.Multiline = true;
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(133, 23);
            this.firstname_box.TabIndex = 29;
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.Location = new System.Drawing.Point(164, 62);
            this.id_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.id_box.MaxLength = 9;
            this.id_box.Multiline = true;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(133, 22);
            this.id_box.TabIndex = 27;
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // EditStudentBySecrtary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 456);
            this.Controls.Add(this.tb_username);
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
            this.Controls.Add(this.edit_by_id);
            this.Controls.Add(this.student_search);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditStudentBySecrtary";
            this.Text = "EditStudentBySecrtary";
            this.Load += new System.EventHandler(this.EditStudentBySecrtary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox student_search;
        private GLabel edit_by_id;
        private System.Windows.Forms.TextBox tb_username;
        private GLabel userName_label;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.DateTimePicker med_cart_date;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker birth_date;
        private GLabel mail_label;
        private GButton enter_button;
        private GLabel medcart_lable;
        private GLabel end_date_label;
        private GLabel start_date_label;
        private GLabel birth_label;
        private GLabel lastName_label;
        private GLabel firstName_label;
        private GLabel id_label;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox lastname_box;
        private System.Windows.Forms.TextBox firstname_box;
        private System.Windows.Forms.TextBox id_box;
    }
}