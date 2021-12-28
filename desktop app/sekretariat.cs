using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Data;
using System.Reflection;

namespace desktop_app
{
    class School
    {
        public DataTable students;
        public DataTable teachers;
        public DataTable groups;

        private static DataTable CreateEmptyDataTable(Type myType)
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
            public Guid id { get; set; }
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
            public Guid id { get; set; }
            string name { get; set; }
        }

        public class Student : Person
        {
            Group grade { get; set;}
            List<Group> groups { get; set;}
        }

        public class Employee : Person
        {
            string jobPosition { get; set; }
        }

        public class Teacher : Employee
        {
            string supervising { get; set; }
            List<string> subjects { get; set; }
            List<KeyValuePair<Group, int>> godziny {get; set;}
            DateTime employmentDate { get; set; }
        }


        public School()
        {
            students = CreateEmptyDataTable(typeof(Student));
            teachers = CreateEmptyDataTable(typeof(Teacher));
            groups   = CreateEmptyDataTable(typeof(Group));

            students.Columns["photo"].DefaultValue = "https://moonvillageassociation.org/wp-content/uploads/2018/06/default-profile-picture1.jpg";
            //students.Columns["idbirthDate"].DefaultValue = DateTime.Now;
        }


    }
}
