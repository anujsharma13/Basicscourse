using System;
using System.IO;
namespace DirectoryInfofile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo obj = new DirectoryInfo(@"c:\newfolder1");
           var a= obj.GetDirectories();
        }
    }
}
