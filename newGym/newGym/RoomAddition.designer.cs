namespace newGym
{
    partial class RoomAddition
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
            this.button1 = new GButton();
            this.NUM_cap = new System.Windows.Forms.NumericUpDown();
            this.NUM_area = new System.Windows.Forms.NumericUpDown();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RoomName_Label = new System.Windows.Forms.Label();
            this.StudentCap_label = new System.Windows.Forms.Label();
            this.Area_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_cap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_area)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "המשך";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NUM_cap
            // 
            this.NUM_cap.Location = new System.Drawing.Point(116, 49);
            this.NUM_cap.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUM_cap.Name = "NUM_cap";
            this.NUM_cap.Size = new System.Drawing.Size(120, 20);
            this.NUM_cap.TabIndex = 1;
            // 
            // NUM_area
            // 
            this.NUM_area.Location = new System.Drawing.Point(116, 75);
            this.NUM_area.Name = "NUM_area";
            this.NUM_area.Size = new System.Drawing.Size(120, 20);
            this.NUM_area.TabIndex = 2;
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(116, 23);
            this.TB_name.MaxLength = 29;
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(120, 20);
            this.TB_name.TabIndex = 3;
            // 
            // RoomName_Label
            // 
            this.RoomName_Label.AutoSize = true;
            this.RoomName_Label.Location = new System.Drawing.Point(23, 30);
            this.RoomName_Label.Name = "RoomName_Label";
            this.RoomName_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RoomName_Label.Size = new System.Drawing.Size(66, 13);
            this.RoomName_Label.TabIndex = 4;
            this.RoomName_Label.Text = "Room Name";
            // 
            // StudentCap_label
            // 
            this.StudentCap_label.AutoSize = true;
            this.StudentCap_label.Location = new System.Drawing.Point(23, 56);
            this.StudentCap_label.Name = "StudentCap_label";
            this.StudentCap_label.Size = new System.Drawing.Size(68, 13);
            this.StudentCap_label.TabIndex = 5;
            this.StudentCap_label.Text = "Student cap.";
            // 
            // Area_label
            // 
            this.Area_label.AutoSize = true;
            this.Area_label.Location = new System.Drawing.Point(23, 82);
            this.Area_label.Name = "Area_label";
            this.Area_label.Size = new System.Drawing.Size(29, 13);
            this.Area_label.TabIndex = 6;
            this.Area_label.Text = "Area";
            // 
            // RoomAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 164);
            this.Controls.Add(this.Area_label);
            this.Controls.Add(this.StudentCap_label);
            this.Controls.Add(this.RoomName_Label);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.NUM_area);
            this.Controls.Add(this.NUM_cap);
            this.Controls.Add(this.button1);
            this.Name = "RoomAddition";
            this.Text = "RoomAddition";
            ((System.ComponentModel.ISupportInitialize)(this.NUM_cap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NUM_cap;
        private System.Windows.Forms.NumericUpDown NUM_area;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label RoomName_Label;
        private System.Windows.Forms.Label StudentCap_label;
        private System.Windows.Forms.Label Area_label;
    }
}