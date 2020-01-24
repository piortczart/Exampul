using System;
using System.IO;

namespace ConsoleApp5.Oink
{
    class A : IDisposable
    {
        private readonly Stream _fileStream;
        private readonly StreamReader _streamReader;

        public A(string path)
        {
            _fileStream = File.OpenRead(path);
            _streamReader = new StreamReader(_fileStream);
        }

        public string GetNextLine()
        {
            return _streamReader.ReadLine();
        }

        public void Dispose()
        {
            _fileStream?.Dispose();
            _streamReader?.Dispose();
        }
    }
}