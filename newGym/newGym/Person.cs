using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace newGym
{
    public abstract class Person
    {
        //fields of Person
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string userName;
        private string password;
        private int permission;
        //default const
        public Person()
        {
            this.id = 0;
            this.firstName = "";
            this.lastName = "";
            this.email = "";
            this.userName = "";
            this.password = "";
            this.permission = 0;
        }

        public Person(int id, string firstName = "null", string lastName = "null", string email = "null", int permission = 0, string userName = "null", string password = "null")
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.permission = permission;
            this.userName = userName;
            this.password = password;
        }

        public int Id{ get { return id; } set { id = value; }  }
        public string FirstName{ get { return firstName; } set { firstName = value; }  }
        //get/set func for last name
        public string LastName { get { return lastName; } set { lastName = value; } }
        
        //get/set func for address
        public string Email  { get { return email; }set { email = value; }  }
        //get/set func for userName
        public string UserName{ get { return userName; }set { userName = value; } }
        //get/set func for password
        public string Password {get { return password; }set { password = value; }}
        public int Permission { get { return permission; }set { permission = value; } }
        ///////////////////////////////////////////////////////////////////////
               public static int[] ZeroID(int id)
        {
            int[] arr = new int[9];
            for (int i = 8; i > -1; i--)
            {
                arr[i] = id % 10;
                id /= 10;
            }
            return arr;
        }
        public static bool ValidateID(string idstr)
        {
            int id = Convert.ToInt32(idstr);
            int sum = 0;
            int[] arr = ZeroID(id);
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 1)
                {
                    arr[i] *= 2;
                    if (arr[i] > 9)
                        arr[i] = arr[i] / 10 + arr[i] % 10;
                }
                sum += arr[i];
            }
            if (sum % 10 == 0)
            {
                return true;
            }
            return false;
        }
    }

    }
