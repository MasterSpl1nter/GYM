using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace newGym
{
    class Student:Person
    {
        private DateTime birthday;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime medcert;

        public Student():base() { 
        }

        public Student( int id, string firstName, string lastName, string email, int permission, string userName,
            string password ,DateTime birthday , DateTime startDate , DateTime endDate , DateTime medcert    )
            : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.birthday = birthday;
            this.startDate = startDate;
            this.endDate = endDate;
            this.medcert = medcert;
        }
        
        public static int Delete(string id)
        {
            return MySQL.Delete("student", "id=" + id);
        }

       protected override bool CheckLogin(DataTable dt, string user, string pass)
        { return false; }

       protected override void makeInstance(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salary)
       {
           throw new NotImplementedException();
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



       
      
    }
}