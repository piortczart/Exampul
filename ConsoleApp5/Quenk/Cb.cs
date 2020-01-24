using System;
using System.Collections.Generic;
using ConsoleApp5.Dom;

namespace ConsoleApp5.Quenk
{
    class Cb
    {
        private C _c;

        public Cb(string path)
        {
            _c = new C(path);
        }

        public async IAsyncEnumerable<Log> GetNext()
        {
            var lines = new List<string>();
            await foreach (string line in _c.GetNextLine())
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