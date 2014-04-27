using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    public partial class fAddClass : Form
    {
<<<<<<< HEAD
=======
        private int id = -1;
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        public fAddClass()
        {
            InitializeComponent();
            LoadRoomId();
            LoadGuideId();
        }
<<<<<<< HEAD

        private void button1_Click(object sender, EventArgs e)
        {
         //   DataTable dt = new DataTable();
=======
        public fAddClass(int id)
        {
            this.id = id;
            InitializeComponent();
            gidLabel.Visible = true;
            comboBox2.Visible = false;
            LoadRoomId();
            LoadGuideId();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //   DataTable dt = new DataTable();
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372

            try
            {
                int num;
                bool result = Int32.TryParse(textBox1.Text, out num);
<<<<<<< HEAD
                
                if (result)
                {
                    
                 //   string starttime = dateTimePicker1.Value.ToString("HH:mm:ss");

                  //  string endtime = dateTimePicker2.Value.ToString("HH:mm:ss");

                  //  string startdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                  //  string enddate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    
                    string Start = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string End = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");

                  //  MessageBox.Show((dateTimePicker1.Value.Date.ToLongDateString()-dateTimePicker2.Value.Date.ToLongDateString()).ToString());
                    int MonthDiff = dateTimePicker1.Value.Month - dateTimePicker2.Value.Month;
                    int TimeDiff =  dateTimePicker2.Value.Hour - dateTimePicker1.Value.Hour;
                    int YearDiff =  dateTimePicker1.Value.Year - dateTimePicker2.Value.Year;

                 //   if (TimeDiff <= 0)
                  //      MessageBox.Show("משך החוג קצר מדי");
                 //   else
                         if (TimeDiff > 6 || MonthDiff > 0 || YearDiff > 0)
                             MessageBox.Show("משך החוג ארוך מדי");

                    if (textBox1.Text == "" || textBox2.Text == "")
                        MessageBox.Show("לא מולאו כל הפרטים");
                    
                    else
                    {
                        if (SaveData(int.Parse(textBox1.Text), textBox2.Text, int.Parse(comboBox1.Text), int.Parse(comboBox2.Text)) 
=======

                if (result)
                {

                    //   string starttime = dateTimePicker1.Value.ToString("HH:mm:ss");

                    //  string endtime = dateTimePicker2.Value.ToString("HH:mm:ss");

                    //  string startdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    //  string enddate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                    string Start = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string End = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");

                    //  MessageBox.Show((dateTimePicker1.Value.Date.ToLongDateString()-dateTimePicker2.Value.Date.ToLongDateString()).ToString());
                    int MonthDiff = dateTimePicker1.Value.Month - dateTimePicker2.Value.Month;
                    int TimeDiff = dateTimePicker2.Value.Hour - dateTimePicker1.Value.Hour;
                    int YearDiff = dateTimePicker1.Value.Year - dateTimePicker2.Value.Year;

                    //   if (TimeDiff <= 0)
                    //      MessageBox.Show("משך החוג קצר מדי");
                    //   else
                    if (TimeDiff > 6 || MonthDiff > 0 || YearDiff > 0)
                        MessageBox.Show("משך החוג ארוך מדי");

                    if (textBox1.Text == "" || textBox2.Text == "")
                        MessageBox.Show("לא מולאו כל הפרטים");

                    else
                    {
                        if (SaveData(int.Parse(textBox1.Text), textBox2.Text, int.Parse(comboBox1.Text), int.Parse(comboBox2.Text))
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
                            && (SaveDate(int.Parse(textBox1.Text), Start, End)))
                        {
                            MessageBox.Show("הפרטים נוספו בהצלחה");
                            this.Close();
                        }
                        else
                            MessageBox.Show("הפרט לא נוסף");
                    }
                }
                else
                    MessageBox.Show("חזור על הפעולה שנית");
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
<<<<<<< HEAD
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //this.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAddActivity_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var customerId = Convert.ToInt32(comboBox1.Text);
           // LoadInfoById(customerId);
=======


      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var customerId = Convert.ToInt32(comboBox1.Text);
            // LoadInfoById(customerId);
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        }


        //Load room ID to a combobox
        private void LoadRoomId()
        {
            var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT Id FROM room";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("Id"));
<<<<<<< HEAD
                          
=======

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
                        }
                    }
                }
            }
        }

        //Load room details using the ID
        //private void LoadInfoById(int id)
        //{
        //    var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
        //    using (var connection = new MySqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        var query = "SELECT id , capacity FROM `gym`.`room` WHERE id = ?RoomId";
        //        using (var command = new MySqlCommand(query, connection))
        //        {
        //            //Always use SQL parameters to avoid SQL injection and it automatically escapes characters
        //            command.Parameters.AddWithValue("?RoomId", id);
        //            using (var reader = command.ExecuteReader())
        //            {
        //                //No customer found by supplied ID
        //                if (!reader.HasRows)
        //                    return;

        //            string test = reader.GetInt32("id").ToString();

        //            if (!reader.HasRows)
        //                return;
        //               // textBox4.Text = "some23";
        //               //textBox4.Text = reader.GetString("capacity");
        //            }
        //        }
        //    }
        //}



<<<<<<< HEAD
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372

        //Load GuideID to a combobox
        private void LoadGuideId()
        {
<<<<<<< HEAD
            var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT Id FROM guide";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader.GetString("Id"));
=======
            if (id != -1)
            {
                gidLabel.Text = id.ToString();
            }
            else
            {
                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT Id FROM guide";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            //Iterate through the rows and add it to the combobox's items
                            while (reader.Read())
                            {
                                comboBox2.Items.Add(reader.GetString("Id"));
                            }
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
                        }
                    }
                }
            }
        }

        private Boolean SaveDate(int ClassId, string Start, string End)
        {
            try
            {
                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO `gym`.`classtime` (`classid`, `starttime`, `endtime`) VALUES (?ClassId, ?Start, ?End)";

                    //INSERT INTO `gym`.`classtime` (`classid`, `starttime`, `endtime`) VALUES ('3', '2014-03-25 15:00:00', '2014-03-25 16:00:00');

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?ClassId", ClassId);
                        cmd.Parameters.AddWithValue("?Start", Start);
                        cmd.Parameters.AddWithValue("?End", End);
<<<<<<< HEAD
                        
=======

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();

                }
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + "has accurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private Boolean SaveData(int id, string name, int room, int guideId)
        {
            try
            {

                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO `gym`.`class` (`id`, `name`, `room`, `guideid`) VALUES (?id, ?name, ?room, ?guideId)";


                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?id", id);
                        cmd.Parameters.AddWithValue("?name", name);
                        cmd.Parameters.AddWithValue("?room", room);
                        cmd.Parameters.AddWithValue("?guideId", guideId);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();

                }
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + "has accurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
<<<<<<< HEAD
        
            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }




        

       
=======

            return true;
        }

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
    }
}
