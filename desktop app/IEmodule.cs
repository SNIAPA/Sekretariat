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

        public bool import()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            string rawFile;

            if (ofd.ShowDialog() == true)
                rawFile = File.ReadAllText(ofd.FileName);
            else
                return false;

            JsonConvert.DeserializeObject<School>(rawFile);

            return true;
        }

        public void export()
        {

        }
    }
}
