using System;

namespace Arrays
{
    class Program
    {
        static int[,] array2d = new int[,]
        {
                {1,2,3}, // row 0
                {6,4,5}, // row 1
                {7,8,9}, // row 2
        };
        static void Main(string[] args)
        {

            foreach (var item in array2d)
            {
                System.Console.Write(item+" ");
            }

            System.Console.Write("\n");

            for (int i = 0; i < array2d.GetLength(0); i++) // gets length of the 0th Order, for the 1d array
            {
                for (int j = 0; j < array2d.GetLength(1); j++) // gets length of the 1st Order / 2d array
                {
                    // array2d[i,j] = i+j*i-j; you can't do this in foreach loop
                    System.Console.WriteLine(array2d[i,j]);
                }
            }

            Console.ReadKey();
        }

    }
}