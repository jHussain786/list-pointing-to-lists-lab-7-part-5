using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7___5_
{
    public partial class Form1 : Form
    {
        List<List<Students>> M_list;
        List<Students> EE_Students;
        List<Students> BSCS_Students;
        List<Students> ME_Students;
        Students m_student;
        public Form1()
        {
            InitializeComponent();

            M_list = new List<List<Students>>();
            EE_Students = new List<Students>();
            BSCS_Students = new List<Students>();
            ME_Students = new List<Students>();

            M_list.Add(EE_Students);
            M_list.Add(ME_Students);
            M_list.Add(BSCS_Students);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int roll = Convert.ToInt32(txt_roll.Text);
                string phone = txt_phone.Text;
                string firstname = txt_fname.Text;
                string lastname = txt_Lname.Text;
                string father = txt_FatherName.Text;
                string city = txt_City.Text;
                string country = txt_Country.Text;
                string state = txt_state.Text;
                string zip = txt_zip.Text;
                string Email = txt_Email.Text;

                Regex cityRg = new Regex("[a-zA-Z]");
                if (!cityRg.IsMatch(city))
                {
                    MessageBox.Show("Enter City in correct format");
                    return;
                }
                Regex StateRg = new Regex("[a-zA-Z]");
                if (!StateRg.IsMatch(state))
                {
                    MessageBox.Show("Enter State in correct format");
                    return;
                }
                Regex CountryRg = new Regex("[a-zA-Z]");
                if (!CountryRg.IsMatch(country))
                {
                    MessageBox.Show("Enter Country in correct format");
                    return;
                }
                Regex regex = new Regex("[a-zA-Z0-9]{2,20}@[a-zA-z0-9]{2,7}.[a-zA-Z]");
                if (!regex.IsMatch(Email))
                {
                    MessageBox.Show("Enter Email in correct format");
                    return;
                }
                Regex regexzip = new Regex("[0-9]");
                if (!regexzip.IsMatch(zip))
                {
                    MessageBox.Show("Enter zip in correct format");
                    return;
                }
                string gender = "";
                if (radio_female.Checked)
                {
                    gender = "Female";
                }
                if (radio_male.Checked)
                {
                    gender = "Male";
                }
                string department = combo_Department.SelectedItem.ToString();

                if (department.Equals("BSCS"))
                {
                    m_student = new BSCS_student(roll, firstname, lastname, phone, city, country, state, zip, Email, father, gender);
                    BSCS_Students.Add(m_student);
                    MessageBox.Show("BSCS");
                }
                if (department.Equals("EE"))
                {
                    m_student = new EE_student(roll, firstname, lastname, phone, city, country, state, zip, Email, father, gender);
                    EE_Students.Add(m_student);
                    MessageBox.Show("EE");
                }
                if (department.Equals("ME"))
                {
                    m_student = new ME_student(roll, firstname, lastname, phone, city, country, state, zip, Email, father, gender);
                    ME_Students.Add(m_student);
                    MessageBox.Show("Me");
                }

            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_roll_get.Text))
                {
                    MessageBox.Show("Enter Students Roll No in Get box to load his/her information");
                    return;
                }
                else
                {
                    search(txt_roll_get.Text);
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void search(string desired_Roll)
        {
            string information = "";
            bool found = false;
            foreach(List<Students> list in M_list)
            {
                foreach(Students students in list)
                {
                    if (desired_Roll.Equals(Convert.ToString(students.Roll_no)))
                    {
                        information = "Student is\n" + "Name : " + students.First_name + " " + students.Last_name + "\nFather : " + students.Father_name
                            + "\nlives in : " + students.City + " " + students.State + " " + students.Country + " " + "\nEmail : " + students.Email +
                            "\nPhone : " + students.Phone_no + "\nDepartment : " + students.Department + "\nGender : " + students.Gender;
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("No Record of such student is availible");
                return;
            }
            MessageBox.Show(information);

        }

    }
}
