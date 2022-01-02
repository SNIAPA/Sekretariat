using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.IO;
using Newtonsoft.Json;

namespace desktop_app
{
    class IEmodule
    {
        public static School import()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Json files (*.json)|*.json";

            if (ofd.ShowDialog() != true)
                return new School();

            string rawFile = File.ReadAllText(ofd.FileName);

            return JsonConvert.DeserializeObject<School>(rawFile);
        }

        public static bool export(School school)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Json files (*.json)|*.json";

            if (sfd.ShowDialog() != true)
                return false;

            School eSchool = school;


            File.WriteAllText(sfd.FileName, JsonConvert.SerializeObject(school));
            return true;

        }
    }
}
