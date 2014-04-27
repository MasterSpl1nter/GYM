using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    class Room
    {
        private int id;
        private string name;
        private uint capacity;
        private uint area;

        public Room()
        {
            id=0;
            name="";
            capacity=0;
            area=0;
        }//end of default constructor

        public Room(int id, string name, uint capacity, uint area) {
            this.id = id;
            this.name = name;
            this.capacity = capacity;
            this.area = area;                 
        }// end of parameter constructor 

        public void push_to_db()
        {
            try
            {
                MySQL.Insert("room", "name,capacity,area", "'" + name + "'" + "," + capacity.ToString() + "," + area.ToString());
                MessageBox.Show(" you have sucsessfully added an room ");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) {
                MessageBox.Show("something went wrong in insertion to the db\n" + ex.ToString());
            }
        }

        static public void addRoom()
        {
            int taken = MySQL.SUM("room", "area");

            if (taken < 2000)
            {
                RoomAddition a = new RoomAddition(taken);
                a.ShowDialog();
            }
            else
                MessageBox.Show("you have used all the given space ");
        }

    }// end of room class
}// end of namepace 
