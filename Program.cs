using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 10; counter++){
                System.Console.WriteLine(counter);
            }            

            System.Console.WriteLine("writing only odd nums from 0 to 20");
            // we can also use num = 1, num+=2
            for(int num = 0; num<=20; num++){
                if(num%2!=0){
                    System.Console.WriteLine(num);
                }
            }

            Console.Read(); // it helps to exit the program only after entering any key
        }
    }
}