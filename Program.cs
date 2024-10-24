using System;
using Properties;

namespace Class_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Height = 10;
            box.Width = 20;
            box.SetLength(5);
            System.Console.WriteLine("Length of the box is {0}",box.GetLength());
            System.Console.WriteLine("Width of the box is {0}",box.Width);
            box.DisplayInfo();
        }

    }
}