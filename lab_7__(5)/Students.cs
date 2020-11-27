using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7___5_
{
    class Students
    {
        protected int    roll_no;
        protected string first_name;
        protected string last_name;
        protected string department;
        protected string phone_no;
        protected string city;
        protected string country;
        protected string state;
        protected string zip;
        protected string email;
      
        protected string father_name;
        protected string gender;

        public Students()
        {
        }

        public Students(int roll_no, string first_name, string last_name, string phone_no,
            string city, string country, string state, string zip, string email, string father_name ,  string Gender)
        {
            Roll_no = roll_no;
            First_name = first_name;
            Last_name = last_name;
            Phone_no = phone_no;
            City = city;
            Country = country;
            State = state;
            Zip = zip;
            Email = email;
            Father_name = father_name;
            this.Gender = Gender;
        }

        public int Roll_no { get => roll_no; set => roll_no = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Phone_no { get => phone_no; set => phone_no = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string Email { get => email; set => email = value; }
        public string Father_name { get => father_name; set => father_name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Department { get => department; set => department = value; }
    }
}
