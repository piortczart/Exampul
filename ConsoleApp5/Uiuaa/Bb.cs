using System;
using System.Collections.Generic;
using ConsoleApp5.Dom;

namespace ConsoleApp5.Uiuaa
{
    class Bb
    {
        private B _b;

        public Bb(string path)
        {
            _b = new B(path);
        }

        public IEnumerable<Log> GetNext()
        {
            var lines = new List<string>();
            foreach (string line in _b.GetNextLine())
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    yield return Log.FromLines(lines);
                    lines.Clear();
                }
                else
                {
                    lines.Add(line);
                }
            }
        }
    }
}