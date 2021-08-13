using System;
using System.IO;
namespace Fileapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "d:\\abhi.txt";
            string path1 = "e:\\abhi.txt";
            // File.Copy("d:\\abhi.txt", "e:\\abhi.txt");      //if file already exixts it shows error   src to destination
            FileStream obj=File.Create(path);       //File.create() returns an object of class Filestream
            obj.Close();        // if we dont close it than we cant apply copy operation on it
           //File.Move(path, path1);  //if file already exist than there is exception
            File.Copy("d:\\abhi.txt", "e:\\abhi.txt", true);// true means override if the file is alrady present
            File.Move(path, path1, true);
            File.WriteAllText(path, "hello java");
            if (File.Exists(path))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            var x1 = File.ReadAllLines(path);
            foreach (var it in x1)
            {
                Console.WriteLine(it);
            }
            // File.Delete(path);
            string []arr = new string[5]{ "a","b","c","d","e"};
            File.AppendAllLines(path, arr);         // append each string in new line
            string []arr1=new string[5]{ "a","b","c","d","e"};
            File.WriteAllLines(path,arr1);      // it removes the old content and write this content
            Console.WriteLine(File.GetLastAccessTime(path));// last access of the file
            Console.WriteLine(File.GetLastWriteTime(path));  // it tells the last write time
            var obj2=File.ReadAllBytes(path);

        }
    }
}
