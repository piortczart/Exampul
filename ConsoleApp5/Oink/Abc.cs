using System.Collections.Generic;
using ConsoleApp5.Dom;

namespace ConsoleApp5.Oink
{
    class Abc
    {
        public void Process()
        {
            var sender = new Sender();

            using (var ab = new Ab("D:/txt.txt"))
            {
                bool isDone = false;
                while (!isDone)
                {
                    var logs = new List<Log>();
                    while (logs.Count < 10)
                    {
                        Log log = ab.GetNext();
                        if (log == null)
                        {
                            isDone = true;
                            break;
                        }

                        logs.Add(log);
                    }

                    sender.SendLogs(logs);
                }
            }
        }
    }
}