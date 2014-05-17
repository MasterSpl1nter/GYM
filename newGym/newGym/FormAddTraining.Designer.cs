namespace newGym
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.training_name = new System.Windows.Forms.Label();
            this.appliance = new System.Windows.Forms.Label();
            this.sets = new System.Windows.Forms.Label();
            this.repeats = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.update_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(478, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(30, 51);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(18, 13);
            this.id_label.TabIndex = 5;
            this.id_label.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_label);
            this.groupBox1.Controls.Add(this.repeats);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.sets);
            this.groupBox1.Controls.Add(this.appliance);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.training_name);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Part of Workout Training";
            // 
            // training_name
            // 
            this.training_name.AutoSize = true;
            this.training_name.Location = new System.Drawing.Point(136, 52);
            this.training_name.Name = "training_name";
            this.training_name.Size = new System.Drawing.Size(76, 13);
            this.training_name.TabIndex = 0;
            this.training_name.Text = "Training Name";
            // 
            // appliance
            // 
            this.appliance.AutoSize = true;
            this.appliance.Location = new System.Drawing.Point(246, 51);
            this.appliance.Name = "appliance";
            this.appliance.Size = new System.Drawing.Size(54, 13);
            this.appliance.TabIndex = 1;
            this.appliance.Text = "Appliance";
            // 
            // sets
            // 
            this.sets.AutoSize = true;
            this.sets.Location = new System.Drawing.Point(372, 52);
            this.sets.Name = "sets";
            this.sets.Size = new System.Drawing.Size(50, 13);
            this.sets.TabIndex = 5;
            this.sets.Text = "# of Sets";
            // 
            // repeats
            // 
            this.repeats.AutoSize = true;
            this.repeats.Location = new System.Drawing.Point(478, 52);
            this.repeats.Name = "repeats";
            this.repeats.Size = new System.Drawing.Size(69, 13);
            this.repeats.TabIndex = 6;
            this.repeats.Text = "# of Repeats";
            // 
            // save_button
            // 
            this.save_button.Image = global::newGym.Properties.Resources._1399410331_document_edit;
            this.save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_button.Location = new System.Drawing.Point(494, 154);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(96, 23);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 182);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trainings";
            // 
            // update_button
            // 
            this.update_button.Image = global::newGym.Properties.Resources._1399410331_document_edit;
            this.update_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_button.Location = new System.Drawing.Point(494, 391);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(96, 23);
            this.update_button.TabIndex = 9;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormAddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 426);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAddTraining";
            this.Text = "Add Training";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label repeats;
        private System.Windows.Forms.Label sets;
        private System.Windows.Forms.Label appliance;
        private System.Windows.Forms.Label training_name;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_button;
    }
}