using System;

namespace Methods_Intro
{
    public static class Calculator
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Cixma");
            Console.WriteLine("3.Vurma");
            Console.WriteLine("4.Bolme");
            Console.Write("Emeliiyat nomresini daxil edin:\t");
        }
        public static decimal Toplama(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Cixma(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Vurma(decimal a, decimal b)
        {
            return a * b;
        }

        public static decimal Bolme(decimal a, decimal b)
        {
            return a / b;
        }


        public static void Result(decimal number1, decimal number2,decimal result,string operation)
        {
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("___________________ Netice_______________________");
            Console.WriteLine("{0} {1} {2} = {3}",number1,operation,number2,result);
        }
    }
}
