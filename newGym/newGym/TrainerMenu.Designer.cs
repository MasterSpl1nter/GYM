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
<<<<<<< HEAD
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.tothourLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roomNumLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ParticiLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
=======
            this.scheduleBox = new System.Windows.Forms.GroupBox();
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.endtimeLabel = new System.Windows.Forms.Label();
            this.starttimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.GuideSearch = new System.Windows.Forms.TextBox();
=======
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.TrainerSearch = new System.Windows.Forms.TextBox();
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.StudSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.loggedLabel = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
=======
            this.informationBox = new System.Windows.Forms.GroupBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.actionsBox = new System.Windows.Forms.GroupBox();
            this.viewbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.scheduleBox.SuspendLayout();
            this.searchBox.SuspendLayout();
            this.informationBox.SuspendLayout();
            this.actionsBox.SuspendLayout();
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
<<<<<<< HEAD
            this.monthCalendar1.Location = new System.Drawing.Point(187, 25);
=======
            this.monthCalendar1.Location = new System.Drawing.Point(19, 25);
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
<<<<<<< HEAD
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.endtimeLabel);
            this.groupBox1.Controls.Add(this.starttimeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(20, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 218);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class schedule";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 50;
            this.hScrollBar1.Location = new System.Drawing.Point(20, 183);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(158, 17);
            this.hScrollBar1.SmallChange = 50;
            this.hScrollBar1.TabIndex = 21;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.92453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.07547F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tothourLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.paymentLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.roomNumLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ParticiLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.idLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 123);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total time:";
            // 
            // tothourLabel
            // 
            this.tothourLabel.AutoSize = true;
            this.tothourLabel.Location = new System.Drawing.Point(110, 100);
            this.tothourLabel.Name = "tothourLabel";
            this.tothourLabel.Size = new System.Drawing.Size(0, 13);
            this.tothourLabel.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Payment:";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(110, 80);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(0, 13);
            this.paymentLabel.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Room #:";
            // 
            // roomNumLabel
            // 
            this.roomNumLabel.AutoSize = true;
            this.roomNumLabel.Location = new System.Drawing.Point(110, 60);
            this.roomNumLabel.Name = "roomNumLabel";
            this.roomNumLabel.Size = new System.Drawing.Size(0, 13);
            this.roomNumLabel.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Num of participants:";
            // 
            // ParticiLabel
            // 
            this.ParticiLabel.AutoSize = true;
            this.ParticiLabel.Location = new System.Drawing.Point(110, 40);
            this.ParticiLabel.Name = "ParticiLabel";
            this.ParticiLabel.Size = new System.Drawing.Size(0, 13);
            this.ParticiLabel.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Class name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(110, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Class ID:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(110, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 13);
            this.idLabel.TabIndex = 28;
=======
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
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            // 
            // endtimeLabel
            // 
            this.endtimeLabel.AutoSize = true;
<<<<<<< HEAD
            this.endtimeLabel.Location = new System.Drawing.Point(393, 187);
=======
            this.endtimeLabel.Location = new System.Drawing.Point(225, 187);
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.endtimeLabel.Name = "endtimeLabel";
            this.endtimeLabel.Size = new System.Drawing.Size(0, 13);
            this.endtimeLabel.TabIndex = 16;
            // 
            // starttimeLabel
            // 
            this.starttimeLabel.AutoSize = true;
<<<<<<< HEAD
            this.starttimeLabel.Location = new System.Drawing.Point(230, 187);
=======
            this.starttimeLabel.Location = new System.Drawing.Point(62, 187);
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.starttimeLabel.Name = "starttimeLabel";
            this.starttimeLabel.Size = new System.Drawing.Size(0, 13);
            this.starttimeLabel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(367, 187);
=======
            this.label2.Location = new System.Drawing.Point(199, 187);
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(191, 187);
=======
            this.label1.Location = new System.Drawing.Point(23, 187);
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "From:";
            // 
<<<<<<< HEAD
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioName);
            this.groupBox2.Controls.Add(this.radioID);
            this.groupBox2.Controls.Add(this.GuideSearch);
            this.groupBox2.Controls.Add(this.StudSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(183, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 127);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
=======
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
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
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
            this.radioName.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
<<<<<<< HEAD
            // GuideSearch
            // 
            this.GuideSearch.Location = new System.Drawing.Point(70, 78);
            this.GuideSearch.Name = "GuideSearch";
            this.GuideSearch.Size = new System.Drawing.Size(100, 20);
            this.GuideSearch.TabIndex = 5;
=======
            // TrainerSearch
            // 
            this.TrainerSearch.Location = new System.Drawing.Point(70, 78);
            this.TrainerSearch.Name = "TrainerSearch";
            this.TrainerSearch.Size = new System.Drawing.Size(100, 20);
            this.TrainerSearch.TabIndex = 5;
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            // 
            // StudSearch
            // 
            this.StudSearch.Location = new System.Drawing.Point(70, 34);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // loggedLabel
            // 
            this.loggedLabel.AutoSize = true;
            this.loggedLabel.Location = new System.Drawing.Point(83, 23);
            this.loggedLabel.Name = "loggedLabel";
            this.loggedLabel.Size = new System.Drawing.Size(0, 13);
            this.loggedLabel.TabIndex = 16;
            // 
<<<<<<< HEAD
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.loggedLabel);
            this.groupBox3.Location = new System.Drawing.Point(20, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 50);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
=======
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
            this.informationBox.Enter += new System.EventHandler(this.groupBox3_Enter);
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
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
<<<<<<< HEAD
=======
            // actionsBox
            // 
            this.actionsBox.Controls.Add(this.button4);
            this.actionsBox.Controls.Add(this.viewbutton);
            this.actionsBox.Controls.Add(this.button3);
            this.actionsBox.Location = new System.Drawing.Point(20, 69);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(157, 126);
            this.actionsBox.TabIndex = 18;
            this.actionsBox.TabStop = false;
            this.actionsBox.Text = "Actions";
            // 
            // viewbutton
            // 
            this.viewbutton.Location = new System.Drawing.Point(32, 26);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(91, 23);
            this.viewbutton.TabIndex = 0;
            this.viewbutton.Text = "View Applience";
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            // TrainerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 436);
<<<<<<< HEAD
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrainerMenu";
            this.Text = "TrainerMenu";
            this.Load += new System.EventHandler(this.TrainerMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
=======
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.scheduleBox);
            this.Name = "TrainerMenu";
            this.Text = "TrainerMenu";
            this.Load += new System.EventHandler(this.TrainerMenu_Load);
            this.scheduleBox.ResumeLayout(false);
            this.scheduleBox.PerformLayout();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            this.informationBox.ResumeLayout(false);
            this.informationBox.PerformLayout();
            this.actionsBox.ResumeLayout(false);
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
<<<<<<< HEAD
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ParticiLabel;
        private System.Windows.Forms.Label roomNumLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label tothourLabel;
=======
        private System.Windows.Forms.GroupBox scheduleBox;
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        private System.Windows.Forms.Label endtimeLabel;
        private System.Windows.Forms.Label starttimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox GuideSearch;
=======
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.TextBox TrainerSearch;
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        private System.Windows.Forms.TextBox StudSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loggedLabel;
<<<<<<< HEAD
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
=======
        private System.Windows.Forms.GroupBox informationBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox actionsBox;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
    }
}