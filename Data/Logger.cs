using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Data
{
    public class Logger : Data.ILogger
    {
        public void Log(string message)
        {
            Trace.Write("Written with 'Logger':" + message);
        }
    }
}
