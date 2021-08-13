using System;

namespace pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            unsafe
            {
                int a = 10;
                int* p;
                p = &a;
                Console.WriteLine((int)p);
                Console.WriteLine(*p);
                char c = 'a';
                char* p1 = &c;      // every time address is different bcz c# change the adddress
                Console.WriteLine((int)p1);
                Console.WriteLine(*p1);
                string s = "hello";
                void* p2 = &c;
                void* p3 = &a;
                Console.WriteLine((int)p2);
                //Console.WriteLine(*p2);

                int b = 10;
                fixed(char* pt = s)       // fixed can only be used inside undafe block  fixed is uded to get address of string
                {                        // we cant use int* in fixed
                    Console.WriteLine((int)pt);
                }
                fixed (int* pt1 = &b)       // fixed can only be used inside undafe block  fixed is uded to get address of string
                {                        // we cant use int* in fixed
                    Console.WriteLine((int)pt1);
                }
                // finding the adress of string
            }
        }
    }
}
