﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ILogger
{
    class ConsoleLogger : ILogger
    {
         
        public void Log (string text)
        {
            Console.WriteLine(text);
            

        }
       

    }
}
