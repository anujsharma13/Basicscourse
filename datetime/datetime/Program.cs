using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        { 
            DateTime obj = new DateTime(); //by default the value of this is 01/01/0001 and time is 12:00:00 AM
           /* DateTime obj1 = new DateTime(2020,20, 02); // date only constructor by default time is 12:00:00 AM
            DateTime obj2 = new DateTime(2020,20, 05, 5, 4, 5); // constructor with date and time constructor
            DateTime obj3 = new DateTime(2020,20, 05, 5, 4, 5, DateTimeKind.Utc);*/
            DateTime now = DateTime.Now;
            var today = DateTime.Today;
            var now1=now.AddDays(1);        // date time is immutable class we cant update it but we can create a new object
            Console.WriteLine(now.Year +" "+now.Month+" "+now.Day);
            Console.WriteLine(now1.Year+" "+now1.Month+" "+now1.Day);
            Console.WriteLine(now.Minute+" "+now.Hour);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(obj);                 // system.datetime is is string format
          /*  Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);*/
            DateTime now2 = DateTime.MaxValue;
            DateTime now3 = DateTime.MinValue;
            Console.WriteLine(now2);
            Console.WriteLine(now3);

            // Time span
            TimeSpan obj4 = new TimeSpan(2,3,5); // hour min second
            TimeSpan obj5 = new TimeSpan(2);    //hour
            var timespan = TimeSpan.FromHours(2);
            Console.WriteLine(obj4);
            Console.WriteLine(obj5);
            Console.WriteLine(timespan);
            Console.WriteLine(obj4.TotalSeconds);
            Console.WriteLine(obj4.TotalMilliseconds);
            Console.WriteLine(obj4.TotalDays);
            Console.WriteLine(obj4.Hours);
            Console.WriteLine(obj4.Minutes);
        }
    }
}