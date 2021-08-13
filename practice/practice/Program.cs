using System;
using p=practice.classa;

namespace practice
{
    namespace classa        // we can declare a namespace with same name any no of time in a function
    {
        public class class1
        { 
            public static void fun()
            {
                Console.WriteLine("hello");
            }
        }
    }
    namespace classa
    {
        public class class2
        {
            public static void fun()
            {
                Console.WriteLine("hello");
            }
        }
    }
    class Program
    {
      
        public static void fun()
        {
            p.class1.fun();
            p.class2.fun();
        }
        static void Main(string[] args)
        {
            
        }
    }
   
}
