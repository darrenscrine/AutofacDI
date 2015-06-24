using System.Diagnostics;

namespace Data
{
    public class Logger2 : ILogger
    {
        public void Log(string message)
        {
            Trace.Write("Written with 'Logger2':" + message);
        }
    }
}
