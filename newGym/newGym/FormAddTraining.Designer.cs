﻿namespace newGym
{
    partial class FormAddTraining
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
            this.groupBox3 = new newGym.GGroupBox();
            this.delid_txt = new System.Windows.Forms.TextBox();
            this.remove_button = new newGym.GButton();
            this.label5 = new newGym.GLabel();
            this.label4 = new newGym.GLabel();
            this.label3 = new newGym.GLabel();
            this.label2 = new newGym.GLabel();
            this.label1 = new newGym.GLabel();
            this.delrepeats_txt = new System.Windows.Forms.TextBox();
            this.delsets_txt = new System.Windows.Forms.TextBox();
            this.delappliance_txt = new System.Windows.Forms.TextBox();
            this.delname_txt = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new newGym.GGroupBox();
            this.id_label = new newGym.GLabel();
            this.repeats = new newGym.GLabel();
            this.save_button = new newGym.GButton();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.sets = new newGym.GLabel();
            this.appliance = new newGym.GLabel();
            this.repeats_txt = new System.Windows.Forms.TextBox();
            this.training_name = new newGym.GLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sets_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new newGym.GGroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.delid_txt);
            this.groupBox3.Controls.Add(this.remove_button);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.delrepeats_txt);
            this.groupBox3.Controls.Add(this.delsets_txt);
            this.groupBox3.Controls.Add(this.delappliance_txt);
            this.groupBox3.Controls.Add(this.delname_txt);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(16, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 131);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove Part of Workout";
            // 
            // delid_txt
            // 
            this.delid_txt.Location = new System.Drawing.Point(30, 70);
            this.delid_txt.Name = "delid_txt";
            this.delid_txt.Size = new System.Drawing.Size(100, 22);
            this.delid_txt.TabIndex = 12;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.remove_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Image = global::newGym.Properties.Resources._1399410901_trash1;
            this.remove_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_button.Location = new System.Drawing.Point(479, 97);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(96, 23);
            this.remove_button.TabIndex = 10;
            this.remove_button.Text = "  Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(475, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "# of Repeats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(372, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "# of Sets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(243, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Appliance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(136, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Training Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // delrepeats_txt
            // 
            this.delrepeats_txt.Location = new System.Drawing.Point(475, 69);
            this.delrepeats_txt.MaxLength = 2;
            this.delrepeats_txt.Name = "delrepeats_txt";
            this.delrepeats_txt.Size = new System.Drawing.Size(100, 22);
            this.delrepeats_txt.TabIndex = 4;
            // 
            // delsets_txt
            // 
            this.delsets_txt.Location = new System.Drawing.Point(369, 70);
            this.delsets_txt.MaxLength = 2;
            this.delsets_txt.Name = "delsets_txt";
            this.delsets_txt.Size = new System.Drawing.Size(100, 22);
            this.delsets_txt.TabIndex = 3;
            // 
            // delappliance_txt
            // 
            this.delappliance_txt.Location = new System.Drawing.Point(242, 70);
            this.delappliance_txt.MaxLength = 29;
            this.delappliance_txt.Name = "delappliance_txt";
            this.delappliance_txt.Size = new System.Drawing.Size(121, 22);
            this.delappliance_txt.TabIndex = 2;
            // 
            // delname_txt
            // 
            this.delname_txt.Location = new System.Drawing.Point(136, 71);
            this.delname_txt.MaxLength = 29;
            this.delname_txt.Name = "delname_txt";
            this.delname_txt.Size = new System.Drawing.Size(100, 22);
            this.delname_txt.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(30, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.id_label);
            this.groupBox1.Controls.Add(this.repeats);
            this.groupBox1.Controls.Add(this.save_button);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.sets);
            this.groupBox1.Controls.Add(this.appliance);
            this.groupBox1.Controls.Add(this.repeats_txt);
            this.groupBox1.Controls.Add(this.training_name);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.sets_txt);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Part of Workout Training";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.id_label.ForeColor = System.Drawing.Color.Black;
            this.id_label.Location = new System.Drawing.Point(30, 13);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(18, 13);
            this.id_label.TabIndex = 5;
            this.id_label.Text = "ID";
            // 
            // repeats
            // 
            this.repeats.AutoSize = true;
            this.repeats.BackColor = System.Drawing.Color.Transparent;
            this.repeats.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.repeats.ForeColor = System.Drawing.Color.Black;
            this.repeats.Location = new System.Drawing.Point(479, 13);
            this.repeats.Name = "repeats";
            this.repeats.Size = new System.Drawing.Size(71, 13);
            this.repeats.TabIndex = 6;
            this.repeats.Text = "# of Repeats";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Image = global::newGym.Properties.Resources._1399410268_add;
            this.save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_button.Location = new System.Drawing.Point(482, 60);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(96, 23);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "  Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(33, 30);
            this.id_txt.MaxLength = 9;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 22);
            this.id_txt.TabIndex = 0;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            this.id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_txt_KeyPress);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(139, 31);
            this.name_txt.MaxLength = 29;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 22);
            this.name_txt.TabIndex = 1;
            // 
            // sets
            // 
            this.sets.AutoSize = true;
            this.sets.BackColor = System.Drawing.Color.Transparent;
            this.sets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.sets.ForeColor = System.Drawing.Color.Black;
            this.sets.Location = new System.Drawing.Point(369, 13);
            this.sets.Name = "sets";
            this.sets.Size = new System.Drawing.Size(52, 13);
            this.sets.TabIndex = 5;
            this.sets.Text = "# of Sets";
            // 
            // appliance
            // 
            this.appliance.AutoSize = true;
            this.appliance.BackColor = System.Drawing.Color.Transparent;
            this.appliance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.appliance.ForeColor = System.Drawing.Color.Black;
            this.appliance.Location = new System.Drawing.Point(246, 11);
            this.appliance.Name = "appliance";
            this.appliance.Size = new System.Drawing.Size(53, 13);
            this.appliance.TabIndex = 1;
            this.appliance.Text = "Appliance";
            // 
            // repeats_txt
            // 
            this.repeats_txt.Location = new System.Drawing.Point(478, 32);
            this.repeats_txt.MaxLength = 2;
            this.repeats_txt.Name = "repeats_txt";
            this.repeats_txt.Size = new System.Drawing.Size(100, 22);
            this.repeats_txt.TabIndex = 4;
            this.repeats_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repeats_txt_KeyPress);
            // 
            // training_name
            // 
            this.training_name.AutoSize = true;
            this.training_name.BackColor = System.Drawing.Color.Transparent;
            this.training_name.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.training_name.ForeColor = System.Drawing.Color.Black;
            this.training_name.Location = new System.Drawing.Point(139, 13);
            this.training_name.Name = "training_name";
            this.training_name.Size = new System.Drawing.Size(75, 13);
            this.training_name.TabIndex = 0;
            this.training_name.Text = "Training Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sets_txt
            // 
            this.sets_txt.Location = new System.Drawing.Point(372, 32);
            this.sets_txt.MaxLength = 2;
            this.sets_txt.Name = "sets_txt";
            this.sets_txt.Size = new System.Drawing.Size(100, 22);
            this.sets_txt.TabIndex = 2;
            this.sets_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sets_txt_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(13, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 170);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trainings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 149);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormAddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAddTraining";
            this.Text = "Add Training";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox sets_txt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox repeats_txt;
        private GLabel id_label;
        private GGroupBox groupBox1;
        private GLabel repeats;
        private GLabel sets;
        private GLabel appliance;
        private GLabel training_name;
        private GButton save_button;
        private GGroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GGroupBox groupBox3;
        private GLabel label5;
        private GLabel label4;
        private GLabel label3;
        private GLabel label2;
        private GLabel label1;
        private System.Windows.Forms.TextBox delrepeats_txt;
        private System.Windows.Forms.TextBox delsets_txt;
        private System.Windows.Forms.TextBox delappliance_txt;
        private System.Windows.Forms.TextBox delname_txt;
        private System.Windows.Forms.ComboBox comboBox2;
        private GButton remove_button;
        private System.Windows.Forms.TextBox delid_txt;
    }
}