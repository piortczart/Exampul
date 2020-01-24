using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5.Dom
{
    class Sender
    {
        private int _i;

        public void SendLogs(IEnumerable<Log> logs)
        {
            _i += logs.Count();
            Console.WriteLine($"Sending logs, total logs count: {_i}");
        }
    }
}