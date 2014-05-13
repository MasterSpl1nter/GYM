namespace newGym
{
    partial class FormEditTrainer
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
            this.edit_button = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.pasword = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_all_button = new System.Windows.Forms.Button();
            this.email_verification = new System.Windows.Forms.Label();
            this.salar_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(53, 269);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 8;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(50, 64);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 2;
            this.id.Text = "ID";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(50, 90);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(57, 13);
            this.firstname.TabIndex = 3;
            this.firstname.Text = "First Name";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(49, 116);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(58, 13);
            this.lastname.TabIndex = 4;
            this.lastname.Text = "Last Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(50, 142);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 5;
            this.email.Text = "eMail";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(50, 168);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 6;
            this.username.Text = "Username";
            // 
            // pasword
            // 
            this.pasword.AutoSize = true;
            this.pasword.Location = new System.Drawing.Point(50, 194);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(53, 13);
            this.pasword.TabIndex = 7;
            this.pasword.Text = "Password";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(113, 57);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 1;
            this.id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_txt_KeyPress);
            // 
            // firstname_txt
            // 
            this.firstname_txt.Location = new System.Drawing.Point(113, 83);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(100, 20);
            this.firstname_txt.TabIndex = 2;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(113, 109);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(100, 20);
            this.lastname_txt.TabIndex = 3;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(113, 135);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 20);
            this.email_txt.TabIndex = 4;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(113, 161);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(100, 20);
            this.username_txt.TabIndex = 5;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(113, 187);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chose Trainer to edit";
            // 
            // clear_all_button
            // 
            this.clear_all_button.Location = new System.Drawing.Point(138, 268);
            this.clear_all_button.Name = "clear_all_button";
            this.clear_all_button.Size = new System.Drawing.Size(75, 23);
            this.clear_all_button.TabIndex = 9;
            this.clear_all_button.Text = "Clear All";
            this.clear_all_button.UseVisualStyleBackColor = true;
            this.clear_all_button.Click += new System.EventHandler(this.clear_all_button_Click);
            // 
            // email_verification
            // 
            this.email_verification.AutoSize = true;
            this.email_verification.ForeColor = System.Drawing.Color.Red;
            this.email_verification.Location = new System.Drawing.Point(59, 301);
            this.email_verification.Name = "email_verification";
            this.email_verification.Size = new System.Drawing.Size(0, 13);
            this.email_verification.TabIndex = 16;
            // 
            // salar_txt
            // 
            this.salar_txt.Location = new System.Drawing.Point(113, 214);
            this.salar_txt.Name = "salar_txt";
            this.salar_txt.Size = new System.Drawing.Size(100, 20);
            this.salar_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Salary Per Hour";
            // 
            // FormEditTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salar_txt);
            this.Controls.Add(this.email_verification);
            this.Controls.Add(this.clear_all_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.lastname_txt);
            this.Controls.Add(this.firstname_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.id);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormEditTrainer";
            this.Text = "FormEditTrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label pasword;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_all_button;
        private System.Windows.Forms.Label email_verification;
        private System.Windows.Forms.TextBox salar_txt;
        private System.Windows.Forms.Label label2;

    }
}