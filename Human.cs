using System;

namespace Class_Basics
{
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // default constructor
        public Human(){
            System.Console.WriteLine("Constructor Called, Object Created");
        }


        // parameterized constructor

        public Human(string myfirstName, string lastName, string eyeColor)
        {
            firstName = myfirstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        
        // parameterized constructor

        public Human(string myfirstName, string lastName, string eyeColor, int age)
        {
            firstName = myfirstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        // member method
        public void IntroduceMyself()
        {
            System.Console.WriteLine("Hi I'm {0} {1}, my eyeColor is {2} & my age is {3}", firstName, lastName, eyeColor, age);
        }
    }
}