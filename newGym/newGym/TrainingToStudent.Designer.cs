namespace newGym
{
    partial class TrainingToStudent
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.training2student_betton = new GButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.sets_txt = new System.Windows.Forms.TextBox();
            this.repeats_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.appliance_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Training";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Student ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // training2student_betton
            // 
            this.training2student_betton.Image = global::newGym.Properties.Resources._1399410268_add;
            this.training2student_betton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.training2student_betton.Location = new System.Drawing.Point(162, 147);
            this.training2student_betton.Name = "training2student_betton";
            this.training2student_betton.Size = new System.Drawing.Size(142, 26);
            this.training2student_betton.TabIndex = 7;
            this.training2student_betton.Text = "Add Training to Student";
            this.training2student_betton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.training2student_betton.UseVisualStyleBackColor = true;
            this.training2student_betton.Click += new System.EventHandler(this.training2student_betton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.appliance_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.repeats_txt);
            this.groupBox1.Controls.Add(this.sets_txt);
            this.groupBox1.Controls.Add(this.lastname_txt);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.training2student_betton);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 189);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add to Student";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(158, 46);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 12;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(265, 45);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(100, 20);
            this.lastname_txt.TabIndex = 13;
            // 
            // sets_txt
            // 
            this.sets_txt.Location = new System.Drawing.Point(264, 87);
            this.sets_txt.Name = "sets_txt";
            this.sets_txt.Size = new System.Drawing.Size(100, 20);
            this.sets_txt.TabIndex = 14;
            this.sets_txt.TextChanged += new System.EventHandler(this.sets_txt_TextChanged);
            // 
            // repeats_txt
            // 
            this.repeats_txt.Location = new System.Drawing.Point(370, 87);
            this.repeats_txt.Name = "repeats_txt";
            this.repeats_txt.Size = new System.Drawing.Size(100, 20);
            this.repeats_txt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Repeats";
            // 
            // appliance_txt
            // 
            this.appliance_txt.Location = new System.Drawing.Point(158, 86);
            this.appliance_txt.Name = "appliance_txt";
            this.appliance_txt.Size = new System.Drawing.Size(100, 20);
            this.appliance_txt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Appliance";
            // 
            // TrainingToStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 208);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrainingToStudent";
            this.Text = "Add Training to Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private GButton training2student_betton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox appliance_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repeats_txt;
        private System.Windows.Forms.TextBox sets_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox name_txt;
    }
}