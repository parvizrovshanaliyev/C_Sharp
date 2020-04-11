using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    int sayi, basamakSayisi = 0, temp;

            //    sayiGirisi:
            //    Console.WriteLine("Basamaklarına ayrılacak sayıyı giriniz:");
            //    var s = Console.ReadLine();

            //    // string sayi dönüşüm işlemleri için https://youtu.be/IjuDU5AMTOI linkinden ilgili videomu izleyebilirsiniz. 

            //    if (!int.TryParse(s, out sayi) || sayi < 0 || sayi > int.MaxValue - 1)
            //    {
            //        Console.WriteLine(
            //            "Girilen değer tam sayı değil veya sayı izin verilen aralık (0 - {0}) dışında girildi.",
            //            int.MaxValue);
            //        goto sayiGirisi;
            //    }

            //    temp = sayi;

            //    while (temp / 10 > 0)
            //    {
            //        temp = temp / 10;
            //        basamakSayisi++;
            //    }

            //    basamakSayisi++;
            //    Console.WriteLine("Girilen Sayının Basamak sayısı: {0}", basamakSayisi);
            //    Console.WriteLine("Sayının Basamakları:");
            //}

            while (true)
            {
                DigitSum();
            }
        }

        static void DigitSum()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (n > 0)
            {
                s += n % 10;
                n = n / 10;
            }
            Console.WriteLine("Girilen Sayının Basamaklarinin toplami: {0}", s);
        }
    }
}
