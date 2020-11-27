using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7___5_
{
    class EE_student : Students
    {
       public EE_student(int roll_no, string first_name, string last_name,
             string phone_no, string city, string country,
            string state, string zip, string email, string father_name , string gender) :base( roll_no,  first_name,  last_name,
               phone_no,  city,  country,
             state,  zip,  email, father_name , gender)
        {

            Department = "EE";

        }
    }
}
