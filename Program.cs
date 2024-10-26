using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] grades = new int[5]; // an array with 5 elements
            grades[0] = 80;
            grades[1] = 15;
            grades[2] = 28;
            grades[3] = 38;
            grades[4] = -70;

            // if you try to log the grades directly you will only be able to log dataType[], so you need to log elements one by one
            // another way of initializing array
            int [] sampleArr = {10,20,30,40,50};

            // 3rd way of initializing array
            int [] sampleArr2 = new int[] {10,20,30,40,50};

            System.Console.WriteLine("Length of sampleArr is {0}",sampleArr.Length);

            Console.ReadKey();
        }

    }
}