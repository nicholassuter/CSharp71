using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharp71Demo
{
    class PatternMatching
    {
        public static void DoStuff()
        {
            Console.WriteLine(MyToString("Hello"));
            Console.WriteLine(MyToString(42));
            Console.WriteLine(MyToString(new DirectoryInfo(Directory.GetCurrentDirectory())));
        }

        private static string MyToString<T>(T input)
        {
            switch (input)
            {
                case int i:
                    return $"this is an int : {i}";
                case string s:
                    return $"this is a string : {s}";
                default:
                    return $"don't know what this is : {input.GetType()}";
            }
        }
    }
}
