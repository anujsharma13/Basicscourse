using System;

namespace Arrays
{
    class Program
    {
        static public void fun(int[] a)
        {
            int i;
            for (i = 0; i < 2; i++)
                Console.WriteLine(a[i]);
        }
        static public void fun1(int[][] a)   // no need to pass dimension while passing to function
        {
            int i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine(a[i][j]);
                }
            }
        }

        static public void fun2(int[,] a)  // no need to pass dimension while passing to function
        {
            int i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }
        static public void fun3(params int[] a)  // no need to pass dimension while passing to function
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static public void fun4(int x, params int[] a)  // no need to pass dimension while passing to function
        {
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static public void fun5(int x, params int[] a)  // no need to pass dimension while passing to function
        {
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static public void fun6(params int[] a)
        {
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        /*static public void fun6(int x, params var[] a)  // no need to pass dimension while passing to function
        {       // var cannot be used in params
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }*/
        static void Main(string[] args)
        {
            int[] a = new int[2];   //single dimension is compulsory 
            int[][] a1 = new int[2][]; //only first dimension is compulsory jagged arrays
            int[,] a2 = new int[2,2];     // both are compulsory  multidimensional array

            int i, j;
            for (i = 0; i < 2; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < 2; i++)
            {
                a1[i] = new int[2];
                for (j = 0; j < 2; j++)
                {
                    a1[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 2; i++)
            { 
                for (j = 0; j < 2; j++)
                {
                    a2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 2; i++)
                Console.WriteLine(a[i]);

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine(a1[i][j]);
                }
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine(a2[i, j]);
                }
            }

            int @int;   //declare the variable name with predefined name 
            Array.Sort(a);      //only single dimension arrays can be sorted
            int[,] a3 = new int[2, 2];
            Array.Copy(a2, a3, a2.Length);  // a2 copies to 
            Console.WriteLine("function 2");
            fun(a);
            Console.WriteLine("function 2");
            fun1(a1);                       // no need to pass dimension while passing to function
            Console.WriteLine("function 2");
            fun2(a2);
            Array.Clear(a,0,a.Length);  // set all values to 0
            foreach(var it in a)
            {
                Console.WriteLine(it);
            }
            //params when number of arguments not known
            fun3(1, 2, 3, 4, 5, 6);
            fun4(4, 1, 2, 3);
            fun5(4,a);    // we can also pass array as
           //fun6(a,1,2,3,4); we cannot pass array and the values at same time in params
        }
    }
}
