using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i = 0; i < 10; i++)
          {
            if(i==3){
                System.Console.WriteLine("At 3 we skip");
                continue;
            }
            if(i==8){
                System.Console.WriteLine("At 8 we stop");
                break;
            }
            System.Console.WriteLine(i);
          }
            Console.Read();
        }

    }
}