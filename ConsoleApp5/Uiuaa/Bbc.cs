using System.Collections.Generic;
using System.Linq;
using ConsoleApp5.Dom;

namespace ConsoleApp5.Uiuaa
{
    class Bbc
    {
        public void Process()
        {
            var sender = new Sender();

            var bb = new Bb("D:/txt.txt");

            var logs = new List<Log>();
            foreach (Log log in bb.GetNext())
            {
                if (logs.Count == 10)
                {
                    sender.SendLogs(logs);
                    logs.Clear();
                }

                logs.Add(log);
            }

            if (logs.Any())
            {
                sender.SendLogs(logs);
            }
        }
    }
}