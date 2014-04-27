using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newGym
{
    class Applince
    {
        //class variables
        private int Id;
        private string Name;
        private string Manufactur;
        private int Room;
        private DateTime dt;

        //default constructor
        public Applince()
        {
            this.Id = 0;
            this.Name = "";
            this.Manufactur = "";
            this.Room = 0;
            this.dt = new DateTime();
        
    
        }
        //constructor
        public Applince(int id, string name, string manufactur, int room,DateTime dt)
        {
            this.Id =id;
            this.Name = name;
            this.Manufactur = manufactur;
            this.Room = room;
            this.dt = dt;
       
        
        }
        public void AddApplince(int id,string name,string manufactur,int room,DateTime dt)
        {
            
            //Applince Ap = new Applince();
            //Ap.id = id;
            //Ap.name = name;
            //Ap.manufactur = manufactur;
            //Ap.room = room;
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "INSERT INTO `gym`.`appliance` (`id`, `name`, `manufacturer`, `room`, `adddate`) VALUES ('" + Convert.ToInt32(id) + "', '" + name + "', '" + manufactur + "', '" + room + "', '" + dt.ToString("yyyy,MM,dd") + "' );";
            newConn.writeToDb(query);
           

           
        }
        public void deleteApplinceById(int id)
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "DELETE FROM gym.appliance WHERE id='" + id + "';";
            newConn.writeToDb(query);

        }
        public int id { get; set; }
        public string name { get; set; }
        public string manufactur { get; set; }
        public int room { get; set; }
        public DateTime Dt { get; set; }



    }
}
