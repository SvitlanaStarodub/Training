using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ILogger
{
    class AggregLogger
    {
        private List<ILogger> _loggers;

        public AggregLogger(List<ILogger> loggers)
        {
            _loggers = loggers;
        }

        public void Log(string text)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(text);
            }
        }

        
    }
}
