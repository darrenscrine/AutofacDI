﻿using System.Diagnostics;

namespace Data
{
    public class Logger6 : ILogger
    {
        private string _message = "";

        public string GetMessage()
        {
            return _message;
        }

        public void Log(string message)
        {
            _message = "Written with 'Logger6':" + message;
            Trace.Write(_message);
        }
    }
}
