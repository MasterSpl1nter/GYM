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
    public partial class ManuApplince : GForm
    {
        public ManuApplince()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Fo2=new Form2();
            this.Hide();
            Fo2.ShowDialog();

            
        }

        private void ManuApplince_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Fo3 = new Form3();
            this.Hide();
            Fo3.ShowDialog();
        }
    }
}
