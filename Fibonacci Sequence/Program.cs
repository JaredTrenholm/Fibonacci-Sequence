using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static UInt64 recursionOccurs = 0;
        static UInt64[] storedResult = new UInt64[Int16.MaxValue-1];

        static void Main(string[] args)
        {
            StartSequence(0);
            
        }

        static void StartSequence(UInt64 startPoint)
        {
            Console.WriteLine();
            UInt64 fibResult = 0;
            for (UInt64 x = startPoint; fibResult < UInt64.MaxValue - fibResult; x++)
            {
                fibResult = Fib(x);
                storedResult[x] = fibResult;
                Console.WriteLine("Amount of recursions: " + (recursionOccurs-1) + "     Fib Number " + (x) + ": " + fibResult);
                recursionOccurs = 0;
            }
            Console.ReadKey(true);
        }

        static UInt64 Fib(UInt64 value)
        {

            recursionOccurs += 1;
            if (storedResult[value] != 0)
            {
                return storedResult[value];
            }

            if (value == 0)
            {
                return 0;
            }
            else if (value == 1)
            {
                return 1;
            }
            else if (value == 2)
            {
                return 2;
            }

            return Fib(value-2) + Fib(value-1);
        }
    }
}
