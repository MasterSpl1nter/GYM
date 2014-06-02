using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    public partial class RoomAddition : GForm
    {
        public RoomAddition()
        {
            InitializeComponent();
        }

        public RoomAddition(int taken)
        {
            InitializeComponent();

            NUM_area.Maximum = 2000 - taken;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string name=TB_name.Text;
            uint capacity = (uint)NUM_cap.Value ;// might not work fine
            uint area = (uint)NUM_area.Value ;// same 

            Room temp=new Room(0, name, capacity, area);

            temp.push_to_db();

        }
    }
}



