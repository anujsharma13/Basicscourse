using System;
using System.IO;
namespace Directoryfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"e:\folder");
            var obj3 = Directory.GetFiles(@"e:\android");// it prints all fils in this directory
           var obj= Directory.GetFiles(@"e:\android","*.exe*"); //*extension*
            var obj1 = Directory.GetFiles(@"e:\android", "*.*");// it print all files in the directory
            var obj2 = Directory.GetFiles(@"e:\android", "*.*", SearchOption.AllDirectories);// it prints all the files in the current directory and all sub directories
            foreach(var i in obj)
            {
                Console.WriteLine(i);
            }
            foreach (var i in obj1)
            {
                Console.WriteLine(i);
            }
            //foreach (var i in obj2)
            //{
            //  Console.WriteLine(i);
            // }
            var dir = Directory.GetDirectories(@"e:\android"); // it prints all folders in the file
            var dir1 = Directory.GetDirectories(@"e:\android","*.*");// all directories in this folder this and above are same
            var dir2 = Directory.GetDirectories(@"e:\android","*.*",SearchOption.AllDirectories);
            foreach (var i in dir)
            {
                Console.WriteLine(i);
            }
            foreach (var i in dir1)
            {
                Console.WriteLine(i);
            }
            //foreach (var i in dir2)
            //{
            //   Console.WriteLine(i);
            // }
            Console.WriteLine(Directory.Exists(@"c:\android"));
        }
    }
}
