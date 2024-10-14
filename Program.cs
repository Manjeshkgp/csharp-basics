
namespace Name // can run without the namespace too
{
    public class MyFirstProgram
    {
        /// <summary>
        /// That's the entry point of our application
        /// </summary>

        static float tax = 18f;

        // some primitive data types Explicitly

        float price = 3.99f;
        string name = "John Doe";
        char letter = 'a';
        int number = 100000;
        bool toggle = false;

        public static void Main()
        {
            int age = 20;
            Console.WriteLine("age variable is: " + age);
            age = age + 5;
            // age+=5;
            Console.WriteLine("age now is: " + age);
            float productA = 5.99f;
            float productB = 7.45f;
            float productC = 9.26f;

            float summed = productA + productB + productC;
            // float totalTax = (summed/100)*tax;
            float totalTax = summed / 100 * tax;
            summed += totalTax;
            Console.WriteLine("Total Price of products a,b,c is: " + summed);

            // Implicitly defining some data types, only can be done inside a method
            var userName = "manjeshkgp";
            Console.WriteLine("userName implicit variable is: " + userName);
            Console.WriteLine("Now running swap");

            int a = 10;
            int b = 20;
            Console.WriteLine("a = " + a + ", b = " + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a + ", b = " + b);
        }
    }

}
