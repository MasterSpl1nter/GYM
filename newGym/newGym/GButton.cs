using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace newGym
{
    public partial class GButton : Button
    {

        public GButton():base()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.White;
            this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Size = new System.Drawing.Size(86, 27);
            this.UseVisualStyleBackColor = false;

            
            //this.BackColor= System.Windows.Forms.
        }
    }
}
