namespace newGym
{
    partial class editManager
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
            this.MangerSalaryPerHour = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.salaryPerHourLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.managerEmail = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.managerLastName = new System.Windows.Forms.TextBox();
            this.managerFirstName = new System.Windows.Forms.TextBox();
            this.exit_update = new System.Windows.Forms.Button();
            this.update_manger_button = new System.Windows.Forms.Button();
            this.userId = new System.Windows.Forms.Label();
            this.removeUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MangerSalaryPerHour
            // 
            this.MangerSalaryPerHour.Location = new System.Drawing.Point(126, 126);
            this.MangerSalaryPerHour.MaxLength = 9;
            this.MangerSalaryPerHour.Name = "MangerSalaryPerHour";
            this.MangerSalaryPerHour.Size = new System.Drawing.Size(100, 20);
            this.MangerSalaryPerHour.TabIndex = 52;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idLabel.Location = new System.Drawing.Point(98, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 13);
            this.idLabel.TabIndex = 42;
            this.idLabel.Text = "ID:";
            // 
            // salaryPerHourLabel
            // 
            this.salaryPerHourLabel.AutoSize = true;
            this.salaryPerHourLabel.Location = new System.Drawing.Point(69, 129);
            this.salaryPerHourLabel.Name = "salaryPerHourLabel";
            this.salaryPerHourLabel.Size = new System.Drawing.Size(51, 13);
            this.salaryPerHourLabel.TabIndex = 55;
            this.salaryPerHourLabel.Text = "Payment:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(64, 181);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 43;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(59, 155);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameLabel.TabIndex = 44;
            this.userNameLabel.Text = "User name:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(126, 178);
            this.password.MaxLength = 29;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 54;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(85, 103);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 45;
            this.EmailLabel.Text = "Email:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(126, 152);
            this.userName.MaxLength = 29;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 53;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(61, 77);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 46;
            this.lastNameLabel.Text = "Last name:";
            // 
            // managerEmail
            // 
            this.managerEmail.Location = new System.Drawing.Point(126, 100);
            this.managerEmail.MaxLength = 39;
            this.managerEmail.Name = "managerEmail";
            this.managerEmail.Size = new System.Drawing.Size(100, 20);
            this.managerEmail.TabIndex = 51;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(62, 51);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 47;
            this.firstNameLabel.Text = "First name:";
            // 
            // managerLastName
            // 
            this.managerLastName.Location = new System.Drawing.Point(126, 74);
            this.managerLastName.MaxLength = 29;
            this.managerLastName.Name = "managerLastName";
            this.managerLastName.Size = new System.Drawing.Size(100, 20);
            this.managerLastName.TabIndex = 50;
            // 
            // managerFirstName
            // 
            this.managerFirstName.Location = new System.Drawing.Point(126, 48);
            this.managerFirstName.MaxLength = 29;
            this.managerFirstName.Name = "managerFirstName";
            this.managerFirstName.Size = new System.Drawing.Size(100, 20);
            this.managerFirstName.TabIndex = 49;
            this.managerFirstName.TextChanged += new System.EventHandler(this.managerFirstName_TextChanged);
            // 
            // exit_update
            // 
            this.exit_update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exit_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit_update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exit_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_update.Location = new System.Drawing.Point(199, 210);
            this.exit_update.Name = "exit_update";
            this.exit_update.Size = new System.Drawing.Size(73, 29);
            this.exit_update.TabIndex = 58;
            this.exit_update.Text = "Clear";
            this.exit_update.UseVisualStyleBackColor = false;
            this.exit_update.Click += new System.EventHandler(this.exit_update_Click);
            // 
            // update_manger_button
            // 
            this.update_manger_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.update_manger_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.update_manger_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.update_manger_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_manger_button.Location = new System.Drawing.Point(16, 210);
            this.update_manger_button.Name = "update_manger_button";
            this.update_manger_button.Size = new System.Drawing.Size(104, 29);
            this.update_manger_button.TabIndex = 57;
            this.update_manger_button.Text = "Update";
            this.update_manger_button.UseVisualStyleBackColor = false;
            this.update_manger_button.Click += new System.EventHandler(this.update_manger_button_Click);
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userId.Location = new System.Drawing.Point(137, 23);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(0, 17);
            this.userId.TabIndex = 60;
            this.userId.Click += new System.EventHandler(this.label2_Click);
            // 
            // removeUser
            // 
            this.removeUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.removeUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeUser.Location = new System.Drawing.Point(123, 210);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(73, 29);
            this.removeUser.TabIndex = 61;
            this.removeUser.Text = "remove";
            this.removeUser.UseVisualStyleBackColor = false;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            // 
            // editManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.removeUser);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.exit_update);
            this.Controls.Add(this.update_manger_button);
            this.Controls.Add(this.MangerSalaryPerHour);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.salaryPerHourLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.managerEmail);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.managerLastName);
            this.Controls.Add(this.managerFirstName);
            this.Name = "editManager";
            this.Text = "editManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MangerSalaryPerHour;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label salaryPerHourLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox managerEmail;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox managerLastName;
        private System.Windows.Forms.TextBox managerFirstName;
        private System.Windows.Forms.Button exit_update;
        private System.Windows.Forms.Button update_manger_button;
        private System.Windows.Forms.Label userId;
        private System.Windows.Forms.Button removeUser;
    }
}