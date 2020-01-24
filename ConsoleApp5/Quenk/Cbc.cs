using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp5.Dom;

namespace ConsoleApp5.Quenk
{
    class Cbc
    {
        public async Task Process()
        {
            var sender = new Sender();

            var cb = new Cb("D:/txt.txt");

            var logs = new List<Log>();
            await foreach (Log log in cb.GetNext())
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