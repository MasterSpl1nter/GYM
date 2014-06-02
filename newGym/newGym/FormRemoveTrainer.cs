using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace newGym
{
    public partial class FormRemoveTrainer : GForm
    {
        public FormRemoveTrainer()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.trainer  ;";     
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                
                while (myReader.Read())     //adding names to combobox
                {
                    string sName = myReader.GetString("firstname");
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "delete from gym.trainer where firstname='" + this.comboBox1.Text + "' ;"; 
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Trainer Deleted");

                this.Close();
                

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
