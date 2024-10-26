using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] grades = new int[10]; // an array with 10 elements

            for (int i = 0; i < 10; i++)
            {
                grades[i] = (i+1)*10;
            }

            for (int i = 0; i < grades.Length; i++)
            {
                System.Console.WriteLine("Grade[{0}] = {1}",i,grades[i]);
            }

            foreach (int item in grades)
            {
                System.Console.WriteLine("{0}",item);
            }
            string [] friends = new string[5] {"Ram","Shyam","Mohit","Sohan","Pratik"};

            foreach (string friend in friends)
            {
                System.Console.WriteLine("Happy Sunday {0}",friend);
            }

            Console.ReadKey();
        }

    }
}