using System.Collections.Generic;
using System.IO;

namespace ConsoleApp5.Uiuaa
{
    class B
    {
        private readonly string _path;

        public B(string path)
        {
            _path = path;
        }

        public IEnumerable<string> GetNextLine()
        {
            using (FileStream s = File.OpenRead(_path))
            {
                using (var y = new StreamReader(s))
                {
                    while (true)
                    {
                        string line = y.ReadLine();
                        if (line == null)
                        {
                            yield break;
                        }

                        yield return line;
                    }
                }
            }
        }
    }
}