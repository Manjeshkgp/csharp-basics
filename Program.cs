using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int temparature = 10;

            if(temparature<10){
                System.Console.WriteLine("temparature is cold");
            }
            else if(temparature==10){
                System.Console.WriteLine("temparature is 10 degree Celcius");
            }
            else{
                System.Console.WriteLine("temparature is greater than 10 degree Celcius");
            }

            Console.ReadKey(); // it helps to exit the program only after entering any key
        }
    }
}