	namespace newGym
	{
	    partial class addManager
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
            this.AddManagerUser = new newGym.GButton();
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
            this.exit_update = new newGym.GButton();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MangerSalaryPerHour
            // 
            this.MangerSalaryPerHour.Location = new System.Drawing.Point(82, 152);
            this.MangerSalaryPerHour.MaxLength = 9;
            this.MangerSalaryPerHour.Name = "MangerSalaryPerHour";
            this.MangerSalaryPerHour.Size = new System.Drawing.Size(100, 20);
            this.MangerSalaryPerHour.TabIndex = 6;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idLabel.Location = new System.Drawing.Point(54, 51);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 13);
            this.idLabel.TabIndex = 27;
            this.idLabel.Text = "ID:";
            // 
            // salaryPerHourLabel
            // 
            this.salaryPerHourLabel.AutoSize = true;
            this.salaryPerHourLabel.Location = new System.Drawing.Point(25, 155);
            this.salaryPerHourLabel.Name = "salaryPerHourLabel";
            this.salaryPerHourLabel.Size = new System.Drawing.Size(51, 13);
            this.salaryPerHourLabel.TabIndex = 41;
            this.salaryPerHourLabel.Text = "Payment:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(20, 207);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 28;
            this.passwordLabel.Text = "Password:";
            // 
            // AddManagerUser
            // 
            this.AddManagerUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddManagerUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddManagerUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddManagerUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddManagerUser.ForeColor = System.Drawing.Color.White;
            this.AddManagerUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddManagerUser.Location = new System.Drawing.Point(39, 238);
            this.AddManagerUser.Name = "AddManagerUser";
            this.AddManagerUser.Size = new System.Drawing.Size(81, 29);
            this.AddManagerUser.TabIndex = 9;
            this.AddManagerUser.Text = "ADD";
            this.AddManagerUser.UseVisualStyleBackColor = false;
            this.AddManagerUser.Click += new System.EventHandler(this.AddManagerUser_Click_1);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(15, 181);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameLabel.TabIndex = 29;
            this.userNameLabel.Text = "User name:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(82, 204);
            this.password.MaxLength = 29;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 8;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(41, 129);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 30;
            this.EmailLabel.Text = "Email:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(82, 178);
            this.userName.MaxLength = 29;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 7;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(17, 103);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 31;
            this.lastNameLabel.Text = "Last name:";
            // 
            // managerEmail
            // 
            this.managerEmail.Location = new System.Drawing.Point(82, 126);
            this.managerEmail.MaxLength = 29;
            this.managerEmail.Name = "managerEmail";
            this.managerEmail.Size = new System.Drawing.Size(100, 20);
            this.managerEmail.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(18, 77);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 32;
            this.firstNameLabel.Text = "First name:";
            // 
            // managerLastName
            // 
            this.managerLastName.Location = new System.Drawing.Point(82, 100);
            this.managerLastName.MaxLength = 29;
            this.managerLastName.Name = "managerLastName";
            this.managerLastName.Size = new System.Drawing.Size(100, 20);
            this.managerLastName.TabIndex = 4;
            // 
            // managerId
            // 
            this.managerId.Location = new System.Drawing.Point(82, 48);
            this.managerId.MaxLength = 9;
            this.managerId.Name = "managerId";
            this.managerId.Size = new System.Drawing.Size(100, 20);
            this.managerId.TabIndex = 2;
            // 
            // managerFirstName
            // 
            this.managerFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.managerFirstName.Location = new System.Drawing.Point(82, 74);
            this.managerFirstName.MaxLength = 29;
            this.managerFirstName.Name = "managerFirstName";
            this.managerFirstName.Size = new System.Drawing.Size(100, 20);
            this.managerFirstName.TabIndex = 3;
            // 
            // exit_update
            // 
            this.exit_update.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exit_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_update.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exit_update.ForeColor = System.Drawing.Color.White;
            this.exit_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_update.Location = new System.Drawing.Point(126, 238);
            this.exit_update.Name = "exit_update";
            this.exit_update.Size = new System.Drawing.Size(73, 29);
            this.exit_update.TabIndex = 10;
            this.exit_update.Text = "Clear";
            this.exit_update.UseVisualStyleBackColor = false;
            this.exit_update.Visible = false;
            this.exit_update.Click += new System.EventHandler(this.exit_update_Click);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Items.AddRange(new object[] {
            "Manager",
            "Guide",
            "Trainer",
            "Worker"});
            this.DepartmentComboBox.Location = new System.Drawing.Point(82, 21);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(100, 21);
            this.DepartmentComboBox.TabIndex = 1;
            this.DepartmentComboBox.Visible = false;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Department:";
            // 
            // addManager
            // 
            this.ClientSize = new System.Drawing.Size(232, 299);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_update);
            this.Controls.Add(this.MangerSalaryPerHour);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.salaryPerHourLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.AddManagerUser);
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
            this.Name = "addManager";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

	        }
	
	        #endregion
	
	        private System.Windows.Forms.TextBox MangerSalaryPerHour;
            private System.Windows.Forms.Label idLabel;
	        private System.Windows.Forms.Label salaryPerHourLabel;
	        private System.Windows.Forms.Label passwordLabel;
	        private GButton AddManagerUser;
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
            private GButton exit_update;
            private System.Windows.Forms.ComboBox DepartmentComboBox;
            private System.Windows.Forms.Label label1;
	    }
	}