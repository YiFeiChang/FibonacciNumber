using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] mAnser = GetFibonacciNumbers(15);
            Console.WriteLine(string.Join(", ", mAnser));
        }
        private static uint[] GetFibonacciNumbers(uint length)
        {
            uint[] mNumbers = new uint[length];
            for (uint i = 0; i < mNumbers.Length; i++)
            {
                mNumbers[i] = GetFibonacciNumber(i + 1);
            }
            return mNumbers;
        }
        private static uint GetFibonacciNumber(uint n)
        {
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
            }
        }
    }
}
