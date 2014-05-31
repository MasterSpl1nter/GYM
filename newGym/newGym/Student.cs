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
        
        public int Delete(string id)
        {
            return MySQL.Delete("student", "id=" + id);
        }

      

       protected override void setSalary(int salary)
       {
       }

        public int addStudToClass(string classId , string studentId ){
           return MySQL.Insert("studentclass", "studentid,classid", "'" + studentId + "','" + classId + "'" );
        }
         
        public int removeStudentFromClass ( String idStudent , String idClass) {

            return MySQL.Delete("studentclass" , "studentid = "+idStudent + " AND " + "classid = " + idClass );
        }

        protected override bool CheckLogin(DataTable dt, string user, string pass)
        {
           // MessageBox.Show("student Chek login");
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

        public DateTime getbday()
        {
            return this.birthday;
        }

        public DateTime getStartDate()
        {
            return this.startDate;
        }
        public DateTime getEndDate()
        {
            return this.endDate ;
        }
        public DateTime getMedCert()
        {
            return this.medCert ;
        }

        public string getid() {
            return this.Id.ToString();
        }
    }
}