using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();

            try
            {
                int userInputNum = int.Parse(input);
                try
                {
                    int result = userInputNum / 0;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Not dividable by 0");
                }
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Format Exception Error");
            }
            catch (OverflowException)
            {
                System.Console.WriteLine("Overflow exception, when you write very big numbers that int32 can't handle");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Unknown/all other errors cacthed");
            }
            finally
            {
                System.Console.WriteLine("This will be called anyways");
            }

            Console.ReadKey();
        }
    }
}