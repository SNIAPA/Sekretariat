using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections.ObjectModel;

namespace desktop_app
{
    class School
    {
        public ObservableCollection<Student> students;
        public ObservableCollection<Teacher> teachers;
        public ObservableCollection<Employee> employees;
        public ObservableCollection<Group> groups;

        public class Person
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string mothers_name { get; set; }
            public string fathers_name { get; set; }
            public string gender { get; set; }
            public string pesel { get; set; }
            public string birth_date { get; set; }

            

        }

        public class Group {
            string name { get; set; }
        }

        public class Student : Person
        {
            Group school_class { get; set;}
            List<Group> groups { get; set;}
        }

        public class Employee : Person
        {
            Bitmap photo { get; set; }
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
            students = new ObservableCollection<Student>();
            teachers = new ObservableCollection<Teacher>();
            employees = new ObservableCollection<Employee>();
            groups = new ObservableCollection<Group>();
        }

    }
}
