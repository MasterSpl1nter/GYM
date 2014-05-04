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
    public partial class GGroupBox : GroupBox
    {
        public GGroupBox()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent;
            this.ForeColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
        }
    }
}
