﻿namespace newGym
{
    partial class ShiftHandle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelShowShift = new System.Windows.Forms.Panel();
            this.endLabel1 = new System.Windows.Forms.Label();
            this.startLabel1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addShiftPanel = new System.Windows.Forms.Panel();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.ClearShift = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddShift = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.shiftResults = new System.Windows.Forms.DataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.AddStartPicker = new System.Windows.Forms.DateTimePicker();
            this.AddEndPicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panelShowShift.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addShiftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelShowShift);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift Actions";
            // 
            // panelShowShift
            // 
            this.panelShowShift.Controls.Add(this.dateTimePicker4);
            this.panelShowShift.Controls.Add(this.dateTimePicker3);
            this.panelShowShift.Controls.Add(this.endLabel1);
            this.panelShowShift.Controls.Add(this.startLabel1);
            this.panelShowShift.Controls.Add(this.button3);
            this.panelShowShift.Location = new System.Drawing.Point(6, 123);
            this.panelShowShift.Name = "panelShowShift";
            this.panelShowShift.Size = new System.Drawing.Size(227, 130);
            this.panelShowShift.TabIndex = 7;
            this.panelShowShift.Visible = false;
            // 
            // endLabel1
            // 
            this.endLabel1.AutoSize = true;
            this.endLabel1.Location = new System.Drawing.Point(3, 41);
            this.endLabel1.Name = "endLabel1";
            this.endLabel1.Size = new System.Drawing.Size(29, 13);
            this.endLabel1.TabIndex = 6;
            this.endLabel1.Text = "End:";
            // 
            // startLabel1
            // 
            this.startLabel1.AutoSize = true;
            this.startLabel1.Location = new System.Drawing.Point(3, 10);
            this.startLabel1.Name = "startLabel1";
            this.startLabel1.Size = new System.Drawing.Size(32, 13);
            this.startLabel1.TabIndex = 5;
            this.startLabel1.Text = "Start:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Shift";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Shift";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addShiftPanel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.dateTimePicker6);
            this.panel1.Controls.Add(this.dateTimePicker5);
            this.panel1.Controls.Add(this.shiftResults);
            this.panel1.Location = new System.Drawing.Point(270, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 250);
            this.panel1.TabIndex = 1;
            // 
            // addShiftPanel
            // 
            this.addShiftPanel.Controls.Add(this.AddEndPicker);
            this.addShiftPanel.Controls.Add(this.AddStartPicker);
            this.addShiftPanel.Controls.Add(this.departmentComboBox);
            this.addShiftPanel.Controls.Add(this.ClearShift);
            this.addShiftPanel.Controls.Add(this.label4);
            this.addShiftPanel.Controls.Add(this.label3);
            this.addShiftPanel.Controls.Add(this.AddShift);
            this.addShiftPanel.Controls.Add(this.label5);
            this.addShiftPanel.Controls.Add(this.idComboBox);
            this.addShiftPanel.Controls.Add(this.label6);
            this.addShiftPanel.Location = new System.Drawing.Point(150, 28);
            this.addShiftPanel.Name = "addShiftPanel";
            this.addShiftPanel.Size = new System.Drawing.Size(319, 186);
            this.addShiftPanel.TabIndex = 16;
            this.addShiftPanel.Visible = false;
            this.addShiftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Manager",
            "Trainer",
            "Worker"});
            this.departmentComboBox.Location = new System.Drawing.Point(75, 8);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(167, 21);
            this.departmentComboBox.TabIndex = 1;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClearShift
            // 
            this.ClearShift.Location = new System.Drawing.Point(182, 130);
            this.ClearShift.Name = "ClearShift";
            this.ClearShift.Size = new System.Drawing.Size(54, 23);
            this.ClearShift.TabIndex = 15;
            this.ClearShift.Text = "Clear";
            this.ClearShift.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "End:";
            // 
            // AddShift
            // 
            this.AddShift.Location = new System.Drawing.Point(75, 130);
            this.AddShift.Name = "AddShift";
            this.AddShift.Size = new System.Drawing.Size(106, 23);
            this.AddShift.TabIndex = 14;
            this.AddShift.Text = "Add Shift";
            this.AddShift.UseVisualStyleBackColor = true;
            this.AddShift.Click += new System.EventHandler(this.AddShift_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Department:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(75, 35);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(167, 21);
            this.idComboBox.TabIndex = 12;
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-212, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "End:";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-211, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Start:";
            this.label7.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(-161, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Show";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(-162, 158);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker6.TabIndex = 3;
            this.dateTimePicker6.Visible = false;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(-162, 120);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker5.TabIndex = 2;
            this.dateTimePicker5.Visible = false;
            // 
            // shiftResults
            // 
            this.shiftResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftResults.Location = new System.Drawing.Point(56, 0);
            this.shiftResults.Name = "shiftResults";
            this.shiftResults.Size = new System.Drawing.Size(487, 250);
            this.shiftResults.TabIndex = 0;
            // 
            // AddStartPicker
            // 
            this.AddStartPicker.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddStartPicker.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            this.AddStartPicker.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddStartPicker.Location = new System.Drawing.Point(75, 63);
            this.AddStartPicker.Name = "AddStartPicker";
            this.AddStartPicker.Size = new System.Drawing.Size(147, 20);
            this.AddStartPicker.TabIndex = 23;
            this.AddStartPicker.TabStop = false;
            this.AddStartPicker.UseWaitCursor = true;
            // 
            // AddEndPicker
            // 
            this.AddEndPicker.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddEndPicker.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            this.AddEndPicker.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddEndPicker.Location = new System.Drawing.Point(75, 91);
            this.AddEndPicker.Name = "AddEndPicker";
            this.AddEndPicker.Size = new System.Drawing.Size(147, 20);
            this.AddEndPicker.TabIndex = 24;
            this.AddEndPicker.TabStop = false;
            this.AddEndPicker.UseWaitCursor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            this.dateTimePicker3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(41, 10);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker3.TabIndex = 23;
            this.dateTimePicker3.TabStop = false;
            this.dateTimePicker3.UseWaitCursor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            this.dateTimePicker4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(41, 38);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker4.TabIndex = 24;
            this.dateTimePicker4.TabStop = false;
            this.dateTimePicker4.UseWaitCursor = true;
            // 
            // ShiftHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 282);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShiftHandle";
            this.Text = "ShiftHandle";
            this.groupBox1.ResumeLayout(false);
            this.panelShowShift.ResumeLayout(false);
            this.panelShowShift.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addShiftPanel.ResumeLayout(false);
            this.addShiftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label endLabel1;
        private System.Windows.Forms.Label startLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClearShift;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button AddShift;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.DataGridView shiftResults;
        private System.Windows.Forms.Panel panelShowShift;
        private System.Windows.Forms.Panel addShiftPanel;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker AddEndPicker;
        private System.Windows.Forms.DateTimePicker AddStartPicker;
    }
}