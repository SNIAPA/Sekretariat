using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Data;
using System.Reflection;
using System.Diagnostics;

namespace desktop_app
{
    class School
    {

        

        public DataTable students;
        public DataTable teachers;
        public DataTable groups;
        public DataTable employees;

        private DataTable CreateEmptyDataTable(Type myType)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in myType.GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }

            return dt;
        }

        public class Person
        {
            public int id { get; set; }
            public string firstName { get; set; }
            public string secondName { get; set; }
            public string lastName { get; set; }
            public string mothersName { get; set; }
            public string maidenName { get; set; }
            public string fathersName { get; set; }
            public string gender { get; set; }
            public string pesel { get; set; }
            public string photo { get; set; }
            public DateTime birthDate { get; set; }
            public Person() { }
        }

        public class Group
        {
            public int id { get; set; }
            public string name { get; set; }
            public Group() { }
        }

        public class Student : Person
        {
            public string grade { get; set;}
            public string groups { get; set;}
        }

        public class Employee : Person
        {
            public string jobPosition { get; set; }
            public string workHours { get; set; }
            public DateTime employmentDate { get; set; }

        }


        public class Teacher : Employee
        {
            public string supervisedClasses { get; set; }
            public string subjects { get; set; } 

        }


        public School()
        {
            students  = CreateEmptyDataTable(typeof(Student));
            groups    = CreateEmptyDataTable(typeof(Group));
            teachers  = CreateEmptyDataTable(typeof(Teacher));
            employees = CreateEmptyDataTable(typeof(Employee));

            students.Columns["photo"].DefaultValue = "https://www.kindpng.com/picc/m/451-4517876_default-profile-hd-png-download.png";
            students.Columns["birthDate"].DefaultValue = DateTime.Now;
            students.Columns["id"].AutoIncrement = true;
            groups.Columns["id"].AutoIncrement = true;
            teachers.Columns["photo"].DefaultValue = "https://www.kindpng.com/picc/m/451-4517876_default-profile-hd-png-download.png";
            teachers.Columns["id"].AutoIncrement = true;
            teachers.Columns["birthDate"].DefaultValue = DateTime.Now;
            teachers.Columns["employmentDate"].DefaultValue = DateTime.Now;
            employees.Columns["photo"].DefaultValue = "https://www.kindpng.com/picc/m/451-4517876_default-profile-hd-png-download.png";
            employees.Columns["id"].AutoIncrement = true;
            employees.Columns["birthDate"].DefaultValue = DateTime.Now;
            employees.Columns["employmentDate"].DefaultValue = DateTime.Now;


        }


    }
}
