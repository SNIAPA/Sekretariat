using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections.ObjectModel;



namespace desktop_app
{
    class School
    {
        public ObservableCollection<School.Student> students;
        public class Person
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string mothers_name { get; set; }
            public string fathers_name { get; set; }
            public string gender { get; set; }
            public string pesel { get; set; }
            DateTime birth_date { get; set; }
        }

        class Group {
            string name { get; set; }
        }

        public class Student : Person
        {
            Group school_class { get; set;}
        }

        class Employee : Person
        {
            Bitmap photo { get; set; }
            string job_position { get; set; }
        }

        class Teacher : Employee
        {
            string supervising { get; set; }
            List<string> subjects { get; set; }
            List<KeyValuePair<Group, int>> godziny {get; set;}
            DateTime emplayment_date { get; set; }
        }
    }
}
