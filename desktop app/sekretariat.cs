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
            public string name { get; set; }
            public Group() { }
        }

        public class Student : Person
        {
            public Group grade { get; set;}
            public List<Group> groups { get; set;}
        }

        public class Employee : Person
        {
            public string jobPosition { get; set; }
        }

        public class Teacher : Employee
        {
            public Group supervisedClass { get; set; }
            public List<string> subjects { get; set; }
            public List<KeyValuePair<Group, int>> workHours {get; set;}
            public DateTime employmentDate { get; set; }
            public Teacher() { }
        }


        public School()
        {
            students = CreateEmptyDataTable(typeof(Student));
            groups   = CreateEmptyDataTable(typeof(Group));
            teachers = CreateEmptyDataTable(typeof(Teacher));

            students.Columns["photo"].DefaultValue = "https://moonvillageassociation.org/wp-content/uploads/2018/06/default-profile-picture1.jpg";
            students.Columns["birthDate"].DefaultValue = DateTime.Now;
            students.Columns["id"].DefaultValue = Guid.NewGuid();
            groups.Columns["id"].DefaultValue = Guid.NewGuid();
            teachers.Columns["photo"].DefaultValue = "https://moonvillageassociation.org/wp-content/uploads/2018/06/default-profile-picture1.jpg";
            teachers.Columns["birthDate"].DefaultValue = DateTime.Now;
            teachers.Columns["employmentDate"].DefaultValue = DateTime.Now;
        }


    }
}
