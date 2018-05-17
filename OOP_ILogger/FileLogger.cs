using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_ILogger
{
    class FileLogger : ILogger
    {
        public void Log(string text)
        {

            string path = @"C:\temp\FileLog.txt";
            //if (!File.Exists(path))
            //{
            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        sw.WriteLine(text);
            //    }
            //}
            //else
            //{
                File.WriteAllText(path, text+"a new version");

            //}

            

    }

       
    }
}
