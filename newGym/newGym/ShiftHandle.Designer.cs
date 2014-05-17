namespace newGym
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.showStartPicker = new System.Windows.Forms.DateTimePicker();
            this.showEndPicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.startLabel1 = new System.Windows.Forms.Label();
            this.endLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shiftResults = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelShowShift = new System.Windows.Forms.Panel();
            this.addShiftPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftResults)).BeginInit();
            this.panelShowShift.SuspendLayout();
            this.addShiftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelShowShift);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift Actions";
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
            // showStartPicker
            // 
            this.showStartPicker.Location = new System.Drawing.Point(38, 10);
            this.showStartPicker.Name = "showStartPicker";
            this.showStartPicker.Size = new System.Drawing.Size(133, 20);
            this.showStartPicker.TabIndex = 2;
            // 
            // showEndPicker
            // 
            this.showEndPicker.Location = new System.Drawing.Point(38, 41);
            this.showEndPicker.Name = "showEndPicker";
            this.showEndPicker.Size = new System.Drawing.Size(133, 20);
            this.showEndPicker.TabIndex = 3;
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
            // startLabel1
            // 
            this.startLabel1.AutoSize = true;
            this.startLabel1.Location = new System.Drawing.Point(3, 10);
            this.startLabel1.Name = "startLabel1";
            this.startLabel1.Size = new System.Drawing.Size(32, 13);
            this.startLabel1.TabIndex = 5;
            this.startLabel1.Text = "Start:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.addShiftPanel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.dateTimePicker6);
            this.panel1.Controls.Add(this.dateTimePicker5);
            this.panel1.Controls.Add(this.shiftResults);
            this.panel1.Location = new System.Drawing.Point(234, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 250);
            this.panel1.TabIndex = 1;
            // 
            // shiftResults
            // 
            this.shiftResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shiftResults.Location = new System.Drawing.Point(0, 0);
            this.shiftResults.Name = "shiftResults";
            this.shiftResults.Size = new System.Drawing.Size(543, 250);
            this.shiftResults.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(75, 87);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker3.TabIndex = 8;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(75, 61);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker4.TabIndex = 7;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(75, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(75, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Add Shift";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(182, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(-162, 120);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker5.TabIndex = 2;
            this.dateTimePicker5.Visible = false;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(-162, 158);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker6.TabIndex = 3;
            this.dateTimePicker6.Visible = false;
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
            // panelShowShift
            // 
            this.panelShowShift.Controls.Add(this.showStartPicker);
            this.panelShowShift.Controls.Add(this.endLabel1);
            this.panelShowShift.Controls.Add(this.showEndPicker);
            this.panelShowShift.Controls.Add(this.startLabel1);
            this.panelShowShift.Controls.Add(this.button3);
            this.panelShowShift.Location = new System.Drawing.Point(25, 122);
            this.panelShowShift.Name = "panelShowShift";
            this.panelShowShift.Size = new System.Drawing.Size(185, 130);
            this.panelShowShift.TabIndex = 7;
            this.panelShowShift.Visible = false;
            // 
            // addShiftPanel
            // 
            this.addShiftPanel.Controls.Add(this.dateTimePicker4);
            this.addShiftPanel.Controls.Add(this.comboBox1);
            this.addShiftPanel.Controls.Add(this.dateTimePicker3);
            this.addShiftPanel.Controls.Add(this.button5);
            this.addShiftPanel.Controls.Add(this.label4);
            this.addShiftPanel.Controls.Add(this.label3);
            this.addShiftPanel.Controls.Add(this.button4);
            this.addShiftPanel.Controls.Add(this.label5);
            this.addShiftPanel.Controls.Add(this.comboBox2);
            this.addShiftPanel.Controls.Add(this.label6);
            this.addShiftPanel.Location = new System.Drawing.Point(150, 28);
            this.addShiftPanel.Name = "addShiftPanel";
            this.addShiftPanel.Size = new System.Drawing.Size(254, 186);
            this.addShiftPanel.TabIndex = 16;
            this.addShiftPanel.Visible = false;
            this.addShiftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftResults)).EndInit();
            this.panelShowShift.ResumeLayout(false);
            this.panelShowShift.PerformLayout();
            this.addShiftPanel.ResumeLayout(false);
            this.addShiftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label endLabel1;
        private System.Windows.Forms.Label startLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker showEndPicker;
        private System.Windows.Forms.DateTimePicker showStartPicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView shiftResults;
        private System.Windows.Forms.Panel panelShowShift;
        private System.Windows.Forms.Panel addShiftPanel;
    }
}