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
            this.scheduleBox = new System.Windows.Forms.GroupBox();
            this.endtimeLabel = new System.Windows.Forms.Label();
            this.starttimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.TrainerSearch = new System.Windows.Forms.TextBox();
            this.StudSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new GButton();
            this.label6 = new System.Windows.Forms.Label();
            this.loggedLabel = new System.Windows.Forms.Label();
            this.informationBox = new System.Windows.Forms.GroupBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.actionsBox = new System.Windows.Forms.GroupBox();
            this.training_to_student_button = new GButton();
            this.viewbutton = new GButton();
            this.addtraining_button = new GButton();
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
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // scheduleBox
            // 
            this.scheduleBox.Controls.Add(this.endtimeLabel);
            this.scheduleBox.Controls.Add(this.starttimeLabel);
            this.scheduleBox.Controls.Add(this.label2);
            this.scheduleBox.Controls.Add(this.label1);
            this.scheduleBox.Controls.Add(this.monthCalendar1);
            this.scheduleBox.Location = new System.Drawing.Point(183, 201);
            this.scheduleBox.Name = "scheduleBox";
            this.scheduleBox.Size = new System.Drawing.Size(301, 224);
            this.scheduleBox.TabIndex = 13;
            this.scheduleBox.TabStop = false;
            this.scheduleBox.Text = "Schedule";
            // 
            // endtimeLabel
            // 
            this.endtimeLabel.AutoSize = true;
            this.endtimeLabel.Location = new System.Drawing.Point(225, 187);
            this.endtimeLabel.Name = "endtimeLabel";
            this.endtimeLabel.Size = new System.Drawing.Size(0, 13);
            this.endtimeLabel.TabIndex = 16;
            // 
            // starttimeLabel
            // 
            this.starttimeLabel.AutoSize = true;
            this.starttimeLabel.Location = new System.Drawing.Point(62, 187);
            this.starttimeLabel.Name = "starttimeLabel";
            this.starttimeLabel.Size = new System.Drawing.Size(0, 13);
            this.starttimeLabel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "From:";
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.radioName);
            this.searchBox.Controls.Add(this.radioID);
            this.searchBox.Controls.Add(this.TrainerSearch);
            this.searchBox.Controls.Add(this.StudSearch);
            this.searchBox.Controls.Add(this.label4);
            this.searchBox.Controls.Add(this.label3);
            this.searchBox.Controls.Add(this.button1);
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
            this.radioName.Size = new System.Drawing.Size(66, 17);
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
            this.radioID.Size = new System.Drawing.Size(51, 17);
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
            this.TrainerSearch.Size = new System.Drawing.Size(100, 20);
            this.TrainerSearch.TabIndex = 5;
            // 
            // StudSearch
            // 
            this.StudSearch.Location = new System.Drawing.Point(70, 34);
            this.StudSearch.MaxLength = 29;
            this.StudSearch.Name = "StudSearch";
            this.StudSearch.Size = new System.Drawing.Size(100, 20);
            this.StudSearch.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trainer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student:";
            // 
            // button1
            // 
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
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Logged in as:";
            // 
            // loggedLabel
            // 
            this.loggedLabel.AutoSize = true;
            this.loggedLabel.Location = new System.Drawing.Point(83, 23);
            this.loggedLabel.Name = "loggedLabel";
            this.loggedLabel.Size = new System.Drawing.Size(0, 13);
            this.loggedLabel.TabIndex = 16;
            // 
            // informationBox
            // 
            this.informationBox.Controls.Add(this.dateLabel);
            this.informationBox.Controls.Add(this.label6);
            this.informationBox.Controls.Add(this.loggedLabel);
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
            this.dateLabel.Location = new System.Drawing.Point(346, 23);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // actionsBox
            // 
            this.actionsBox.Controls.Add(this.training_to_student_button);
            this.actionsBox.Controls.Add(this.viewbutton);
            this.actionsBox.Controls.Add(this.addtraining_button);
            this.actionsBox.Location = new System.Drawing.Point(20, 69);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(157, 126);
            this.actionsBox.TabIndex = 18;
            this.actionsBox.TabStop = false;
            this.actionsBox.Text = "Actions";
            // 
            // training_to_student_button
            // 
            this.training_to_student_button.Image = global::newGym.Properties.Resources._1399410268_add;
            this.training_to_student_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.training_to_student_button.Location = new System.Drawing.Point(23, 79);
            this.training_to_student_button.Name = "training_to_student_button";
            this.training_to_student_button.Size = new System.Drawing.Size(106, 35);
            this.training_to_student_button.TabIndex = 2;
            this.training_to_student_button.Text = "Add Training to Student";
            this.training_to_student_button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.training_to_student_button.UseVisualStyleBackColor = true;
            this.training_to_student_button.Click += new System.EventHandler(this.training_to_student_button_Click);
            // 
            // viewbutton
            // 
            this.viewbutton.Image = global::newGym.Properties.Resources._1399410141_folder_search;
            this.viewbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewbutton.Location = new System.Drawing.Point(23, 21);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(106, 23);
            this.viewbutton.TabIndex = 0;
            this.viewbutton.Text = "View Applience";
            this.viewbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // addtraining_button
            // 
            this.addtraining_button.Image = global::newGym.Properties.Resources._1399410268_add;
            this.addtraining_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addtraining_button.Location = new System.Drawing.Point(23, 50);
            this.addtraining_button.Name = "addtraining_button";
            this.addtraining_button.Size = new System.Drawing.Size(106, 23);
            this.addtraining_button.TabIndex = 1;
            this.addtraining_button.Text = "Add Training";
            this.addtraining_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addtraining_button.UseVisualStyleBackColor = true;
            this.addtraining_button.Click += new System.EventHandler(this.addtraining_button_Click);
            // 
            // TrainerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 436);
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
        private System.Windows.Forms.GroupBox scheduleBox;
        private System.Windows.Forms.Label endtimeLabel;
        private System.Windows.Forms.Label starttimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.TextBox TrainerSearch;
        private System.Windows.Forms.TextBox StudSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loggedLabel;
        private System.Windows.Forms.GroupBox informationBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox actionsBox;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Button addtraining_button;
        private System.Windows.Forms.Button training_to_student_button;
    }
}