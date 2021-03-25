using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenParty
{
    public enum AppSettings
    {
        CarPhotos = 1,
        AccommodationPhotos,
        OfferPhotos,
        AttractivePhotos
    }
    class Program
    {

        static void Main(string[] args)
        {


            while (true)
            {

                Console.WriteLine(AppSettings.CarPhotos.ToString());
                //Console.Write("Enter K : ");

                //double k = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("==========================");

                //for (int tItr = 0; tItr < k; tItr++)
                //{
                //    double result = Pieces(k);

                //    Console.WriteLine(result.ToString() + " piece ");
                //}
            }

        }

        //static long Pieces(double k)
        //{
        //    return (long) ((k / 2) * (k - (k / 2)));
        //}
    }
}
