using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newGym
{
    class Secretary : Person
    {
        private int salaryPerHour;
        public Secretary() :base ()
        {
            salaryPerHour = 0;
        }
        
        public Secretary(int id, string firstName, string lastName, string email, int permission, string userName,
            string password, int salaryPerHour = 0) : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.salaryPerHour = salaryPerHour;
        }
<<<<<<< HEAD
        public int SalaryPerHour { get { return salaryPerHour; } set { salaryPerHour = value; } 
        }
        public static bool CheckLogin(string user, string pass)
        {
            DataTable dt = new DataTable();
=======
        protected override bool CheckLogin(DataTable dt, string user, string pass)
        {
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            if (MySQL.Query(dt, "SELECT username,password FROM worker where username='" 
                + user + "'" + " and password='" + pass + "'") == 0)
                if (dt.Rows.Count == 1)
                    return true;
            return false;
<<<<<<< HEAD
        }
=======
         }

        protected override void makeInstance(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salary)
        {
            // TO CODE
            // 1 - call consructor
            // 2 - call secretary menu
            throw new NotImplementedException();
        }

        public int SalaryPerHour { get { return salaryPerHour; } set { salaryPerHour = value; } }
        
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        public static int Update(string insert, string where)
        {
            return MySQL.Update("worker", insert, "id=" + where);
        }
        public static int Add(string insert)
        {
            return MySQL.Insert("worker", "id,firstname,lastname,email,username,password,permission,salaryperhour", insert);
        }
        public static int Delete(string id)
        {
            return MySQL.Delete("worker", "id=" + id);
        }
    }
}
