using System;

namespace Class_Basics
{
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        // member method
        public void IntroduceMyself(){
            System.Console.WriteLine("Hi I'm {0} {1}",firstName,lastName);
        }
    }
}