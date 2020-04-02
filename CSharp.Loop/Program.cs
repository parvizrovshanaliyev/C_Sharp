using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            AscWriteStar();
            DescWriteStar();
            Console.ReadKey();
        }

        static void AscWriteStar()
        {
            for (int row = 1; row <= 8; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void DescWriteStar()
        {
            for (int row = 8; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
