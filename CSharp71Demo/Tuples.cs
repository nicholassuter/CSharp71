using System;
using System.IO;
using System.Linq;

namespace CSharp71Demo
{
    class Tuples
    {
        void ParseFiles()
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory())
                .Select(f => new FileInfo(f))
                .Where(fi => fi.Length > 50)
                .Select(f => (f.FullName, f.Length)); // verbous !!

            foreach (var file in files)
            {
                Console.WriteLine($"{file.FullName}, {file.Length}");
            }
        }
    }
}
