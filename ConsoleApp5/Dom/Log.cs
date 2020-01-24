using System.Collections.Generic;

namespace ConsoleApp5.Dom
{
    class Log
    {
        public string Header { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }

        public static Log FromLines(List<string> lines)
        {
            return new Log
            {
                Header = lines[0],
                Request = lines[1],
                Response = lines[2]
            };
        }
    }
}