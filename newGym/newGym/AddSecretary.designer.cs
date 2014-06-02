namespace newGym
{
    partial class AddSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSecretary));
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.firstname_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.lastname_textBox = new System.Windows.Forms.TextBox();
            this.enter_button = new GButton();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.verify_label = new System.Windows.Forms.Label();
            this.verify_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // id_label
            // 
            resources.ApplyResources(this.id_label, "id_label");
            this.id_label.Name = "id_label";
            // 
            // name_label
            // 
            resources.ApplyResources(this.name_label, "name_label");
            this.name_label.Name = "name_label";
            // 
            // lastname_label
            // 
            resources.ApplyResources(this.lastname_label, "lastname_label");
            this.lastname_label.Name = "lastname_label";
            // 
            // email_label
            // 
            resources.ApplyResources(this.email_label, "email_label");
            this.email_label.Name = "email_label";
            // 
            // id_textBox
            // 
            resources.ApplyResources(this.id_textBox, "id_textBox");
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.TextChanged += new System.EventHandler(this.id_textBox_TextChanged);
            this.id_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_textBox_KeyPress);
            // 
            // firstname_textBox
            // 
            resources.ApplyResources(this.firstname_textBox, "firstname_textBox");
            this.firstname_textBox.Name = "firstname_textBox";
            // 
            // email_textBox
            // 
            resources.ApplyResources(this.email_textBox, "email_textBox");
            this.email_textBox.Name = "email_textBox";
            // 
            // lastname_textBox
            // 
            resources.ApplyResources(this.lastname_textBox, "lastname_textBox");
            this.lastname_textBox.Name = "lastname_textBox";
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.enter_button, "enter_button");
            this.enter_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enter_button.Name = "enter_button";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // username_label
            // 
            resources.ApplyResources(this.username_label, "username_label");
            this.username_label.Name = "username_label";
            // 
            // password_label
            // 
            resources.ApplyResources(this.password_label, "password_label");
            this.password_label.Name = "password_label";
            // 
            // username_textBox
            // 
            resources.ApplyResources(this.username_textBox, "username_textBox");
            this.username_textBox.Name = "username_textBox";
            // 
            // password_textBox
            // 
            resources.ApplyResources(this.password_textBox, "password_textBox");
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // verify_label
            // 
            resources.ApplyResources(this.verify_label, "verify_label");
            this.verify_label.Name = "verify_label";
            // 
            // verify_textBox
            // 
            resources.ApplyResources(this.verify_textBox, "verify_textBox");
            this.verify_textBox.Name = "verify_textBox";
            // 
            // AddSecretary
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.lastname_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.verify_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.firstname_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.verify_label);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.id_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddSecretary";
            this.Load += new System.EventHandler(this.AddSecretary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox firstname_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox lastname_textBox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label verify_label;
        private System.Windows.Forms.TextBox verify_textBox;
    }
}