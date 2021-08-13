using System;
using System.IO;

namespace Fileinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "e:\\abhi.txt";
            string path = "d:\\abhi.txt";
            // File info class
            FileInfo obj = new FileInfo(path);      // creates a reference to file
            FileStream obj1=obj.Create();  // creates actual file
            obj1.Close();// only after closing it we can delete file otherwise exception
            obj1.Close();
            //obj.CopyTo(path1);  // also copy will work only after closing file  because at time one resource can access file
            //   obj1.CopyTo(obj2);
           // obj.Delete();
            if (obj.Exists)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            // file info does not contain this method obj.ReadAlltext();
            Console.WriteLine( obj.Length);
        }
    }
}
