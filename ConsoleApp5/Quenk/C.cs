using System.Collections.Generic;
using System.IO;

namespace ConsoleApp5.Quenk
{
    class C
    {
        private readonly string _path;

        public C(string path)
        {
            _path = path;
        }

        public async IAsyncEnumerable<string> GetNextLine()
        {
            using (FileStream s = File.OpenRead(_path))
            {
                using (var y = new StreamReader(s))
                {
                    while (true)
                    {
                        string line = await y.ReadLineAsync();
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