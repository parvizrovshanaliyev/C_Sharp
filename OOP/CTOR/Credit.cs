using System;

namespace OOP.CTOR
{
    public class Credit
    {
        public Credit(int month, double price, double percentage)
        {
            Months = month;
            Price = price;
            Percentage = percentage;
        }

        public int Months { get; set; }
        public double Price { get; set; }
        public double Percentage { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public void Calc()
        {
            double total = Price + (Price * Percentage / 100)* Months;
            double monthlyPay = total / Months;
            double part = monthlyPay % 1;
            monthlyPay -= part;
            part *= Months;

            Console.WriteLine("Umumi mebleg :\t{0}", total);
            for (int i = 0; i <= Months; i++)
            {
                if(i == Months)
                {
                    monthlyPay += part;
                }

                PrintResult(monthlyPay);
                Date = Date.AddMonths(i);
            }
            

        }

        private void PrintResult(double monthlyPay)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Odenis Tarixi :\t{0:d}, Odenis :\t{1}", Date, monthlyPay);
        }
    }
}
