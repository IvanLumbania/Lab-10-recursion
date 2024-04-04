using System.Reflection.PortableExecutable;

namespace Lab_10_recursion
{
    internal class Program
    {
        //method for Addition
        public static int SumOfNumbers(int n, int m) 
        { 
            //Checks if both numbers are the same
            if  ( n == m)
            {
                return n;

            }
            //Checks if number m is less than n. Switching places (i.e. 20 10 -> 10 20)
            else if ( m < n ) 
            {
                int newN = m;
                m = n;
                n = newN;
            }

            //recursion 
            return n + SumOfNumbers(n + 1, m);
        }

        //Method for Division
        public static int Division(int number)
        {
            //Checks if number inputted is 0
            if ( number == 0)
            {
                return 0;
            }
            //Checks if number is divisible by 2 using modulo
            else if ( number % 2 != 0) 
            {
                return 0;

            }

            //recursion dividing number by 2 until it cant be divided evenly
            return  1 + Division(number / 2);
        }

        static void Main(string[] args)
        {
            //Input for Addition
            Console.WriteLine("Pick number (n)");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick second number (m)");
            int secondNumber = int.Parse(Console.ReadLine());
            int result = SumOfNumbers(firstNumber, secondNumber);
            Console.WriteLine($"Sum of {firstNumber} and {secondNumber} is {result}");

            //Input for Division
            Console.WriteLine("pick a number (division)");
            int divisionNumber = int.Parse(Console.ReadLine());
            int resultDivision = Division(divisionNumber);
            Console.WriteLine($"Number of times {divisionNumber} can be divided by 2 : {resultDivision}");

        }
    }
}
