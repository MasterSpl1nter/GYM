using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace newGym
{
    class Student:Person
    {
        private DateTime birthday;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime medCert;

        public Student():base() { 
        }

        public Student( int id, string firstName, string lastName, string email, int permission, string userName,
            string password ,DateTime birthday , DateTime startDate , DateTime endDate , DateTime medCert    )
            : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.birthday = birthday;
            this.startDate = startDate;
            this.endDate = endDate;
            this.medCert = medCert;
        }
        
        public static int Delete(string id)
        {
            return MySQL.Delete("student", "id=" + id);
        }

      

       protected override void setSalary(int salary)
       {
       }

        public void addStudToClass(int classId ){
            MySQL.Insert("studentclass", "studnetid,classid" , ""+this.Id.ToString()+ " , "+classId.ToString() );
        }
         
        public static void removeStudentFromClass ( int idStudent , int idClass) {

            MySQL.Delete("studentcalss" , "studentid = "+idStudent.ToString() + "AND " + "classid = " + idClass.ToString() );
        }

        protected override bool CheckLogin(DataTable dt, string user, string pass)
        {
            MessageBox.Show("student Chek login");
            //if the id exist? yes-pop the datatable of this user
            if (MySQL.Query(dt, "SELECT * FROM student where username='" + user + "'" + " and password='" + pass + "'") == 0)
                if (dt.Rows.Count == 1)
                    return true;
            return false;
        }


        public void setbday(DateTime bday)
        {
            this.birthday = bday;
        }

        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }
        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }
        public void setbMedCert(DateTime medCert)
        {
            this.medCert = medCert;
        }


    }
}