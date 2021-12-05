using System;
using Calculator;


namespace Math
{
    class Program : Operators
    {
        static void Main(string[] args)
        {
            Operators operators = new Operators();

            Console.WriteLine(Addition(5, 7));

            Console.WriteLine(Multiplication (20,20));
        }
    }
}
