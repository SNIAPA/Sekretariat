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

        

        public static SchoolView import()
        {
            //TODO convert to list
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Json files (*.json)|*.json";

            if (ofd.ShowDialog() != true)
                return new SchoolView();

            string rawFile = File.ReadAllText(ofd.FileName);

            return JsonConvert.DeserializeObject<SchoolView>(rawFile);
        }

        public static bool export(SchoolView school)
        {
            //TODO convert to list
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Json files (*.json)|*.json";

            if (sfd.ShowDialog() != true)
                return false;

            File.WriteAllText(sfd.FileName, JsonConvert.SerializeObject(school));
            return true;

        }
    }
}
