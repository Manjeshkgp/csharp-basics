using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            System.Console.WriteLine("Please enter a number to compare");
            string num2Str = Console.ReadLine();
            if (int.TryParse(num2Str, out int num2))
            {
                System.Console.WriteLine("The statement that {0} is greater than {1} is {2}", num1, num2, num1 > num2);
            }
            else
            {
                System.Console.WriteLine("Parsing failed");
            }
            System.Console.WriteLine("Now let's learn the parsing in simple way, enter anything as of now");

            string input = Console.ReadLine();
            int inputNum;
            bool isParsable = int.TryParse(input, out inputNum);
            if (isParsable)
            {
                System.Console.WriteLine("You entered an integer that is {0}", inputNum);
            }
            else
            {
                System.Console.WriteLine("Your input was not an int32 integer");
            }

            Console.ReadKey(); // it helps to exit the program only after entering any key
        }
    }
}