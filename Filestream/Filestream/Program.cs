using System;
using System.IO;

namespace Filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("d:\\abhi.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);
            string s = "hello java";
            int i;
            for (i=0;i<s.Length;i++)
            {
                f.WriteByte((byte)(s[i]));
            }
            byte[] a = new byte[5] { 1, 2, 3, 4, 5 };
            f.Write(a);     // In file stream we can only write a singlw byte or array of byte other wise to write a string we need to use streamwriter
            StreamWriter st = new StreamWriter(f);// this class writes a line into a file
            st.WriteLine("hello java  hello java hello java hello java hello java hello java");
            StreamReader s2 = new StreamReader(f);

            string readline = s2.ReadLine();        // it reads a single line
            Console.WriteLine(readline);
            string wholetext = s2.ReadToEnd();      // it reads coplete text
            Console.WriteLine(wholetext);

            string line = "";
            i = 0;
            while((line=s2.ReadLine())!=null)       // read specific lines
            {
                Console.WriteLine("line "+i);
                Console.WriteLine(line);
            }
            st.Close();         // if we dont close the file the data is not inserted to files
            s2.Close();
            f.Close();
        }
    }
}
