using System.Diagnostics;

namespace Data
{
    public class Logger7 : ILogger
    {
        private string _message = "";

        public string GetMessage()
        {
            return _message;
        }

        public void Log(string message)
        {
            _message = "Written with 'Logger7':" + message;
            Trace.Write(_message);
        }
    }
}
