using System;

namespace Tasks
{
    public class Student
    {
        public void CalculateAverage(
            string name,
            string surname,
            decimal score1,
            decimal score2,
            decimal score3=51)
        {
            PrintStudentInfo(name, surname, score1, score2, score3);

            decimal average = Average(score1,score2, score3);

            RateYourAverageGrade(average);

        }

        private static void PrintStudentInfo(string name, string surname, decimal score1, decimal score2, decimal score3)
        {
            Console.WriteLine("Telebenin Imtahan neticeleri ve ortalamasi");
            Console.WriteLine("==========================================");
            Console.WriteLine("Ad Soyad : {0} {1}", name, surname);
            Console.WriteLine("1.Imtahan neticesi : {0}", score1);
            Console.WriteLine("2.Imtahan neticesi : {0}", score2);
            Console.WriteLine("3.Imtahan neticesi : {0}", score3);
            Console.WriteLine("==========================================");
        }

        public void RateYourAverageGrade(decimal average)
        {
            Console.WriteLine(
                average < 81 ?
                    "Ortalama: {0} - Havada bulut dimplom isini unut" :
                    "Ortalama: {0} - Hadi yine iyisin", average);
        }

        public decimal Average(decimal score1,
            decimal score2,
            decimal score3)
        {
          return (score1 + score2 + score3) / 3;
        }

        public static decimal CheckInputTypeInt()
        {
            decimal value = 0;

            bool control = false;

            while (control is false)
            {
                control = decimal.TryParse(Console.ReadLine(), out value);

                if (control)
                {
                    if (value < 0 || value > 100)
                    {
                        Console.WriteLine("Imtahan neticesi 0-dan kicik 100-den boyuk ola bilmez");
                        control = false;
                    }
                }
                else
                {
                    Console.WriteLine("Imtahan neticesi olaraq ancaq reqem daxil etmelisiz");
                }
            }
            return value;
        }
    }
}
