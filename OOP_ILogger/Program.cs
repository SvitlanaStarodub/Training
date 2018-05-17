using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ILogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "I am happy!";
           ConsoleLogger consoleLogger = new ConsoleLogger();
           FileLogger fileLogger = new FileLogger();
           AggregLogger aggregLogger = new AggregLogger(new List<ILogger> {consoleLogger, fileLogger});

           // consoleLogger.Log(text);
           // fileLogger.Log(text);

            aggregLogger.Log(text);





        }

        
    }
}
