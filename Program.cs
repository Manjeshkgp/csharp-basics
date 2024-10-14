using System;

namespace HelloWorld
{
    class Program {
        static void Main(){
            // WriteSomething();
            // WriteSomethingSpecific("This is a sample string arg");
            int a = 40;
            int b = 20;
            int result = Add(a,b);
            Console.WriteLine("a = "+a+" b = "+b+" a+b = "+ result);
            result = Divide(a,b);
            Console.WriteLine("a = "+a+" b = "+b+" a/b = "+ result);
            result = Multiply(a,b);
            Console.WriteLine("a = "+a+" b = "+b+" a*b = "+ result);
            result = Subtract(a,b);
            Console.WriteLine("a = "+a+" b = "+b+" a-b = "+ result);
        }

        public static int Add(int Param1, int Param2){
            return Param1 + Param2;
        }
        public static int Subtract(int Param1, int Param2){
            return Param1 - Param2;
        }
        public static int Divide(int Param1, int Param2){
            return Param1 / Param2;
        }
        public static int Multiply(int Param1, int Param2){
            return Param1 * Param2;
        }
        public static void WriteSomething(){
            Console.WriteLine("I'm a called from a method");
            Console.Read();
        }
        public static void WriteSomethingSpecific(string arg){
            Console.WriteLine(arg);
            Console.Read();
        }
    }
}