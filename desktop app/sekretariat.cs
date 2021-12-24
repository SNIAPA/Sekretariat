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
            public Guid id { get; set; } = Guid.NewGuid();
            public string first_name { get; set; }
            public string second_name { get; set; }
            public string last_name { get; set; }
            public string mothers_name { get; set; }
            public string maiden_name { get; set; }
            public string fathers_name { get; set; }
            public string gender { get; set; }
            public string pesel { get; set; }
            public string photo { get; set; } = "https://www.pphfoundation.ca/wp-content/uploads/2018/05/default-avatar.png";
            public DateTime birth_date { get; set; }
            public Person() { }
        }

        public class Group
        {
            public Guid id { get; set; } = Guid.NewGuid();
            string name { get; set; }
        }

        public class Student : Person
        {
            Group school_class { get; set;}
            List<Group> groups { get; set;}
        }

        public class Employee : Person
        {
            string job_position { get; set; }
        }

        public class Teacher : Employee
        {
            string supervising { get; set; }
            List<string> subjects { get; set; }
            List<KeyValuePair<Group, int>> godziny {get; set;}
            DateTime employment_date { get; set; }
        }


        public School()
        {
            students = CreateEmptyDataTable(typeof(Student));
            teachers = CreateEmptyDataTable(typeof(Teacher));
            groups   = CreateEmptyDataTable(typeof(Group));
        }


    }
}
