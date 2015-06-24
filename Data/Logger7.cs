using System.Diagnostics;

namespace Data
{
    public class Logger7 : ILogger
    {
        public void Log(string message)
        {
            Trace.Write("Written with 'Logger7':" + message);
        }
    }
}
