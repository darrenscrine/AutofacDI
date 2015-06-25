using System.Diagnostics;

namespace Data
{
    public class Logger : ILogger
    {
        private string _message = "";

        public string GetMessage()
        {
            return _message;
        }

        public void Log(string message)
        {
            _message = "Written with 'Logger':" + message;
            Trace.Write(_message);
        }
    }
}
