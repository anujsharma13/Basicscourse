using System;

namespace Strings
{
    class Program
    {
        public static void fun()
        {
            unsafe
            {
                string s = "hello";
                string s1 = "hello";
                string s2 = new string("hello");
                string s3 = new string("hello");
                Console.WriteLine(s.CompareTo(s1));
                Console.WriteLine(s.GetHashCode());
                Console.WriteLine(s1.GetHashCode());
                Console.WriteLine(s2.GetHashCode());
                Console.WriteLine(s3.GetHashCode());
                if(s==s1 && s1==s2 && s2==s3)       // if the value is same than the address of all are same
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
                if(s.Equals(s1) && s1.Equals(s2) &&s2.Equals(s3))// both == same as equals
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
                s1 = s1 + "java";
                s = s + "java";
                Console.WriteLine("compare" + " " + s.CompareTo(s1));//0 bcz both are same
                Console.WriteLine("compare"+" "+s.CompareTo(s2));   // 1 bcz s is greater than s2
                Console.WriteLine("compare" + " " + s2.CompareTo(s)); // -1 bcz s2 is smaller than s

                s3 = s3 + "java";
                s2 = s2 + "java";
                if (s == s1 && s1 == s2 && s2 == s3)       // if the value is same than the address of all are same
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
                if (s.Equals(s1) && s1.Equals(s2) && s2.Equals(s3))// both == same as equals
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
                Console.WriteLine(object.ReferenceEquals(s, s1));       // true bcz shred pool momory
                Console.WriteLine(object.ReferenceEquals(s2, s3));      // false new address is assigned
            }
        }
        static void Main(string[] args)
        {
            fun();
            string s = "hello";
            string s2 = new string("hello");
            string s1, s3;
            s1 = s;
            s3 = s2;
            s = s + "java";
            s2 = s2 + "java";
            Console.WriteLine(s);   // in c# 
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            /*Console.WriteLine("Hello World!");
            string s = "hello java";            // the goes to pool memory
            string s1 = new string("java");         // with is help of new all objects goes to new memory address
            string s2 = "hello Java";
            string s3 = new string("java");
            Console.WriteLine(s[0]);
            //     s[0] = 'a';  error bcz string is immutable
            //   s1[0] = 'a';  error
            s = s + " java";//we can add anything but not delete and update
            s1 = s1 + " java";
            Console.WriteLine("this is {0} {1}", s, s1);//{0} is replced by s and {1} is replaces by s1
            char[] a= { 'a', 'b' };
            int[] a1= { 1, 2, 3, 4 };
            // join method
            string s4=string.Join(",", a);      //without new operator
            string s5 = string.Join(",", a1);
            Console.WriteLine(s4 + " java " + s5);
            var str1 = s5.Split(",");
            foreach(var i in str1)
            {
                Console.WriteLine(i);
            }
            // methods of string class
            string s6, s7;
            s6 = "Java";
            s7 = "String";
            s6.ToLower();
            Console.WriteLine(s6);
            s6.ToUpper();
            Console.WriteLine(s6);
           Console.WriteLine( s6.Substring(1));
          Console.WriteLine(s6.Substring(1, 2));
            Console.WriteLine(s6.Length); // it is not a method it is a integer variable
            s6.Trim();
            s6.AsMemory();
            //index starts from 0
            Console.WriteLine(s1.CompareTo(s3));// equal function check no for uppercase and lower case uppercase==lowercase
            Console.WriteLine(s6.Contains('v'));// it also return int 1 or 0
            Console.WriteLine(s1.Equals(s3));    // equal function check also for upper case and lower case int it retutrn boolean
            Console.WriteLine(s6.IndexOf('v')+1); // IT also return int 
            Console.WriteLine(s6.LastIndexOf('v') + 1);// it also return int
            Console.WriteLine(s6.IndexOfAny(a));    // it takes char array as input and return any of the inddex
            Console.WriteLine(s6.EndsWith("va"));      //check last character 
            Console.WriteLine(s6.EndsWith('c'));
            Console.WriteLine(s6.GetType());
            Console.WriteLine(s6.GetHashCode());
            string s8=s6.PadLeft(5);    //add padding and return new string
            Console.WriteLine(s8);
            Console.WriteLine(s6.StartsWith("ja"));


            // string with / character
            Console.WriteLine("c:\\projects");
            Console.WriteLine(@"c:\projects");  // here no need to use \\ twice we have used @ instead of that


            // difference bw parse and try parse
            // if string is 123ch integers+char parse return exception
            // try parse return true or false if it can be converted it convert it otherwise set it to 0
            string str12="123ca";
            int st = 0;
            int.TryParse(str12,out st); 
            Console.WriteLine();
            Console.WriteLine(int.Parse(str12));    // exception*/
        }
    }
}
