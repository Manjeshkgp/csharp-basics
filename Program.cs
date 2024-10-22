using System;

namespace Class_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human denis = new Human("Desnis","Richie","Blue",29);
            denis.IntroduceMyself();

            Human michael = new Human("Michael","Phelps","Brown",22);
            michael.IntroduceMyself();
        }

    }
}