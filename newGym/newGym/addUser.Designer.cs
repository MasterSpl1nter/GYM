namespace newGym
{
    partial class addUser
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
            this.idLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.managerEmail = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.managerLastName = new System.Windows.Forms.TextBox();
            this.managerId = new System.Windows.Forms.TextBox();
            this.managerFirstName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idLabel.Location = new System.Drawing.Point(94, 53);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 42;
            this.idLabel.Text = "Id:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(62, 183);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 43;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(58, 157);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameLabel.TabIndex = 44;
            this.userNameLabel.Text = "User name:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(116, 180);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 54;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(81, 131);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 45;
            this.EmailLabel.Text = "Email:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(116, 154);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 53;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(58, 106);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 46;
            this.lastNameLabel.Text = "Last name:";
            // 
            // managerEmail
            // 
            this.managerEmail.Location = new System.Drawing.Point(116, 128);
            this.managerEmail.Name = "managerEmail";
            this.managerEmail.Size = new System.Drawing.Size(100, 20);
            this.managerEmail.TabIndex = 51;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(58, 79);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 47;
            this.firstNameLabel.Text = "First name:";
            // 
            // managerLastName
            // 
            this.managerLastName.Location = new System.Drawing.Point(116, 102);
            this.managerLastName.Name = "managerLastName";
            this.managerLastName.Size = new System.Drawing.Size(100, 20);
            this.managerLastName.TabIndex = 50;
            // 
            // managerId
            // 
            this.managerId.Location = new System.Drawing.Point(116, 50);
            this.managerId.Name = "managerId";
            this.managerId.Size = new System.Drawing.Size(100, 20);
            this.managerId.TabIndex = 48;
            // 
            // managerFirstName
            // 
            this.managerFirstName.Location = new System.Drawing.Point(116, 76);
            this.managerFirstName.Name = "managerFirstName";
            this.managerFirstName.Size = new System.Drawing.Size(100, 20);
            this.managerFirstName.TabIndex = 49;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 56;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 310);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.managerEmail);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.managerLastName);
            this.Controls.Add(this.managerId);
            this.Controls.Add(this.managerFirstName);
            this.Name = "addUser";
            this.Text = "addUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox managerEmail;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox managerLastName;
        private System.Windows.Forms.TextBox managerId;
        private System.Windows.Forms.TextBox managerFirstName;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}