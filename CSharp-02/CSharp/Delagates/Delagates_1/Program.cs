using System;

namespace Delagates_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DELAGATES

            /*
             * Delegate metodlarin adreslerini dolayi yolla methodu saxlayan , isaret
             * eden strukturdur.
             *
             * Methodlar ozleride RAM da yaranan ve RAM-da adresleri olan struktura sahibdir.
             *
             * Delegate reference type-dir, yeni olardan instance alina biler.
             *
             * public delegate void MyDelegateHandler();
             *
             * Delegate-in temsil edeceyi method ile geri donus tipi ve parametr-leri eyni olmalidir.
             *
             * Delegate adlarinin sonuna adeten Handler elave edilir , mecburi deyil.
             *
             * Delegate eyni imzaya sahib methodlari saxlayir ve onlari sirasi ile ise salir.
             *
             * c# da olan delegate c, c++ da function pointer strukturuna benzeyir.
             *
             *
             * Niye istifade edilir ?
             *
             * Delegate umumilikde ram-da olan bir methodun bir hadiseye bagli ise salinmasi
             * ucun istifade edilmekdedir.
             *
             * WindowsFormApp de meselen bir buttona click olunan zaman bir methodun ise dusmesi,
             * db-dan bir datanin silinmesi zmaani her hansisa methodun ise dusmesi, bir file silinen
             * zaman her hansisa bir methodun ise dusmesi delegate vasitesi il edilir.
             *
             * form load olan zaman Form1.Designer.cs
             * this.Load += new System.EventHandler(this.Form1_Load);
             *
             *
             *
             */

            #endregion

            #region use: examples

            #region 1

            //DelegateHandler delegateHandler = new DelegateHandler(X);
            //DelegateHandler delegateHandler0 =X;
            //delegateHandler();==delegateHandler.Invoke();

            //delegateHandler();
            //delegateHandler.Invoke();
            #endregion

            #region 2

            CalculateHandler delegateHandler1 = new CalculateHandler(Sum);
            
            delegateHandler1 += Multiply;
            delegateHandler1 += Cixma;
            delegateHandler1(4, 5);
            //veya
            delegateHandler1.Invoke(2, 3);

            #region GetInvocationList

            //Delegate[] methods = delegateHandler.GetInvocationList();


            //foreach (var item in methods)
            //{
            //    Console.WriteLine(item.Method.Name);
            //}
            #endregion


            #region runtime += -=




            #endregion
            #endregion


            #region anonymous method : run time

            PrintHandler printHandler1 = new PrintHandler(Print1);

            printHandler1.Invoke("name","surname");

            PrintHandler printHandler2 = new PrintHandler(delegate(string name, string surname)
            {
                Console.WriteLine($"{name} {surname}");
            });
            printHandler2("12121", "1212121212");
            // lambda
            PrintHandler printHandler3 = (name, surname) =>
            {
                Console.WriteLine($"{name} {surname}");
            };
            printHandler3("asasasa", "sasasasas");
            #endregion
            #endregion

            Console.ReadLine();
        }

        #region example

        #region 1

        public delegate void DelegateHandler();

        public static void X()
        {
            Console.WriteLine("x: method");

            
        }


        #endregion

        #region 2
        public delegate void CalculateHandler(int a, int b);
        public static void Sum(int s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }
        public static void Multiply(int s1, int s2)
        {
            Console.WriteLine(s1 * s2);
            
        }
        public static void Cixma(int s1, int s2)
        {
            Console.WriteLine(s1 - s2);
        }

        #endregion

        #region anonymous method : run time

        delegate void PrintHandler(string name, string surname);

        static void Print1(string name, string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }
        #endregion

        #endregion
    }
}
