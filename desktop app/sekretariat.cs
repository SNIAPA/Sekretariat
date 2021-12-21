using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace desktop_app
{
    class School
    {

        public class Person
        {

            public string first_name { get; set; }
            public string last_name { get; set; }
            public string mothers_name { get; set; }
            public string fathers_name { get; set; }
            public string gender { get; set; }
            public string pesel { get; set; }
            public string birth_date { get; set; }
            public string photo { get; set; } = "https://www.pphfoundation.ca/wp-content/uploads/2018/05/default-avatar.png";
            public DateTime data_ur { get; set; }
            public Person() { }
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
            string job_position { get; set; }
        }

        public class Teacher : Employee
        {
            string supervising { get; set; }
            List<string> subjects { get; set; }
            List<KeyValuePair<Group, int>> godziny {get; set;}
            DateTime employment_date { get; set; }
        }

    }

    class SchoolView
    {
        public ObservableCollection<School.Student> students;
        public ObservableCollection<School.Teacher> teachers;
        public ObservableCollection<School.Group> groups;

        public SchoolView()
        {
            students = new ObservableCollection<School.Student>();
            teachers = new ObservableCollection<School.Teacher>();
            groups = new ObservableCollection<School.Group>();
        }

    }
}
