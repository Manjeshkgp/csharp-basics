using System;

namespace Class_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human denis = new Human();
            denis.firstName = "Denis";
            denis.lastName = "Richie";
            denis.IntroduceMyself();

            Human michael = new Human();
            michael.firstName = "Michael";
            michael.lastName = "Phelps";
            michael.IntroduceMyself();
        }

    }
}