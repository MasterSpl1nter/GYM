using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace newGym
{
    public class Trainer : Person
    {
        private int salary;
<<<<<<< HEAD
=======
        public Trainer():base() {
            this.salary = 0;
        }

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        public Trainer(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salary)
            : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.salary = salary;
        }
<<<<<<< HEAD
        public static bool CheckLogin(DataTable dt, string user, string pass)
=======
        
        protected override void makeInstance(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salary)
        {
           Trainer trainer = new Trainer(id, firstName, lastName, email, permission, userName, password, salary);       //call the constr TMP-DP
           TrainerMenu tm = new TrainerMenu(trainer);
           tm.ShowDialog();
        }
        
        protected override bool CheckLogin(DataTable dt, string user, string pass)
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        {
            if (MySQL.Query(dt, "SELECT * FROM trainer where username='" + user + "'" + " and password='" + pass + "'") == 0)
                if (dt.Rows.Count == 1)
                    return true;
            return false;
        }
        public static int Update(string insert, string where)
        {
            return MySQL.Update("trainer", insert, "id=" + where);
        }
        public static int Add(string insert)
        {
            return MySQL.Insert("trainer", "id,firstname,lastname,email,username,password,permission,salaryperhour", insert);
        }
        public static int Delete(string id)
        {
            return MySQL.Delete("trainer", "id=" + id);
        }
        public int SearchID(DataTable dt, string search)
        {
            int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email FROM trainer where id LIKE " + search);
            if (retval == 0)
                return 0;
            return retval;
        }
        public int SearchName(DataTable dt, string search)
        {
            int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email FROM trainer where firstname LIKE " + "'%" + search.Split(' ')[0] + "%' and lastname LIKE '%" + search.Split(' ')[1] + "%'");
            if (retval == 0)
                return 0;
            return retval;
        }
        public int SearchStudID(DataTable dt, string search)
        {
<<<<<<< HEAD
            int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email,birthday,startdate,enddate,medcert FROM student where id LIKE " + search);
=======
            //int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email,birthday,startdate,enddate,medcert FROM student where id LIKE " + search);

            int retval;
            if (search.Contains(" "))
            {
                retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email FROM trainer where firstname LIKE " + "'%" + search.Split(' ')[0] + "%' and lastname LIKE '%" + search.Split(' ')[1] + "%'");
            }
            else
            {
                retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email FROM trainer where firstname LIKE " + "'%" + search + "%'");

            }
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            if (retval == 0)
                return 0;
            return retval;
        }
        public int SearchStudName(DataTable dt, string search)
        {
            int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email,birthday,startdate,enddate,medcert FROM student where firstname LIKE " + "'%" + search.Split(' ')[0] + "%' and lastname LIKE '%" + search.Split(' ')[1] + "%'");
            if (retval == 0)
                return 0;
            return retval;
        }
    }
}
