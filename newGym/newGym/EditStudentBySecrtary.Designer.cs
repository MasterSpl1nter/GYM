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
            this.edit_by_id = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.userName_label = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.med_cart_date = new System.Windows.Forms.DateTimePicker();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.mail_label = new System.Windows.Forms.Label();
            this.enter_button = new GButton();
            this.medcart_lable = new System.Windows.Forms.Label();
            this.end_date_label = new System.Windows.Forms.Label();
            this.start_date_label = new System.Windows.Forms.Label();
            this.birth_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.firstName_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.lastname_box = new System.Windows.Forms.TextBox();
            this.firstname_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // student_search
            // 
            this.student_search.FormattingEnabled = true;
            this.student_search.Location = new System.Drawing.Point(218, 36);
            this.student_search.Name = "student_search";
            this.student_search.Size = new System.Drawing.Size(176, 24);
            this.student_search.TabIndex = 0;
            this.student_search.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // edit_by_id
            // 
            this.edit_by_id.AutoSize = true;
            this.edit_by_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edit_by_id.Location = new System.Drawing.Point(107, 35);
            this.edit_by_id.Name = "edit_by_id";
            this.edit_by_id.Size = new System.Drawing.Size(100, 22);
            this.edit_by_id.TabIndex = 1;
            this.edit_by_id.Text = "Choose ID:";
            this.edit_by_id.Click += new System.EventHandler(this.edit_by_id_Click);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(216, 244);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(178, 26);
            this.tb_username.TabIndex = 39;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.Location = new System.Drawing.Point(128, 244);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(85, 18);
            this.userName_label.TabIndex = 47;
            this.userName_label.Text = "User name:";
            // 
            // start_date
            // 
            this.start_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(216, 336);
            this.start_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(219, 26);
            this.start_date.TabIndex = 35;
            // 
            // med_cart_date
            // 
            this.med_cart_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_cart_date.Location = new System.Drawing.Point(218, 423);
            this.med_cart_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.med_cart_date.Name = "med_cart_date";
            this.med_cart_date.Size = new System.Drawing.Size(217, 26);
            this.med_cart_date.TabIndex = 37;
            // 
            // end_date
            // 
            this.end_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Location = new System.Drawing.Point(218, 377);
            this.end_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(217, 26);
            this.end_date.TabIndex = 36;
            // 
            // birth_date
            // 
            this.birth_date.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Location = new System.Drawing.Point(218, 296);
            this.birth_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(217, 26);
            this.birth_date.TabIndex = 33;
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_label.Location = new System.Drawing.Point(165, 200);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(46, 18);
            this.mail_label.TabIndex = 46;
            this.mail_label.Text = "Email:";
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.ForeColor = System.Drawing.Color.Navy;
            this.enter_button.Location = new System.Drawing.Point(240, 492);
            this.enter_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(154, 33);
            this.enter_button.TabIndex = 44;
            this.enter_button.Text = "edit";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // medcart_lable
            // 
            this.medcart_lable.AutoSize = true;
            this.medcart_lable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medcart_lable.Location = new System.Drawing.Point(46, 429);
            this.medcart_lable.Name = "medcart_lable";
            this.medcart_lable.Size = new System.Drawing.Size(161, 18);
            this.medcart_lable.TabIndex = 45;
            this.medcart_lable.Text = "valid medical certificate:";
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_date_label.Location = new System.Drawing.Point(112, 383);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(95, 18);
            this.end_date_label.TabIndex = 42;
            this.end_date_label.Text = "End contract:";
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.Location = new System.Drawing.Point(103, 336);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(104, 18);
            this.start_date_label.TabIndex = 40;
            this.start_date_label.Text = "Start Contract:";
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(131, 296);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(76, 18);
            this.birth_label.TabIndex = 38;
            this.birth_label.Text = "Birth date:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_label.Location = new System.Drawing.Point(125, 155);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(82, 18);
            this.lastName_label.TabIndex = 34;
            this.lastName_label.Text = "Last name:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_label.Location = new System.Drawing.Point(123, 119);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(84, 18);
            this.firstName_label.TabIndex = 31;
            this.firstName_label.Text = "First Name:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(178, 84);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(29, 18);
            this.id_label.TabIndex = 28;
            this.id_label.Text = "ID:";
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(218, 192);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_box.Multiline = true;
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(176, 28);
            this.email_box.TabIndex = 32;
            // 
            // lastname_box
            // 
            this.lastname_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_box.Location = new System.Drawing.Point(218, 145);
            this.lastname_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname_box.Multiline = true;
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(176, 28);
            this.lastname_box.TabIndex = 30;
            // 
            // firstname_box
            // 
            this.firstname_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_box.Location = new System.Drawing.Point(218, 110);
            this.firstname_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname_box.Multiline = true;
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(176, 27);
            this.firstname_box.TabIndex = 29;
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.Location = new System.Drawing.Point(218, 76);
            this.id_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_box.MaxLength = 9;
            this.id_box.Multiline = true;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(176, 26);
            this.id_box.TabIndex = 27;
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // EditStudentBySecrtary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 561);
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
            this.Name = "EditStudentBySecrtary";
            this.Text = "EditStudentBySecrtary";
            this.Load += new System.EventHandler(this.EditStudentBySecrtary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox student_search;
        private System.Windows.Forms.Label edit_by_id;
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
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox lastname_box;
        private System.Windows.Forms.TextBox firstname_box;
        private System.Windows.Forms.TextBox id_box;
    }
}