using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Data
{
    public class Logger2 : Data.ILogger
    {
        public void Log(string message)
        {
            Trace.Write("Written with 'Logger2':" + message);
        }
    }
}
