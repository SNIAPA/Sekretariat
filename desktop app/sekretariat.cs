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
        public ObservableCollection<Student> students;
        public ObservableCollection<Teacher> teachers;
        public ObservableCollection<Group>   groups;


        public class Person
        {
            Guid id = Guid.NewGuid();
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
            Guid id = Guid.NewGuid();
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
            students = new ObservableCollection<Student>();
            teachers = new ObservableCollection<Teacher>();
            groups = new ObservableCollection<Group>();
        }


    }
}
