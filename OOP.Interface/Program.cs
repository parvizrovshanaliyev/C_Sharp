using System;

namespace OOP.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OOP.Interface
            /*
             * Interface esasen class-lara hansi isleri goreceyini bildiren bir struktura sahibdir,
             * desek yanilmariq .
             * Proyektde goreceyimiz eyni emeliyyatlari Interface icerisinde cemlesdirib istifade eden
             * zaman kod tekrarinin azaldigini daha effektiv ierarxik strukturlu kod yazdigimizin ferqine
             * varacagiq.
             *
             * Interface-nin OOP de onemli yeri vardir.
             *
             * Ozellikleri
             * * Interface-den instance ala bilmerik .
             * * Esase icerisinde teyin edilen method ve ya property-lerin body-si olmur
             *   implement edildikleri class icerisinde yazilir.
             * * Adlandirma qaydasina gore interface I ile baslamalidir.
             * * Bir class birden cox Interface implement ede biler
             * * Interface member-ler public olaraq qebul edilir.
             */
            #endregion

            #region examples

            #region 1
            IEmployee employee = new Employee
            {
                Name = "Halil",
                SurName = "ŞAHİN",
                Deparment = "Bilgi İşlem",
                FeePerOur = 30,
                TotalWorkHour = 180
            };

            Console.WriteLine("Adı Soyadı : " + employee.Name + " - " + employee.SurName);
            Console.WriteLine("Departmanı: " + employee.Deparment);
            Console.WriteLine("Maaşı :" + employee.CalculateSalary(employee.FeePerOur, employee.TotalWorkHour).ToString() + " TL");


            #endregion


            #endregion
        }
    }
    #region examples
    public interface IEmployee
    {

        string Name { get; set; }
        string SurName { get; set; }
        string Deparment { get; set; }

        decimal FeePerOur { get; set; }
        decimal TotalWorkHour { get; set; }

        decimal CalculateSalary(decimal feePerOur, decimal totalWorkHour);

    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Deparment { get; set; }
        public decimal FeePerOur { get; set; }
        public decimal TotalWorkHour { get; set; }

        public decimal CalculateSalary(decimal FeePerOur, decimal TotalWorkHour)
        {
            return FeePerOur * TotalWorkHour;
        }
    }
    #endregion
}

