using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;

            switch (age)
            {
                case 15:
                System.Console.WriteLine("You are a teenager");
                break;
                case 20:
                System.Console.WriteLine("You must have a moustache, you are 20");
                break; // you can use return; instead of break; as well, no error will be thrown
                default:
                System.Console.WriteLine("I'm not sure, how old you are");
                break;
            }

            Console.ReadKey(); // it helps to exit the program only after entering any key
        }
    }
}