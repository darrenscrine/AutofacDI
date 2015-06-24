using System.Diagnostics;

namespace Data
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Trace.Write("Written with 'Logger':" + message);
        }
    }
}
