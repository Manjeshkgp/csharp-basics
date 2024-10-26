using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2d array
            string[,] twoDArr;

            // declare 3d array
            int[,,] threeDArr;


            int[,] array2d = new int[,]
            {
                {1,2,3}, // row 0
                {6,4,5}, // row 1
                {7,8,9}, // row 2
            };
            System.Console.WriteLine("Central value is {0}", array2d[1, 1]); // we will get 4
            // try to access 7
            System.Console.WriteLine("2,0 position is {0}", array2d[2, 0]);

            string[,,] array3d = new string[,,]
            {
                {
                    {"Ram","Shyam"},
                    {"C#",".NET"},
                },
                {
                    {"Pratik","Tushar"},
                    {"Rust","Java"},
                },
                {
                    {"Hugh Jackman","Grant Gustin"},
                    {"Wolverine","The best Flash"},
                },
            };

            // finding Hugh Jackman
            // 2nd row, 0th element, again 0th element
            System.Console.WriteLine("2,0,0 is {0}", array3d[2, 0, 0]);

            // below means 3 rows, 2 elements each row
            string[,] array2dString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            // check an array dimension, i.e. 2d or 2d or 4d and so on ...
            System.Console.WriteLine("array2dString is a {0}-D array",array2dString.Rank);
            System.Console.WriteLine("array3d is a {0}-D array",array3d.Rank);

            Console.ReadKey();
        }

    }
}