using System;

namespace valueandreferencetype
{

    /*public static void fun(int x)
    {

    }*/    // we cant directly declare functions in namespace we can only declare the classes in a namespace
    public class example
    {
        public int x;
    }
    public struct example1
    {
        public int x;
    }
    class Program
    {
        public static void fun(ref int x)
        {
            x++;
        }
        public static void fun(int x)       // we can overload ref and non ref functions with same name
        {
            x++;
        }
        public static void fun1(int x)       // we can overload ref and non ref functions with same name
        {
            x++;
        }
        public static void fun1(out int x)       // we can overload ref and non ref functions with same name
        {
            x = 1;      // if the value is undefined firstly define it than apply operations on it
            x++;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = x;
            y++;
            Console.WriteLine(x+" "+y);
            int[] a = new int[3] { 1, 2, 3 };
            int[] a1 = new int[3];
            a1 = a;                     // in cpp it shows the garbage value at the unknown access of element in array in c# it shows the arrayindexoutofbound
            a1[0] = 4;
            Console.WriteLine(a);       // this will print the type of array System.Int32
            Console.WriteLine(a1) ;
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
            foreach(var i in a1)
            {
                Console.WriteLine(i);
            }

            // call by value and call by reference 
            int n = 10;
            fun(ref n);         //call by reference
            Console.WriteLine(n);
            fun(n);             //call by value
            Console.WriteLine(n);
            int m;
            //fun1(ref m);            // un declared value cant be passed as value or reference it shows error
            fun1(out m);            // we can also pass un declared value in out variable



            // value and reference type difference bw class and object
            // class reference type the new created object is also pointing to last object
            example obj = new example();
            obj.x = 10;
            example obj1 = obj;
            obj.x++;
            Console.WriteLine(obj.x);   //11
            Console.WriteLine(obj1.x);  //11      
            //struct is value type the new created object is a copy of prev object
            example1 obj2 = new example1();
            obj2.x = 10;
            example1 obj3 = obj2;
            obj3.x++;
            Console.WriteLine(obj2.x);  //10
            Console.WriteLine(obj3.x);  //11
        }
    }
}