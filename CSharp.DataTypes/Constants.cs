using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataTypes
{
    public static class Constants
    {
        private const double Pi = 3.1415;

        public static void CalculateRadiusOfTheCircle()
        {
            double area, radius, circle;

            Console.WriteLine("radius of circle :");

            radius = Convert.ToDouble(Console.ReadLine());
            circle = 2 * Pi * radius;
            area = Pi * Math.Pow(radius, 2);

            Console.WriteLine("area of circle : {0}",area);
            Console.WriteLine("circumference of the circle : {0}", circle);
        }

    }
}
