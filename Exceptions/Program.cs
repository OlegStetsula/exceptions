using System;

namespace Exceptions
{
        //Write a method ReadNumber(int start, int end), which reads from Console  integer numbers and returns it, if it is in the range[start...end].
        //If an invalid number or non-number text is read, the method should throw an exception.
        //Using this method write a method Main(), that has to enter 10 numbers:
        //  a1, a2, ..., a10, such that 1 < a1< ... < a10< 100
        //Addition to 3: catch this exception in main() and print into consloe information about it(don't forget about stack trace) 
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a{0}", i);

                try
                {
                    int n = ReadNumber(1, 100);
                    Console.WriteLine("Your number {0} was accepted", n);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
        static int ReadNumber(int start, int end)
        {
            int number;
            bool result = Int32.TryParse(Console.ReadLine(), out number);
            if (result && number >= start && number <= end)
                return number;
            else
                throw new ArgumentException("Invalid input");
        }
    }

}
