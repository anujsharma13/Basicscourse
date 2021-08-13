using System;

namespace Basics
{
    
    /*
Why does CLR create a new object instead of modifying the existing object?

Before going to answer this question, first we need to know the data structure 
which is used to store the string in memory. As we know that the string is a collection
of characters, Array data structure is used to store the string into memory in the form 
of character array.

Array

Array is a data structure which is used to store the collection of elements
Array size is defined on creation itself. We cannot modify the size of the
array dynamically. 
why strings are immutable in c# 
Reason 1 - Array Data structure

Since array is used to store string values, CLR needs to create new array each and 
every time when string is changed due to array fixed size limitations.

Reason 2 - Security

Many parameters are represented as String in network connections, database connection, 
URLs, usernames/passwords etc. If string is immutable, these will be altered and may leads to serious issues.

Reason 3 - Synchronization and concurrency

Making String immutable automatically makes them thread safe thereby solving the 
synchronization issues.

Reason 4 - Caching

When Compiler optimizes your String objects, there are two objects having same value 
(x="Siva", and y="Siva") and you need only one string object (for both x and y, these 
 two will point to the same object). We call this concept as string interning.

Reason 5 - Class loading

String is used as argument for class loading. If mutable, it could result in the wrong
class being loaded.
     * 
     */



    //in heap there is a string pool where we store strings
    class Program
    {
       public int val// we cant use it in main method
        {
            get;         // we can also use private get and private set
            set;        // as we use getter setter this is also same as getter setter in that we have to create a different function but in this we can directly apply propertiesto variable name 
        }
        static void Main(string[] args)
        {
            
            Program obj = new Program();
            obj.val = 10;
            // basic methods 
            Console.WriteLine("Hello World!");      // all the methods called by console.methodname() is static methods
            Console.WriteLine();
            Console.Beep();
           // Console obj = new Console();     console is a static class so we cant create objects of console class and all th methods of console class is static
            Console.BackgroundColor = ConsoleColor.Red;     // it is not a methods it is a property
            Console.Clear();        //clear screen
            Console.SetCursorPosition(12, 12);
            Console.WriteLine("hello java");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("hello world");
            Console.WriteLine(string.Format("{1} {0}", short.MinValue, short.MaxValue));        // {1} {0} is not same as {0} {1}
            // primitive data types
            int x;
            short x1;
            float f;
            double d;
            char c;
            string s;
            byte x2;
            bool b;

            // taking inputs of datatypes
            x2 = Convert.ToByte(Console.ReadLine());            // convert is also a static class
            b = Convert.ToBoolean(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt16(Console.ReadLine());  // we cant use Int32 bcz range is larger
            f = Convert.ToSingle(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToChar(Console.ReadLine());
            s = Console.ReadLine();
            // even if we write float f=10.4 compiler treat it as double till we dont write f=10.5f

            // printing outputs and type of variables
            Console.WriteLine(x + " " + x.GetType());
            Console.WriteLine(x1 + " " + x1.GetType());
            Console.WriteLine(x2 + " " + x2.GetType());
            Console.WriteLine(b + " " + b.GetType());
            Console.WriteLine(f + " " + f.GetType());
            Console.WriteLine(d + " " + d.GetType());
            Console.WriteLine(c + " " + c.GetType());
            Console.WriteLine(s + " " + s.GetType());

            // const valriable
            const int c1 = 12;
            const float c2 = 10.5f;
            float f1 =(float)10.5;

            // range of all data types
            Console.WriteLine(int.MinValue + " " + int.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);   // format string method here
                                                                        // {0} represents first value and {1} represents second value
            Console.WriteLine("{0} {1}",(int)char.MinValue ,(int)char.MaxValue);  // char.minvalue returns char so type cast to int
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine(int.MinValue + " " + int.MaxValue);
            Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);
            Console.WriteLine(byte.MinValue + " " + byte.MaxValue);
           // Console.WriteLine("{0} {1}", bool.MinValue, bool.MaxValue);    not applicable for bool
           // Console.WriteLine(string.MinValue + " " + string.MaxValue);    also for string
            Console.WriteLine("{0} {1}", short.MinValue, short.MaxValue);

            //Type casting
            // Implicit  byte->short-> int-> long-> float->double
            byte val1= 4;
            short val2 = val1;
            int val3 =val2;
            long val4 = val3;
            float val5 = val4;
            double val6 = val5;

            Console.WriteLine("Implicit type conversion");
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.WriteLine(val3);
            Console.WriteLine(val4);
            Console.WriteLine(val5);
            Console.WriteLine(val6);

            //explicit reverse order
            double d1 = 14.44;
            float d2 =(float) d1;
            long d3 =(long) d2;
            int d4 =(int) d3;
            short d5 =(short) d4;
            byte d6 = (byte)d5;

            Console.WriteLine("Explicit type conversion");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            // method 2 for explicit conversion
            double ch1 = 14.44;
            float ch2 =Convert.ToSingle(d1);
            long ch3 =Convert.ToInt64(d2);
            int ch4 =Convert.ToInt32(d3);
            short ch5 =Convert.ToInt16(d4);
            byte ch6 = Convert.ToByte(d5);

            Console.WriteLine("EXPLICIT type conversion METHOD 2");
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(ch4);
            Console.WriteLine(ch5);
            Console.WriteLine(ch6);

            //Non Compatible types like string to int or char to int

            char b1 = 'c';
            int b2 = (int)b1;
            string str1 = "1234";
            // int b3 = (int)str1; it gives error so use ToInt() method 
            int b3 = Convert.ToInt32(str1);
            int b4 = 1234;
            string str2 = Convert.ToString(b4);

            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(str2);

            //difference bw abstract class and inyerface
            // by default all members of interface are abstract but not in abstract class
            //we cannot declare private abstract method in abstract class but to non abstract we can make private
            //we can create method private still it is abstract by default
            //using base class pointer and virtual function we can access the declared method in abstract class but not in interface
        }
    }
}
