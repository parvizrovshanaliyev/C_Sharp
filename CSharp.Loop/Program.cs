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
            //DescWriteStar();
            //foreach (var dateTime in GetDateRange(new DateTime(), new DateTime(2010, 6, 15)))
            //{
            //    var time = dateTime;
            //    Console.WriteLine(time);
            //}

            Console.ReadKey();
        }

        public static IEnumerable<DateTime> GetDateRange(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
                throw new ArgumentException("endDate must be greater than or equal to startDate");

            while (startDate <= endDate)
            {
                yield return startDate;
                startDate = startDate.AddDays(1);
            }
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
