using System;
using System.Text;

namespace StringBuilderclass
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder obj = new StringBuilder();
            obj.Append("a");
            obj.Append("ab");
            Console.WriteLine(obj);
            obj[0] = 'c';
            StringBuilder obj1;     // it is not a object it is a reference we cant use it directly
            obj1 = obj;
            char[] a1 = new char[3] { 'a','b', 'c' };
            obj1.AppendJoin(",", a1);
            string obj2="abc";      // as strings are immutable so we not use new to call constructor it is known as string literal
            string obj3 = new string("av");     // we can also create it like this it is known as new string object
            //StringBuilder obj1 = "ava";   // it shows error bcz we have to use new keyword to allocating memory
        }
    }
}
