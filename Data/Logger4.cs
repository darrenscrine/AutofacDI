using System.Diagnostics;

namespace Data
{
    public class Logger4 : ILogger
    {
        public void Log(string message)
        {
            Trace.Write("Written with 'Logger3':" + message);
        }
    }
}
