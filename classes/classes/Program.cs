using System;

namespace classes
{
    class A
    {
        public int val1a, val2a,val3a;
        public static int x1;
    static A()
    {
                //val1a=10; we cant access the non static members of class in static constructor
                // static constructor is called by clr not by object of class thats why it is always parameter less
            Console.WriteLine("static constructor");
            x1 = 10;
            Console.WriteLine(x1);
    }
     //static A(int x)      a class have only one static constructor we cant overload it
     //{

     //}
     public A()
      {
               // A(10, 20, 30); //error we cant use it like this we have to use :this(10,20,30) above
            Console.WriteLine("default constructor");
      }
     public A(int x,int y,int z)
      {
            Console.WriteLine("parametrized constructor");
            this.val1a = x;
            this.val2a = y;
            this.val3a = z;
            //this.x1 = z; error cant use this with static
            x1 = 20;
            Console.WriteLine(x+" "+y+" "+x1);
      }
    }
    class Program
    {
        static void Main(string[] args)// string args [] not compulsory
        {
            A obj = new A();    // firstly static constructor called than default 
            A obj1 = new A(10, 20, 30);
            Console.WriteLine(A.x1);
        }
    }
}
