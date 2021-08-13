using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list = new List<int>() { 1, 2, 3, 4 };    //create list and initialize
            list.Add(5);
            var a=list.ToArray();
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.Count);
            list.RemoveAt(1);
            list.AddRange(a);       // add complete array to list
            Console.WriteLine(list.Contains(3));
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            list.Clear();       // makes list empty
            Console.WriteLine("clear");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
