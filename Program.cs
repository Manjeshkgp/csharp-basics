using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1 = 5;
           int num2 = 3;
           int num3;

           // unary operators
           num3 = -num1;
           System.Console.WriteLine("num3 is {0}",num3);

            bool isSunny = true;
           System.Console.WriteLine("isSunny is {0}",!isSunny);

            // increment operators

            num2++;
            System.Console.WriteLine("23num2 is {0}",num2);
            System.Console.WriteLine("24num2 is {0}",num2++); // it will change in 25num2 not here, here it is 4
            System.Console.WriteLine("25num2 is {0}",num2); // here num2 is 5
            // pre increment
            System.Console.WriteLine("26num2 is {0}",++num2); // but here num2 is increased directly and logged as 6

            // decrement operators

            num2--;
            System.Console.WriteLine("32num2 is {0}",num2);
            System.Console.WriteLine("33num2 is {0}",num2--);
            System.Console.WriteLine("34num2 is {0}",num2);
            // pre decrement
            System.Console.WriteLine("35num2 is {0}",--num2);

            // modular operators

            int result;
            result = num1 % num2; // after dividing, gives remainder
            System.Console.WriteLine("{0} % {1} = {2}",num1,num2,result);

            // relational & type operators

            bool isLower;

            isLower = num1 < num2;
            System.Console.WriteLine("result of {0} < {1} = {2}",num1,num2,isLower);

            // equality operators

            bool isEqual;

            isEqual = num2 == 3;
            System.Console.WriteLine("result of num2 == 3 = {0}",isEqual);

            isEqual = num2 != 3;
            System.Console.WriteLine("result of num2 != 3 = {0}",isEqual);

            // conditional operators

            bool isLowerAndSunny;
            // AND operator
            isLowerAndSunny = isLower && isSunny;
            System.Console.WriteLine("result of isLower && isSunny is {0}",isLowerAndSunny);

            bool isLowerOrSunny;
            // OR operator
            isLowerOrSunny = isLower || isSunny;
            System.Console.WriteLine("result of isLower || isSunny is {0}",isLowerOrSunny);
            
           Console.ReadKey(); // it helps to exit the program only after entering any key
        }
    }
}