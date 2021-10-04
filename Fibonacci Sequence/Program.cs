using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static UInt64 firstValue;
        static UInt64 secondValue;
        static UInt64 thirdValue;

        static float firstFloat;
        static float secondFloat;
        static float thirdFloat;
        static void Main(string[] args)
        {
            StartSequence();
            Console.WriteLine();
            Console.WriteLine("Returned Number: " + Fib(1));
            Console.ReadKey(true);
            Console.WriteLine("Returned Number: " + Fib(10));
            Console.ReadKey(true);
            Console.WriteLine("Returned Number: " + Fib(25));
            Console.ReadKey(true);
            Console.WriteLine("Returned Number: " + Fib(50));
            Console.ReadKey(true);
            Console.ReadKey(true);
        }

        static void StartSequence()
        {
            firstValue = 0;
            secondValue = 1;
            thirdValue = firstValue + secondValue;

            firstFloat = 0;
            secondFloat = 1;
            thirdFloat = firstFloat + secondFloat;

            Console.WriteLine("The Sequence: " + firstValue);
            Console.WriteLine("The Sequence: " + secondValue);
            while (true)
            {
                Console.WriteLine("The Sequence: " + thirdValue+ "       Golden Ratio   " + thirdFloat / secondFloat);
                firstValue = secondValue;
                secondValue = thirdValue;
                thirdValue = firstValue + secondValue;

                firstFloat = secondFloat;
                secondFloat = thirdFloat;
                thirdFloat = firstFloat + secondFloat;

                if (thirdValue >= UInt64.MaxValue - thirdValue)
                {
                    Console.WriteLine("The Sequence: " + thirdValue + "       Golden Ratio   " + thirdFloat / secondFloat);
                    break;
                }
            }
        }

        static UInt64 Fib(UInt64 value)
        {
            if (value == 1)
            {
                return 0;
            } else if(value == 2)
            {
                return 1;
            }
            Console.WriteLine(value);
            return Fib(value-2) + Fib(value-1);
        }
    }
}
