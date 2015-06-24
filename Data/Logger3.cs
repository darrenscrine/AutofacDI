using System.Diagnostics;

namespace Data
{
    public class Logger3 : ILogger
    {
        public void Log(string message)
        {
            Trace.Write("Written with 'Logger3':" + message);
        }
    }
}
