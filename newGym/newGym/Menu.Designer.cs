namespace newGym
{
    partial class ManagerMenu
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
            this.groupBox2 = new newGym.GGroupBox();
            this.search = new newGym.GButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new newGym.GGroupBox();
            this.helloLabel = new newGym.GLabel();
            this.groupBox1 = new newGym.GGroupBox();
            this.endtimeLabel = new newGym.GLabel();
            this.starttimeLabel = new newGym.GLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ManagerActions = new newGym.GGroupBox();
            this.button26 = new newGym.GButton();
            this.button25 = new newGym.GButton();
            this.classHandleBtn = new newGym.GButton();
            this.button23 = new newGym.GButton();
            this.addWorkerBtn = new newGym.GButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ManagerActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(218, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.LightSkyBlue;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Image = global::newGym.Properties.Resources._1399410141_folder_search;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(174, 35);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "   Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(20, 36);
            this.searchTextBox.MaxLength = 29;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(131, 22);
            this.searchTextBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.helloLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 87);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.BackColor = System.Drawing.Color.Transparent;
            this.helloLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.helloLabel.ForeColor = System.Drawing.Color.Black;
            this.helloLabel.Location = new System.Drawing.Point(6, 16);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(56, 19);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "Hello, ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.endtimeLabel);
            this.groupBox1.Controls.Add(this.starttimeLabel);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(216, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 222);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class schedule";
            // 
            // endtimeLabel
            // 
            this.endtimeLabel.AutoSize = true;
            this.endtimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.endtimeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.endtimeLabel.ForeColor = System.Drawing.Color.Black;
            this.endtimeLabel.Location = new System.Drawing.Point(460, 193);
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
            this.starttimeLabel.Location = new System.Drawing.Point(297, 193);
            this.starttimeLabel.Name = "starttimeLabel";
            this.starttimeLabel.Size = new System.Drawing.Size(0, 16);
            this.starttimeLabel.TabIndex = 15;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 37);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // ManagerActions
            // 
            this.ManagerActions.BackColor = System.Drawing.Color.Transparent;
            this.ManagerActions.Controls.Add(this.button26);
            this.ManagerActions.Controls.Add(this.button25);
            this.ManagerActions.Controls.Add(this.classHandleBtn);
            this.ManagerActions.Controls.Add(this.button23);
            this.ManagerActions.Controls.Add(this.addWorkerBtn);
            this.ManagerActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ManagerActions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManagerActions.Location = new System.Drawing.Point(12, 119);
            this.ManagerActions.Name = "ManagerActions";
            this.ManagerActions.Size = new System.Drawing.Size(200, 222);
            this.ManagerActions.TabIndex = 16;
            this.ManagerActions.TabStop = false;
            this.ManagerActions.Text = "Actions";
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Image = global::newGym.Properties.Resources._1399410268_add;
            this.button26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button26.Location = new System.Drawing.Point(15, 89);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(158, 24);
            this.button26.TabIndex = 5;
            this.button26.Text = "Add Room";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Image = global::newGym.Properties.Resources._1400176769_applications_engineering;
            this.button25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button25.Location = new System.Drawing.Point(15, 119);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(158, 24);
            this.button25.TabIndex = 4;
            this.button25.Text = "Shifts Handle";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // classHandleBtn
            // 
            this.classHandleBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.classHandleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.classHandleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classHandleBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.classHandleBtn.ForeColor = System.Drawing.Color.White;
            this.classHandleBtn.Image = global::newGym.Properties.Resources._1400183369_participation_rate;
            this.classHandleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classHandleBtn.Location = new System.Drawing.Point(15, 152);
            this.classHandleBtn.Name = "classHandleBtn";
            this.classHandleBtn.Size = new System.Drawing.Size(158, 26);
            this.classHandleBtn.TabIndex = 3;
            this.classHandleBtn.Text = "Class Handle";
            this.classHandleBtn.UseVisualStyleBackColor = false;
            this.classHandleBtn.Click += new System.EventHandler(this.classHandleBtn_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Image = global::newGym.Properties.Resources._1399410268_add;
            this.button23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button23.Location = new System.Drawing.Point(15, 59);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(158, 24);
            this.button23.TabIndex = 1;
            this.button23.Text = "Add Student";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // addWorkerBtn
            // 
            this.addWorkerBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addWorkerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addWorkerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addWorkerBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addWorkerBtn.ForeColor = System.Drawing.Color.White;
            this.addWorkerBtn.Image = global::newGym.Properties.Resources._1399410268_add;
            this.addWorkerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWorkerBtn.Location = new System.Drawing.Point(15, 28);
            this.addWorkerBtn.Name = "addWorkerBtn";
            this.addWorkerBtn.Size = new System.Drawing.Size(158, 26);
            this.addWorkerBtn.TabIndex = 0;
            this.addWorkerBtn.Text = "Add Worker";
            this.addWorkerBtn.UseVisualStyleBackColor = false;
            this.addWorkerBtn.Click += new System.EventHandler(this.addWorkerBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ManagerActions);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ManagerMenu";
            this.Text = "managerMenu";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ManagerActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GGroupBox groupBox2;
        private GButton search;
        private System.Windows.Forms.TextBox searchTextBox;
        private GGroupBox groupBox3;
        private GLabel helloLabel;
        private GGroupBox groupBox1;
        private GLabel endtimeLabel;
        private GLabel starttimeLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private GGroupBox ManagerActions;
        private GButton button23;
        private GButton addWorkerBtn;
        private GButton classHandleBtn;
        private GButton button25;
        private GButton button26;
        private System.Windows.Forms.Timer timer1;
    }
}