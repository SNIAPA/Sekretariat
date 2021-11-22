using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;



namespace desktop_app
{
    class szkola
    {

        List<student> students { get; set; }

        List<teacher> teachers { get; set; }

        List<employee> emplayeess { get; set; }

        class person
        {
            string first_name { get; set; }
            string last_name { get; set; }
            string mothers_name { get; set; }
            string fathers_name { get; set; }
            string gender { get; set; }
            string pesel { get; set; }
            DateTime birth_date { get; set; }
        }

        class group {
            string name { get; set; }
        }

        class student : person
        {
            group school_class { get; set;}
        }

        class employee : person
        {
            Bitmap photo { get; set; }
            string job_position { get; set; }
        }

        class teacher : employee
        {
            string supervising { get; set; }
            List<string> subjects { get; set; }
            List<KeyValuePair<group, int>> godziny {get; set;}
            DateTime emplayment_date { get; set; }
        }
    }
}
