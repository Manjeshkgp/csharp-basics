using System;

namespace DowhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter<10)
            {
                counter++;
                System.Console.WriteLine(counter);
            }
            Console.Read();
        }

    }
}