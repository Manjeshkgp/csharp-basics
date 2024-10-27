using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5, 5, 6, 6 };
            jaggedArray[1] = new int[] { 3, 5, 6, 7, 6 };
            jaggedArray[2] = new int[] { 9, 10 };

            //another way

            int[][] jaggedArray2 = new int[][]
            {
                new int [] {12,3,4,4,5,56,56,6},
                new int [] {99,34,9349,29,92,492},
            };

            // try to access 9349

            System.Console.WriteLine(jaggedArray2[1][2]);

            // try to get all values of jaggedarray

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    System.Console.WriteLine(jaggedArray2[i][j]);
                }
            }
        }

    }
}