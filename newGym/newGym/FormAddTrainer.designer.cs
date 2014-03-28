namespace newGym
{
    partial class FormAddTrainer
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
            this.id_txt = new System.Windows.Forms.TextBox();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.save_butten = new System.Windows.Forms.Button();
            this.clear_all_button = new System.Windows.Forms.Button();
            this.email_verification = new System.Windows.Forms.Label();
            this.lable8 = new System.Windows.Forms.Label();
            this.salar_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(110, 39);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 1;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            this.id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_txt_KeyPress);
            // 
            // firstname_txt
            // 
            this.firstname_txt.Location = new System.Drawing.Point(110, 65);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(100, 20);
            this.firstname_txt.TabIndex = 2;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(110, 91);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(100, 20);
            this.lastname_txt.TabIndex = 3;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(110, 117);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 20);
            this.email_txt.TabIndex = 4;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(110, 143);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(100, 20);
            this.username_txt.TabIndex = 5;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(110, 169);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "eMail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // save_butten
            // 
            this.save_butten.Location = new System.Drawing.Point(18, 238);
            this.save_butten.Name = "save_butten";
            this.save_butten.Size = new System.Drawing.Size(75, 23);
            this.save_butten.TabIndex = 8;
            this.save_butten.Text = "Add";
            this.save_butten.UseVisualStyleBackColor = true;
            this.save_butten.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear_all_button
            // 
            this.clear_all_button.Location = new System.Drawing.Point(134, 238);
            this.clear_all_button.Name = "clear_all_button";
            this.clear_all_button.Size = new System.Drawing.Size(75, 23);
            this.clear_all_button.TabIndex = 8;
            this.clear_all_button.Text = "Clear All";
            this.clear_all_button.UseVisualStyleBackColor = true;
            this.clear_all_button.Click += new System.EventHandler(this.clear_all_button_Click);
            // 
            // email_verification
            // 
            this.email_verification.AutoSize = true;
            this.email_verification.ForeColor = System.Drawing.Color.Red;
            this.email_verification.Location = new System.Drawing.Point(389, 166);
            this.email_verification.Name = "email_verification";
            this.email_verification.Size = new System.Drawing.Size(0, 13);
            this.email_verification.TabIndex = 10;
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(15, 202);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(81, 13);
            this.lable8.TabIndex = 11;
            this.lable8.Text = "Salary Per Hour";
            // 
            // salar_txt
            // 
            this.salar_txt.Location = new System.Drawing.Point(110, 195);
            this.salar_txt.Name = "salar_txt";
            this.salar_txt.Size = new System.Drawing.Size(100, 20);
            this.salar_txt.TabIndex = 7;
            this.salar_txt.TextChanged += new System.EventHandler(this.salar_txt_TextChanged);
            // 
            // FormAddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 295);
            this.Controls.Add(this.salar_txt);
            this.Controls.Add(this.lable8);
            this.Controls.Add(this.email_verification);
            this.Controls.Add(this.clear_all_button);
            this.Controls.Add(this.save_butten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.lastname_txt);
            this.Controls.Add(this.firstname_txt);
            this.Controls.Add(this.id_txt);
            this.Name = "FormAddTrainer";
            this.Text = "FormAddTrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_butten;
        private System.Windows.Forms.Button clear_all_button;
        private System.Windows.Forms.Label email_verification;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.TextBox salar_txt;
    }
}