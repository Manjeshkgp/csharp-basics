using System;

namespace DowhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                if (nameOfAFriend == null)
                {
                    System.Console.WriteLine("Your entry should not be null");
                }
                else
                {
                    int currentLength = nameOfAFriend.Length;
                    lengthOfText += currentLength;
                    wholeText += nameOfAFriend;
                }
            }
            while (lengthOfText < 20);

            Console.WriteLine("Thanks, that was enough! " + wholeText);
            Console.Read();
        }

    }
}