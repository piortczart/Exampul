using System;
using System.Collections.Generic;
using System.IO;
using ConsoleApp5.Dom;

namespace ConsoleApp5.Oink
{
    class Ab : IDisposable
    {
        private A _a;

        public Ab(string path)
        {
            _a = new A(path);
        }

        public Log GetNext()
        {
            var lines = new List<string>();
            while (true)
            {
                string l = _a.GetNextLine();
                if (l == null)
                {
                    return null;
                }

                if (String.IsNullOrWhiteSpace(l))
                {
                    return Log.FromLines(lines);
                }

                lines.Add(l);
            }
        }

        public void Dispose()
        {
            _a?.Dispose();
        }
    }
}