﻿using System.Diagnostics;

namespace Data
{
    public class Logger5 : ILogger
    {
        public void Log(string message)
        {
            Trace.Write("Written with 'Logger3':" + message);
        }
    }
}