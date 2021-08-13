using System;

namespace Nullable_and_Non_Nullable
{
    class a
    {
        int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int x = null; it gives error  non nullable cant have null
            int? x = null;// null means empty
            int y = x.Value;  // value return bool if it is null it returns true
            // int y = x; error we cant assign nullable to non nullable
            // for that use value keyword or cialescing operator
            int z = x ?? 10;    // it means if x is null assign 10 to it
            Console.WriteLine(x);
            a obj = new a();
            obj = null; // nullable type can have null

        }
    }
}
