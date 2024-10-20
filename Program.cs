using System;

namespace ShortcutForIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int temparature = 5;
            string waterState;
            if (temparature <= 0) waterState = "Solid";
            else waterState = "Liquid";

            System.Console.WriteLine("State of water at temparature of {0} is {1}", temparature, waterState);

            string aceticAcidState;
            aceticAcidState = temparature >= 118 ? "Gaseous" : temparature > 17 ? "Liquid" : "Solid";
            System.Console.WriteLine("State of acetic acid at temparature of {0} is {1}", temparature, aceticAcidState);

            Console.ReadKey(); // it helps to exit the program only after entering any key
        }
    }
}