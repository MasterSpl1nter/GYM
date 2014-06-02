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
    public partial class GLabel : Label
    {
        public GLabel()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent;
            this.ForeColor = System.Drawing.Color.Black;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));

        }
    }
}
