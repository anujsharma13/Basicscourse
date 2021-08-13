using System;

namespace Nonprimitive_datatypes
{
    class Program
    {
       public class example
        {
            public int x;       //default access specifier is private
            public int x1 = 10;
            public example()
            {
                this.x = 15;
            }
            public void showdata()
            {
                Console.WriteLine(x + " " + x1);
            }

        }
       public struct example1   // struct can only inherit interface not class,struct
        {
            public int x;       //default access specifier is private
                                // public int x1=10;  error cant initialize value directly we can only initialize static and const value
                                //struct members cannot be protected because we cannot inherit constructor
            public int x1;
          /*  public example1()
            {
                struct does not have parameter less constructor
            }*/
            public example1(int x)
            {
                this.x = 15;
                this.x1 = 13;  //if we does not ititialize all values in constructor in struct it shows error
            }
            public example1(int x,int x1)  //constructor overloading
            {
                this.x = x;
                this.x1 = x1;
            }
            public void showdata()
            {
                Console.WriteLine(x + " " + x1);
            }
        }
        enum example3:int       // enum cant be of char or string type bcz it is integer values to variables
        {
            x1,x2,x3,x4       // we cant assign value greater than 255 bcz range is max 255 in byte otherwise compile time error
        }
        static void Main(string[] args)
        {
            example obj = new example();        // also write it is var obj=new example();
            example1 obj1= new example1(5);
            example1 obj2 = new example1(5,6);
           /* example1 obj3;   object of struct can be create as this
            obj3.x = 10;
            example obj4;      object of class cannot be create as this
            obj4.x;*/
            obj.showdata();
            obj1.showdata();
            example3 x1 = example3.x1;      // if we print directly we get x1 so firstly we type cast it in int
            example3 x2 = example3.x2;
            example3 x3 = example3.x3;
            example3 x4 = example3.x4;
            Console.WriteLine((int)x1 + " " + (int)x2 + " " + (int)x3 + " " + (int)x4);
            Class1 obj4 = new Class1();         // different file accessible 
        }
    }
}