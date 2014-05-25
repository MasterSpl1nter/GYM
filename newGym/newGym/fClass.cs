using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace newGym
{
    class fClass
    {
        private int id;
        private string name;
        private int participants;
        private int room;
        private int guideid;
        private int maxCapacity;
        string startClass;
        string endClass;
        public fClass()     // def const
        {
            this.id = 0;
            this.name = " ";
            this.participants = 0;
            this.room = 0;
            this.guideid = 0;
            maxCapacity = 0;
            this.startClass = "";
            this.endClass = "";
        }

        public fClass(int id, string name, int room, int guideid, int participants, int maxcapacity, string start, string end)
        {
            this.id = id;
            this.name = name;
            this.participants = participants;
            this.room = room;
            this.guideid = guideid;
            this.maxCapacity = maxcapacity;
            this.startClass = start;
            this.endClass = end;
        }

        public Boolean SaveData()
        {
            try
            {

                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO `gym`.`class` (`id`, `name`, `room`, `guideid`,  `capacity`, `area`) VALUES (?id, ?name, ?room, ?guideid, ?capacity, ?area)";


                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?id", id);
                        cmd.Parameters.AddWithValue("?name", name);
                        cmd.Parameters.AddWithValue("?room", room);
                        cmd.Parameters.AddWithValue("?guideid", guideid);
                        //cmd.Parameters.AddWithValue("?participants", participants);
                        cmd.Parameters.AddWithValue("?capacity", maxCapacity);
                        cmd.Parameters.AddWithValue("?area", 0);


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

        public Boolean SaveDate()
        {
            if (isTimeBetweenClasses() == false)
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
                            cmd.Parameters.AddWithValue("?ClassId", id);
                            cmd.Parameters.AddWithValue("?Start", startClass);
                            cmd.Parameters.AddWithValue("?End", endClass);

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
            MessageBox.Show("The selected room is busy in this choosen time, Please select other time or other room","Room taken",MessageBoxButtons.OK);
            return false;
        }

        public Boolean isRoomOccupied()
        {
            int count = 0;
            count = MySQL.count("SELECT id FROM class WHERE room=" + room);
            if (count == 0)
                return true;
            else
                return false;
        }
        public Boolean isTimeBetweenClasses()
        {
            int[] usedId;
            int i = 0, size = 0;
            try
            {
                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query1 = "SELECT id FROM class WHERE room=" + room;
                    using (var cmd = new MySqlCommand(query1, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                size++;
                        }

                        usedId = new int[size];

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usedId[i++] = int.Parse(reader.GetString("id"));
                            }
                        }

                    }
                    connection.Close();
                    // call to check if the shedule is not free
                    for (int j = 0; j < size; j++)
                        if (CheckTimes(usedId[j], Convert.ToDateTime(startClass), Convert.ToDateTime(endClass)) == true)
                            return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + "has accurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private Boolean CheckTimes(int id, DateTime start, DateTime end)
        {
            DateTime sqlStartTime, sqlEndTime;
            TimeSpan newStart = new TimeSpan(0, start.Hour, start.Minute, 0);
            TimeSpan newEnd = new TimeSpan(0, end.Hour, end.Minute, 0);
            TimeSpan oldStart;
            TimeSpan oldEnd;
            //Boolean isTimeBetween;
            try
            {
                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query1 = "SELECT starttime, endtime FROM classtime WHERE classid=" + id;
                    using (var cmd = new MySqlCommand(query1, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sqlStartTime = reader.GetDateTime("starttime");
                                sqlEndTime = reader.GetDateTime("endtime");
                                // TO-CODE check if time has the same date
                                if (start.Date.Equals(end.Date))
                                {
                                    oldStart = new TimeSpan(0, sqlStartTime.Hour, sqlStartTime.Minute, 0);
                                    oldEnd = new TimeSpan(0, sqlEndTime.Hour, sqlEndTime.Minute, 0);

                                   return ((newStart <= oldEnd)  &&  (newEnd >= oldStart));
                                }
                            }
                        }
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + "has accurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }





        public void increase(int classID)
        {
            try
            {

                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "UPDATE `gym`.`class` SET participants = participants+1 WHERE id=?classID";


                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?classID", classID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();

                }
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + "has accurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void decrease(int classID)
        {
            try
            {

                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "UPDATE `gym`.`class` SET participants = participants-1 WHERE id=?classID";


                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?classID", classID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();

                }
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + "has accurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
