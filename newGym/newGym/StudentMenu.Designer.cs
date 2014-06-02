namespace newGym
{
    partial class StudentMenu
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
            this.StudnetClassesCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new newGym.GLabel();
            this.addCourse_panel = new newGym.GPanel();
            this.ClassID = new newGym.GGroupBox();
            this.ClassIDComboBox = new System.Windows.Forms.ComboBox();
            this.ClassDataGrid = new System.Windows.Forms.DataGridView();
            this.AddStudentToClassButton = new newGym.GButton();
            this.EditDetail_panel = new newGym.GPanel();
            this.password_box = new System.Windows.Forms.TextBox();
            this.password_label = new newGym.GLabel();
            this.editDetail_button = new newGym.GButton();
            this.username_box = new System.Windows.Forms.TextBox();
            this.userName_label = new newGym.GLabel();
            this.mail_label = new newGym.GLabel();
            this.lastName_label = new newGym.GLabel();
            this.firstName_label = new newGym.GLabel();
            this.id_label = new newGym.GLabel();
            this.email_box = new System.Windows.Forms.TextBox();
            this.lastname_box = new System.Windows.Forms.TextBox();
            this.firstname_box = new System.Windows.Forms.TextBox();
            this.cancelCourse_panel = new newGym.GPanel();
            this.groupBox1 = new newGym.GGroupBox();
            this.relevantClasses = new System.Windows.Forms.ComboBox();
            this.RemoveStudentFromClassButton = new newGym.GButton();
            this.StudnetClassDataGrid = new System.Windows.Forms.DataGridView();
            this.WelcomeGroupBox = new newGym.GGroupBox();
            this.helloLabel = new newGym.GLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ExercisePannel = new newGym.GPanel();
            this.ExerciseDataGrid = new System.Windows.Forms.DataGridView();
            this.gGroupBox1 = new newGym.GGroupBox();
            this.ExerciseButton = new newGym.GButton();
            this.edit_button = new newGym.GButton();
            this.add_course = new newGym.GButton();
            this.Cancel_course = new newGym.GButton();
            this.addCourse_panel.SuspendLayout();
            this.ClassID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGrid)).BeginInit();
            this.EditDetail_panel.SuspendLayout();
            this.cancelCourse_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudnetClassDataGrid)).BeginInit();
            this.WelcomeGroupBox.SuspendLayout();
            this.ExercisePannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseDataGrid)).BeginInit();
            this.gGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudnetClassesCalendar
            // 
            this.StudnetClassesCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.StudnetClassesCalendar.Location = new System.Drawing.Point(12, 298);
            this.StudnetClassesCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.StudnetClassesCalendar.Name = "StudnetClassesCalendar";
            this.StudnetClassesCalendar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(406, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // addCourse_panel
            // 
            this.addCourse_panel.BackColor = System.Drawing.Color.Transparent;
            this.addCourse_panel.Controls.Add(this.ClassID);
            this.addCourse_panel.Controls.Add(this.ClassDataGrid);
            this.addCourse_panel.Controls.Add(this.AddStudentToClassButton);
            this.addCourse_panel.Location = new System.Drawing.Point(250, 80);
            this.addCourse_panel.Margin = new System.Windows.Forms.Padding(2);
            this.addCourse_panel.Name = "addCourse_panel";
            this.addCourse_panel.Size = new System.Drawing.Size(850, 520);
            this.addCourse_panel.TabIndex = 1;
            // 
            // ClassID
            // 
            this.ClassID.BackColor = System.Drawing.Color.Transparent;
            this.ClassID.Controls.Add(this.ClassIDComboBox);
            this.ClassID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClassID.ForeColor = System.Drawing.Color.Black;
            this.ClassID.Location = new System.Drawing.Point(31, 438);
            this.ClassID.Name = "ClassID";
            this.ClassID.Size = new System.Drawing.Size(150, 67);
            this.ClassID.TabIndex = 8;
            this.ClassID.TabStop = false;
            this.ClassID.Text = "CourseID";
            // 
            // ClassIDComboBox
            // 
            this.ClassIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassIDComboBox.FormattingEnabled = true;
            this.ClassIDComboBox.Location = new System.Drawing.Point(7, 30);
            this.ClassIDComboBox.Name = "ClassIDComboBox";
            this.ClassIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.ClassIDComboBox.TabIndex = 3;
            this.ClassIDComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassIDComboBox_SelectedIndexChanged);
            // 
            // ClassDataGrid
            // 
            this.ClassDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassDataGrid.EnableHeadersVisualStyles = false;
            this.ClassDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClassDataGrid.Location = new System.Drawing.Point(12, 10);
            this.ClassDataGrid.MultiSelect = false;
            this.ClassDataGrid.Name = "ClassDataGrid";
            this.ClassDataGrid.ReadOnly = true;
            this.ClassDataGrid.RowHeadersVisible = false;
            this.ClassDataGrid.Size = new System.Drawing.Size(828, 412);
            this.ClassDataGrid.TabIndex = 6;
            // 
            // AddStudentToClassButton
            // 
            this.AddStudentToClassButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddStudentToClassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddStudentToClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddStudentToClassButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddStudentToClassButton.ForeColor = System.Drawing.Color.White;
            this.AddStudentToClassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudentToClassButton.Location = new System.Drawing.Point(226, 462);
            this.AddStudentToClassButton.Name = "AddStudentToClassButton";
            this.AddStudentToClassButton.Size = new System.Drawing.Size(86, 27);
            this.AddStudentToClassButton.TabIndex = 7;
            this.AddStudentToClassButton.Text = "Add";
            this.AddStudentToClassButton.UseVisualStyleBackColor = false;
            this.AddStudentToClassButton.Click += new System.EventHandler(this.AddStudentToClassButton_Click);
            // 
            // EditDetail_panel
            // 
            this.EditDetail_panel.BackColor = System.Drawing.Color.Transparent;
            this.EditDetail_panel.Controls.Add(this.password_box);
            this.EditDetail_panel.Controls.Add(this.password_label);
            this.EditDetail_panel.Controls.Add(this.editDetail_button);
            this.EditDetail_panel.Controls.Add(this.username_box);
            this.EditDetail_panel.Controls.Add(this.userName_label);
            this.EditDetail_panel.Controls.Add(this.mail_label);
            this.EditDetail_panel.Controls.Add(this.lastName_label);
            this.EditDetail_panel.Controls.Add(this.firstName_label);
            this.EditDetail_panel.Controls.Add(this.id_label);
            this.EditDetail_panel.Controls.Add(this.email_box);
            this.EditDetail_panel.Controls.Add(this.lastname_box);
            this.EditDetail_panel.Controls.Add(this.firstname_box);
            this.EditDetail_panel.Location = new System.Drawing.Point(250, 80);
            this.EditDetail_panel.Margin = new System.Windows.Forms.Padding(2);
            this.EditDetail_panel.Name = "EditDetail_panel";
            this.EditDetail_panel.Size = new System.Drawing.Size(850, 520);
            this.EditDetail_panel.TabIndex = 0;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(152, 205);
            this.password_box.Margin = new System.Windows.Forms.Padding(2);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(180, 22);
            this.password_box.TabIndex = 59;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.Black;
            this.password_label.Location = new System.Drawing.Point(73, 208);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(62, 14);
            this.password_label.TabIndex = 60;
            this.password_label.Text = "Password:";
            // 
            // editDetail_button
            // 
            this.editDetail_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.editDetail_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editDetail_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editDetail_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.editDetail_button.ForeColor = System.Drawing.Color.White;
            this.editDetail_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editDetail_button.Location = new System.Drawing.Point(152, 255);
            this.editDetail_button.Name = "editDetail_button";
            this.editDetail_button.Size = new System.Drawing.Size(91, 37);
            this.editDetail_button.TabIndex = 58;
            this.editDetail_button.Text = "Edit";
            this.editDetail_button.UseVisualStyleBackColor = true;
            this.editDetail_button.Click += new System.EventHandler(this.editDetail_button_Click);
            // 
            // username_box
            // 
            this.username_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.Location = new System.Drawing.Point(150, 173);
            this.username_box.Margin = new System.Windows.Forms.Padding(2);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(180, 22);
            this.username_box.TabIndex = 55;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.BackColor = System.Drawing.Color.Transparent;
            this.userName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.ForeColor = System.Drawing.Color.Black;
            this.userName_label.Location = new System.Drawing.Point(69, 176);
            this.userName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(69, 14);
            this.userName_label.TabIndex = 57;
            this.userName_label.Text = "User name:";
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.BackColor = System.Drawing.Color.Transparent;
            this.mail_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_label.ForeColor = System.Drawing.Color.Black;
            this.mail_label.Location = new System.Drawing.Point(97, 140);
            this.mail_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(38, 14);
            this.mail_label.TabIndex = 56;
            this.mail_label.Text = "Email:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.BackColor = System.Drawing.Color.Transparent;
            this.lastName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_label.ForeColor = System.Drawing.Color.Black;
            this.lastName_label.Location = new System.Drawing.Point(67, 104);
            this.lastName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(67, 14);
            this.lastName_label.TabIndex = 54;
            this.lastName_label.Text = "Last name:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.BackColor = System.Drawing.Color.Transparent;
            this.firstName_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_label.ForeColor = System.Drawing.Color.Black;
            this.firstName_label.Location = new System.Drawing.Point(65, 75);
            this.firstName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(68, 14);
            this.firstName_label.TabIndex = 52;
            this.firstName_label.Text = "First Name:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.Black;
            this.id_label.Location = new System.Drawing.Point(107, 46);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(0, 14);
            this.id_label.TabIndex = 49;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(150, 134);
            this.email_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.email_box.Multiline = true;
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(179, 24);
            this.email_box.TabIndex = 53;
            // 
            // lastname_box
            // 
            this.lastname_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_box.Location = new System.Drawing.Point(148, 98);
            this.lastname_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastname_box.Multiline = true;
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(179, 24);
            this.lastname_box.TabIndex = 51;
            // 
            // firstname_box
            // 
            this.firstname_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_box.Location = new System.Drawing.Point(148, 67);
            this.firstname_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstname_box.Multiline = true;
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(179, 23);
            this.firstname_box.TabIndex = 50;
            // 
            // cancelCourse_panel
            // 
            this.cancelCourse_panel.BackColor = System.Drawing.Color.Transparent;
            this.cancelCourse_panel.Controls.Add(this.groupBox1);
            this.cancelCourse_panel.Controls.Add(this.RemoveStudentFromClassButton);
            this.cancelCourse_panel.Controls.Add(this.StudnetClassDataGrid);
            this.cancelCourse_panel.Location = new System.Drawing.Point(250, 80);
            this.cancelCourse_panel.Margin = new System.Windows.Forms.Padding(2);
            this.cancelCourse_panel.Name = "cancelCourse_panel";
            this.cancelCourse_panel.Size = new System.Drawing.Size(850, 520);
            this.cancelCourse_panel.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.relevantClasses);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(32, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CourseID";
            // 
            // relevantClasses
            // 
            this.relevantClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relevantClasses.FormattingEnabled = true;
            this.relevantClasses.Location = new System.Drawing.Point(8, 26);
            this.relevantClasses.Name = "relevantClasses";
            this.relevantClasses.Size = new System.Drawing.Size(142, 24);
            this.relevantClasses.TabIndex = 3;
            // 
            // RemoveStudentFromClassButton
            // 
            this.RemoveStudentFromClassButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RemoveStudentFromClassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveStudentFromClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveStudentFromClassButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RemoveStudentFromClassButton.ForeColor = System.Drawing.Color.White;
            this.RemoveStudentFromClassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveStudentFromClassButton.Location = new System.Drawing.Point(226, 455);
            this.RemoveStudentFromClassButton.Name = "RemoveStudentFromClassButton";
            this.RemoveStudentFromClassButton.Size = new System.Drawing.Size(86, 27);
            this.RemoveStudentFromClassButton.TabIndex = 7;
            this.RemoveStudentFromClassButton.Text = "Delete";
            this.RemoveStudentFromClassButton.UseVisualStyleBackColor = false;
            this.RemoveStudentFromClassButton.Click += new System.EventHandler(this.RemoveStudentFromClassButton_Click);
            // 
            // StudnetClassDataGrid
            // 
            this.StudnetClassDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudnetClassDataGrid.EnableHeadersVisualStyles = false;
            this.StudnetClassDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StudnetClassDataGrid.Location = new System.Drawing.Point(12, 10);
            this.StudnetClassDataGrid.MultiSelect = false;
            this.StudnetClassDataGrid.Name = "StudnetClassDataGrid";
            this.StudnetClassDataGrid.ReadOnly = true;
            this.StudnetClassDataGrid.RowHeadersVisible = false;
            this.StudnetClassDataGrid.Size = new System.Drawing.Size(828, 412);
            this.StudnetClassDataGrid.TabIndex = 6;
            // 
            // WelcomeGroupBox
            // 
            this.WelcomeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeGroupBox.Controls.Add(this.helloLabel);
            this.WelcomeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WelcomeGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeGroupBox.Location = new System.Drawing.Point(252, 12);
            this.WelcomeGroupBox.Name = "WelcomeGroupBox";
            this.WelcomeGroupBox.Size = new System.Drawing.Size(520, 60);
            this.WelcomeGroupBox.TabIndex = 8;
            this.WelcomeGroupBox.TabStop = false;
            this.WelcomeGroupBox.Text = "Welcome";
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.BackColor = System.Drawing.Color.Transparent;
            this.helloLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.helloLabel.ForeColor = System.Drawing.Color.Black;
            this.helloLabel.Location = new System.Drawing.Point(6, 30);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(184, 16);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "WILL BE FILLED IN RUNTIME";
            // 
            // ExercisePannel
            // 
            this.ExercisePannel.BackColor = System.Drawing.Color.Transparent;
            this.ExercisePannel.Controls.Add(this.ExerciseDataGrid);
            this.ExercisePannel.Location = new System.Drawing.Point(250, 80);
            this.ExercisePannel.Name = "ExercisePannel";
            this.ExercisePannel.Size = new System.Drawing.Size(850, 520);
            this.ExercisePannel.TabIndex = 10;
            // 
            // ExerciseDataGrid
            // 
            this.ExerciseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExerciseDataGrid.Location = new System.Drawing.Point(10, 10);
            this.ExerciseDataGrid.Margin = new System.Windows.Forms.Padding(10);
            this.ExerciseDataGrid.Name = "ExerciseDataGrid";
            this.ExerciseDataGrid.Size = new System.Drawing.Size(830, 500);
            this.ExerciseDataGrid.TabIndex = 0;
            // 
            // gGroupBox1
            // 
            this.gGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gGroupBox1.Controls.Add(this.ExerciseButton);
            this.gGroupBox1.Controls.Add(this.edit_button);
            this.gGroupBox1.Controls.Add(this.add_course);
            this.gGroupBox1.Controls.Add(this.Cancel_course);
            this.gGroupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.gGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gGroupBox1.Name = "gGroupBox1";
            this.gGroupBox1.Size = new System.Drawing.Size(231, 276);
            this.gGroupBox1.TabIndex = 7;
            this.gGroupBox1.TabStop = false;
            this.gGroupBox1.Text = "Actions";
            // 
            // ExerciseButton
            // 
            this.ExerciseButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ExerciseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExerciseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExerciseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExerciseButton.ForeColor = System.Drawing.Color.White;
            this.ExerciseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExerciseButton.Location = new System.Drawing.Point(56, 210);
            this.ExerciseButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExerciseButton.Name = "ExerciseButton";
            this.ExerciseButton.Size = new System.Drawing.Size(118, 38);
            this.ExerciseButton.TabIndex = 6;
            this.ExerciseButton.Text = "Exercise";
            this.ExerciseButton.UseVisualStyleBackColor = true;
            this.ExerciseButton.Click += new System.EventHandler(this.ExerciseButton_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Image = global::newGym.Properties.Resources._1399410331_document_edit;
            this.edit_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_button.Location = new System.Drawing.Point(55, 39);
            this.edit_button.Margin = new System.Windows.Forms.Padding(2);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(118, 36);
            this.edit_button.TabIndex = 0;
            this.edit_button.Text = "  Edit details";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_course
            // 
            this.add_course.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add_course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_course.ForeColor = System.Drawing.Color.White;
            this.add_course.Image = global::newGym.Properties.Resources._1399410268_add;
            this.add_course.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_course.Location = new System.Drawing.Point(55, 96);
            this.add_course.Margin = new System.Windows.Forms.Padding(2);
            this.add_course.Name = "add_course";
            this.add_course.Size = new System.Drawing.Size(118, 36);
            this.add_course.TabIndex = 2;
            this.add_course.Text = "  Add course";
            this.add_course.UseVisualStyleBackColor = true;
            this.add_course.Click += new System.EventHandler(this.add_course_Click);
            // 
            // Cancel_course
            // 
            this.Cancel_course.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Cancel_course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cancel_course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Cancel_course.ForeColor = System.Drawing.Color.White;
            this.Cancel_course.Image = global::newGym.Properties.Resources._1399410901_trash;
            this.Cancel_course.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_course.Location = new System.Drawing.Point(55, 154);
            this.Cancel_course.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_course.Name = "Cancel_course";
            this.Cancel_course.Size = new System.Drawing.Size(118, 38);
            this.Cancel_course.TabIndex = 5;
            this.Cancel_course.Text = "   Cancel class";
            this.Cancel_course.UseVisualStyleBackColor = true;
            this.Cancel_course.Click += new System.EventHandler(this.Cancel_course_Click);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 634);
            this.Controls.Add(this.WelcomeGroupBox);
            this.Controls.Add(this.gGroupBox1);
            this.Controls.Add(this.StudnetClassesCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCourse_panel);
            this.Controls.Add(this.cancelCourse_panel);
            this.Controls.Add(this.EditDetail_panel);
            this.Controls.Add(this.ExercisePannel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.addCourse_panel.ResumeLayout(false);
            this.ClassID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGrid)).EndInit();
            this.EditDetail_panel.ResumeLayout(false);
            this.EditDetail_panel.PerformLayout();
            this.cancelCourse_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudnetClassDataGrid)).EndInit();
            this.WelcomeGroupBox.ResumeLayout(false);
            this.WelcomeGroupBox.PerformLayout();
            this.ExercisePannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseDataGrid)).EndInit();
            this.gGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GButton edit_button;
        private System.Windows.Forms.MonthCalendar StudnetClassesCalendar;
        private GButton add_course;
        private GLabel label1;
        private GButton Cancel_course;
        private GPanel addCourse_panel;
        private GPanel EditDetail_panel;
        private GGroupBox gGroupBox1;
        private GGroupBox WelcomeGroupBox;
        private GLabel helloLabel;
        private GButton editDetail_button;
        private System.Windows.Forms.TextBox username_box;
        private GLabel userName_label;
        private GLabel mail_label;
        private GLabel lastName_label;
        private GLabel firstName_label;
        private GLabel id_label;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox lastname_box;
        private System.Windows.Forms.TextBox firstname_box;
        private System.Windows.Forms.TextBox password_box;
        private GLabel password_label;
        private GPanel cancelCourse_panel;
        private GGroupBox ClassID;
        private System.Windows.Forms.ComboBox ClassIDComboBox;
        private System.Windows.Forms.DataGridView ClassDataGrid;
        private GButton AddStudentToClassButton;
        private GGroupBox groupBox1;
        private System.Windows.Forms.ComboBox relevantClasses;
        private GButton RemoveStudentFromClassButton;
        private System.Windows.Forms.DataGridView StudnetClassDataGrid;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private GPanel ExercisePannel;
        private System.Windows.Forms.DataGridView ExerciseDataGrid;
        private GButton ExerciseButton;
    }
}