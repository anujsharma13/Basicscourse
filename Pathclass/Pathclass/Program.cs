using System;
using System.IO;
namespace Pathclass
{
    class Program
    {
        static void Main(string[] args)
        {
            // using string it is very typical
            string s= @"c:\android\helloworld.java";
            int index = s.IndexOf('.');
            string extension = s.Substring(index);

            //using path class
            Console.WriteLine(Path.GetExtension(s));
            Console.WriteLine(Path.GetFileName(s));
            Console.WriteLine(Path.GetFileNameWithoutExtension(s));
            Console.WriteLine(Path.GetDirectoryName(s));
        }
    }
}
