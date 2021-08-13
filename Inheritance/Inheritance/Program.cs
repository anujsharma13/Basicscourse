using System;

namespace classes
{
    class A
    {
        public int val1a, val2a;
        public static int x1;
        public A() : this(10, 20, 30)   // it means if user call default constructor without calling parametrized constructor assign these values
        {
            Console.WriteLine("Default A");
        }
        public A(int a, int b, int c)
        {
            val1a = a;
            val2a = b;
            x1 = c;
            Console.WriteLine("Parametrized A");
        }
        public void funa()
        {
            Console.WriteLine("funa");
        }
    }
    class B : A
    {
        public int val1b, val2b;
        public B()
        {
            Console.WriteLine("Default B");
        }
        public B(int a, int b) : base()
        {
            val1b = a;
            val2b = b;
            Console.WriteLine("Parametrized B");
        }
        public new void funa()          // if we override the method then we have to use new operator
        {
            Console.WriteLine("funa class b");
        }
        public void funb()
        {
            Console.WriteLine("funb");
        }
    }
    class C : B
    {
        public int val1c, val2c;
        public C()
        {
            Console.WriteLine("Default C");
        }
        public C(int a, int b)
        {
            val1c = a;
            val2c = b;
            Console.WriteLine("Parametrized C");
        }
        public void func()
        {
            Console.WriteLine("func");
        }
    }
    class Program
    {
        static void Main(string[] args)// string args [] not compulsory
        {
            // C obj = new C();
            // A obj1 = new B();     // correct parent to child
            //B obj1=new A();  error child to parent not
            // it is called variable of base class and reference of parent class
            // Console.WriteLine(obj1.val1a);
            // obj1.funa();   // here we cant call obj1.funb() even if we provide a reference of class b we can just call the inherited methods of a
            // even if the class b has funa method(override) but still it call the base class methods
           
        }
    }
}
