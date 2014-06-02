namespace newGym
{
    partial class TrainerMenu
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
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.scheduleBox = new newGym.GGroupBox();
            this.endtimeLabel = new newGym.GLabel();
            this.starttimeLabel = new newGym.GLabel();
            this.label2 = new newGym.GLabel();
            this.label1 = new newGym.GLabel();
            this.searchBox = new newGym.GGroupBox();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.TrainerSearch = new System.Windows.Forms.TextBox();
            this.StudSearch = new System.Windows.Forms.TextBox();
            this.label4 = new newGym.GLabel();
            this.label3 = new newGym.GLabel();
            this.button1 = new newGym.GButton();
            this.label6 = new newGym.GLabel();
            this.loggedLabel = new newGym.GLabel();
            this.informationBox = new newGym.GGroupBox();
            this.dateLabel = new newGym.GLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.actionsBox = new newGym.GGroupBox();
            this.training_to_student_button = new newGym.GButton();
            this.viewbutton = new newGym.GButton();
            this.addtraining_button = new newGym.GButton();
            this.scheduleBox.SuspendLayout();
            this.searchBox.SuspendLayout();
            this.informationBox.SuspendLayout();
            this.actionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(19, 25);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // scheduleBox
            // 
            this.scheduleBox.BackColor = System.Drawing.Color.Transparent;
            this.scheduleBox.Controls.Add(this.endtimeLabel);
            this.scheduleBox.Controls.Add(this.starttimeLabel);
            this.scheduleBox.Controls.Add(this.label2);
            this.scheduleBox.Controls.Add(this.label1);
            this.scheduleBox.Controls.Add(this.monthCalendar1);
            this.scheduleBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.scheduleBox.ForeColor = System.Drawing.Color.Black;
            this.scheduleBox.Location = new System.Drawing.Point(183, 201);
            this.scheduleBox.Name = "scheduleBox";
            this.scheduleBox.Size = new System.Drawing.Size(301, 224);
            this.scheduleBox.TabIndex = 13;
            this.scheduleBox.TabStop = false;
            this.scheduleBox.Visible = false;
            // 
            // endtimeLabel
            // 
            this.endtimeLabel.AutoSize = true;
            this.endtimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.endtimeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.endtimeLabel.ForeColor = System.Drawing.Color.Black;
            this.endtimeLabel.Location = new System.Drawing.Point(225, 187);
            this.endtimeLabel.Name = "endtimeLabel";
            this.endtimeLabel.Size = new System.Drawing.Size(0, 16);
            this.endtimeLabel.TabIndex = 16;
            // 
            // starttimeLabel
            // 
            this.starttimeLabel.AutoSize = true;
            this.starttimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.starttimeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.starttimeLabel.ForeColor = System.Drawing.Color.Black;
            this.starttimeLabel.Location = new System.Drawing.Point(62, 187);
            this.starttimeLabel.Name = "starttimeLabel";
            this.starttimeLabel.Size = new System.Drawing.Size(0, 16);
            this.starttimeLabel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(199, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "From:";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.Controls.Add(this.radioName);
            this.searchBox.Controls.Add(this.radioID);
            this.searchBox.Controls.Add(this.TrainerSearch);
            this.searchBox.Controls.Add(this.StudSearch);
            this.searchBox.Controls.Add(this.label4);
            this.searchBox.Controls.Add(this.label3);
            this.searchBox.Controls.Add(this.button1);
            this.searchBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.Location = new System.Drawing.Point(183, 68);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(301, 127);
            this.searchBox.TabIndex = 14;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search";
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Location = new System.Drawing.Point(204, 54);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(82, 20);
            this.radioName.TabIndex = 7;
            this.radioName.Text = "By name";
            this.radioName.UseVisualStyleBackColor = true;
            // 
            // radioID
            // 
            this.radioID.AutoSize = true;
            this.radioID.Checked = true;
            this.radioID.Location = new System.Drawing.Point(204, 30);
            this.radioID.Name = "radioID";
            this.radioID.Size = new System.Drawing.Size(59, 20);
            this.radioID.TabIndex = 6;
            this.radioID.TabStop = true;
            this.radioID.Text = "By ID";
            this.radioID.UseVisualStyleBackColor = true;
            // 
            // TrainerSearch
            // 
            this.TrainerSearch.Location = new System.Drawing.Point(70, 78);
            this.TrainerSearch.MaxLength = 29;
            this.TrainerSearch.Name = "TrainerSearch";
            this.TrainerSearch.Size = new System.Drawing.Size(100, 22);
            this.TrainerSearch.TabIndex = 5;
            // 
            // StudSearch
            // 
            this.StudSearch.Location = new System.Drawing.Point(70, 34);
            this.StudSearch.MaxLength = 29;
            this.StudSearch.Name = "StudSearch";
            this.StudSearch.Size = new System.Drawing.Size(100, 22);
            this.StudSearch.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trainer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(195, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Logged in as:";
            // 
            // loggedLabel
            // 
            this.loggedLabel.AutoSize = true;
            this.loggedLabel.BackColor = System.Drawing.Color.Transparent;
            this.loggedLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loggedLabel.ForeColor = System.Drawing.Color.Black;
            this.loggedLabel.Location = new System.Drawing.Point(83, 23);
            this.loggedLabel.Name = "loggedLabel";
            this.loggedLabel.Size = new System.Drawing.Size(0, 16);
            this.loggedLabel.TabIndex = 16;
            // 
            // informationBox
            // 
            this.informationBox.BackColor = System.Drawing.Color.Transparent;
            this.informationBox.Controls.Add(this.dateLabel);
            this.informationBox.Controls.Add(this.label6);
            this.informationBox.Controls.Add(this.loggedLabel);
            this.informationBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.informationBox.ForeColor = System.Drawing.Color.Black;
            this.informationBox.Location = new System.Drawing.Point(20, 12);
            this.informationBox.Name = "informationBox";
            this.informationBox.Size = new System.Drawing.Size(464, 50);
            this.informationBox.TabIndex = 17;
            this.informationBox.TabStop = false;
            this.informationBox.Text = "Information";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(346, 23);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 16);
            this.dateLabel.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // actionsBox
            // 
            this.actionsBox.BackColor = System.Drawing.Color.Transparent;
            this.actionsBox.Controls.Add(this.training_to_student_button);
            this.actionsBox.Controls.Add(this.viewbutton);
            this.actionsBox.Controls.Add(this.addtraining_button);
            this.actionsBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.actionsBox.ForeColor = System.Drawing.Color.Black;
            this.actionsBox.Location = new System.Drawing.Point(20, 69);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(157, 126);
            this.actionsBox.TabIndex = 18;
            this.actionsBox.TabStop = false;
            this.actionsBox.Text = "Actions";
            // 
            // training_to_student_button
            // 
            this.training_to_student_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.training_to_student_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.training_to_student_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.training_to_student_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.training_to_student_button.ForeColor = System.Drawing.Color.White;
            this.training_to_student_button.Image = global::newGym.Properties.Resources._1399410268_add;
            this.training_to_student_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.training_to_student_button.Location = new System.Drawing.Point(23, 83);
            this.training_to_student_button.Name = "training_to_student_button";
            this.training_to_student_button.Size = new System.Drawing.Size(106, 23);
            this.training_to_student_button.TabIndex = 2;
            this.training_to_student_button.Text = "Student training";
            this.training_to_student_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.training_to_student_button.UseVisualStyleBackColor = true;
            this.training_to_student_button.Click += new System.EventHandler(this.training_to_student_button_Click);
            // 
            // viewbutton
            // 
            this.viewbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewbutton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viewbutton.ForeColor = System.Drawing.Color.White;
            this.viewbutton.Image = global::newGym.Properties.Resources._1399410141_folder_search;
            this.viewbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewbutton.Location = new System.Drawing.Point(23, 25);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(106, 23);
            this.viewbutton.TabIndex = 0;
            this.viewbutton.Text = "View Appliance";
            this.viewbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // addtraining_button
            // 
            this.addtraining_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addtraining_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addtraining_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addtraining_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addtraining_button.ForeColor = System.Drawing.Color.White;
            this.addtraining_button.Image = global::newGym.Properties.Resources._1399410268_add;
            this.addtraining_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addtraining_button.Location = new System.Drawing.Point(23, 54);
            this.addtraining_button.Name = "addtraining_button";
            this.addtraining_button.Size = new System.Drawing.Size(106, 23);
            this.addtraining_button.TabIndex = 1;
            this.addtraining_button.Text = "Add Training";
            this.addtraining_button.UseVisualStyleBackColor = true;
            this.addtraining_button.Click += new System.EventHandler(this.addtraining_button_Click);
            // 
            // TrainerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 210);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.scheduleBox);
            this.Name = "TrainerMenu";
            this.Text = "TrainerMenu";
            this.scheduleBox.ResumeLayout(false);
            this.scheduleBox.PerformLayout();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            this.informationBox.ResumeLayout(false);
            this.informationBox.PerformLayout();
            this.actionsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private GGroupBox scheduleBox;
        private GLabel endtimeLabel;
        private GLabel starttimeLabel;
        private GLabel label2;
        private GLabel label1;
        private GGroupBox searchBox;
        private System.Windows.Forms.TextBox TrainerSearch;
        private System.Windows.Forms.TextBox StudSearch;
        private GLabel label4;
        private GLabel label3;
        private GButton button1;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioID;
        private GLabel label6;
        private GLabel loggedLabel;
        private GGroupBox informationBox;
        private GLabel dateLabel;
        private System.Windows.Forms.Timer timer1;
        private GGroupBox actionsBox;
        private GButton viewbutton;
        private GButton addtraining_button;
        private GButton training_to_student_button;
    }
}