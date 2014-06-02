namespace newGym
{
    partial class GuideForm
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
            this.AddGuideButton = new GButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fnameText = new System.Windows.Forms.TextBox();
            this.lnameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.salaryText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new GButton();
            this.label6 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteGuideButton = new GButton();
            this.EditGuideButton = new GButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddGuideButton
            // 
            this.AddGuideButton.Location = new System.Drawing.Point(25, 244);
            this.AddGuideButton.Name = "AddGuideButton";
            this.AddGuideButton.Size = new System.Drawing.Size(75, 33);
            this.AddGuideButton.TabIndex = 0;
            this.AddGuideButton.Text = "Add guide";
            this.AddGuideButton.UseVisualStyleBackColor = true;
            this.AddGuideButton.Click += new System.EventHandler(this.AddGuideButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // fnameText
            // 
            this.fnameText.Location = new System.Drawing.Point(85, 52);
            this.fnameText.MaxLength = 30;
            this.fnameText.Name = "fnameText";
            this.fnameText.Size = new System.Drawing.Size(100, 20);
            this.fnameText.TabIndex = 8;
            this.fnameText.Tag = "label1";
            // 
            // lnameText
            // 
            this.lnameText.Location = new System.Drawing.Point(85, 78);
            this.lnameText.MaxLength = 30;
            this.lnameText.Name = "lnameText";
            this.lnameText.Size = new System.Drawing.Size(100, 20);
            this.lnameText.TabIndex = 9;
            this.lnameText.Tag = "label2";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(85, 104);
            this.emailText.MaxLength = 30;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 10;
            this.emailText.Tag = "label3";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(85, 130);
            this.userText.MaxLength = 30;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 20);
            this.userText.TabIndex = 11;
            this.userText.Tag = "label4";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(85, 156);
            this.passText.MaxLength = 30;
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(100, 20);
            this.passText.TabIndex = 12;
            this.passText.Tag = "label5";
            // 
            // salaryText
            // 
            this.salaryText.Location = new System.Drawing.Point(85, 182);
            this.salaryText.MaxLength = 9;
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(100, 20);
            this.salaryText.TabIndex = 15;
            this.salaryText.Tag = "label7";
            this.salaryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryText_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hourly salary";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(85, 26);
            this.idText.MaxLength = 9;
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 13;
            this.idText.Tag = "label6";
            this.idText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idText_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteGuideButton);
            this.panel1.Controls.Add(this.EditGuideButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lnameText);
            this.panel1.Controls.Add(this.AddGuideButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salaryText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.idText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.passText);
            this.panel1.Controls.Add(this.fnameText);
            this.panel1.Controls.Add(this.userText);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 301);
            this.panel1.TabIndex = 20;
            // 
            // DeleteGuideButton
            // 
            this.DeleteGuideButton.Location = new System.Drawing.Point(25, 244);
            this.DeleteGuideButton.Name = "DeleteGuideButton";
            this.DeleteGuideButton.Size = new System.Drawing.Size(75, 33);
            this.DeleteGuideButton.TabIndex = 21;
            this.DeleteGuideButton.Text = "Delete guide";
            this.DeleteGuideButton.UseVisualStyleBackColor = true;
            this.DeleteGuideButton.Visible = false;
            this.DeleteGuideButton.Click += new System.EventHandler(this.DeleteGuideButton_Click);
            // 
            // EditGuideButton
            // 
            this.EditGuideButton.Location = new System.Drawing.Point(25, 244);
            this.EditGuideButton.Name = "EditGuideButton";
            this.EditGuideButton.Size = new System.Drawing.Size(75, 33);
            this.EditGuideButton.TabIndex = 20;
            this.EditGuideButton.Text = "Edit Guide";
            this.EditGuideButton.UseVisualStyleBackColor = true;
            this.EditGuideButton.Visible = false;
            this.EditGuideButton.Click += new System.EventHandler(this.EditGuideButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 26);
            this.comboBox1.MaxLength = 9;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 323);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GuideForm";
            this.Text = "Add Guide";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GButton AddGuideButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fnameText;
        private System.Windows.Forms.TextBox lnameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox salaryText;
        private System.Windows.Forms.Label label7;
        private GButton button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private GButton EditGuideButton;
        private GButton DeleteGuideButton;
    }
}

