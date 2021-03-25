using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("***************");
                Console.WriteLine("Enter a number :");

                int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                bool isPrime = IsPrime(number);

                Console.WriteLine(isPrime ? "number is prime" : "number is not prime");
            }
        }


        static bool IsPrime(int n)
        {
            if(n <=1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
