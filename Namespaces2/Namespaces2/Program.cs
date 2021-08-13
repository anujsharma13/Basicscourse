using System;
using p=practice.classa.program1.class1;
using p1 = practice.classa.program2.class1;
namespace practice
{
    namespace classa        // we can declare a namespace with same name any no of time in a function
    {
        namespace program1
        {
            public class class1
            {
                public static void fun()
                {
                    Console.WriteLine("hello");
                }
            }
        }
    }
    namespace classa
    {
        namespace program2
        {
            public class class1
            {
                public static void fun()
                {
                    Console.WriteLine("hello");
                }
            }
        }
    }
    class Program
    {
        public static void fun()
        {
            //class1.fun(); error bcz both have same name but belongs to different namespace
            //class1.fun();
        }
        static void Main(string[] args)
        {
            
        }
    }
}
