using System;

namespace Methods_Intro
{
    class Program // class
    {
        static void Main(string[] args) // method
        {

            #region example calculator
            //do
            //{
            //    Calculator.Menu();

            //    int operation = int.Parse(Console.ReadLine());
            //    Console.WriteLine("1. ededi daxil edin");
            //    decimal number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2. ededi daxil edin");
            //    decimal number2 = Convert.ToInt32(Console.ReadLine());

            //    decimal result = 0;
            //    switch (operation)
            //    {
            //        case 1:
            //            result = Calculator.Toplama(number1, number2);
            //            Calculator.Result(number1, number2, result, "+");
            //            break;
            //        case 2:
            //            result = Calculator.Cixma(number1, number2);
            //            Calculator.Result(number1, number2, result, "-");

            //            break;
            //        case 3:
            //            result = Calculator.Vurma(number1, number2);
            //            Calculator.Result(number1, number2, result, "*");

            //            break;
            //        case 4:
            //            result = Calculator.Bolme(number1, number2);
            //            Calculator.Result(number1, number2, result, "/");

            //            break;
            //        default:
            //            Console.WriteLine("Emeliyyat duzgun daxil edilmeyib");
            //            break;
            //    }
            //    Console.Write("Davam etmek isteyirsinizmi? b/x (beli/xeyr):\t");

            //} while (Console.ReadLine()?.ToUpper() != "X");
            #endregion

            #region ref out

            double number1 = 0;

            AssignValue(ref number1);

            #endregion

            #region params

            Sum2(1, 2, 3, 4, 5);


            #endregion
        }

        #region methods
        /*
         * Real heyata nezer salsaq method-lari butun gorulen isler olaraq,
         * bir fel olaraq basa duse bilerik.
         * Programlashdirmada bir isi yerine getiren program hissesi method-dur
         * deye bilerik.
         * Methodlar bize kod tekrarin qarshisini almaqda heddin artiq komek edir .
         *
         * Method-lar class memberlerdir , yeni bir method class/struct icerisinde yaradilirlar,
         * access modifier___geri donus  deyeri__adi ()
         *
         * access Modifier Inheritance hissselerinde daha etrafli oyreneceyik sade sekilde
         * yadda saxlayin private ve public
         *
         * Geriye donus deyeri : methodun her hansi bir tipde geriye (5, true,false) deyer
         * vermesidir ki, biz onu sonra yeniden ferqli emliyyatlar ucun istifade ede bilirik.
         *
         * 
         */

        #region geriye deyer donmeyen, parametr alamayan metod

        public static void Method1Public()
        {
            Console.WriteLine("geriye deyer donmeyen, parametr alamayan metod");
        }

        private static void Method1Private1()
        {
            Console.WriteLine("geriye deyer donmeyen, parametr alamayan metod");
        }

        static void Method1Private2()
        {
            Console.WriteLine("geriye deyer donmeyen, parametr alamayan metod");
        }
        #endregion

        #region geriye deyer donmeyen, parametr alan method
        public void Method2(string message)
        {
            Console.WriteLine(message);
        }
        #endregion

        #region geriye deyer donen , parametr almayan
        public string Method3()
        {
            string message = "Exception";
            return message;
        }
        #endregion

        #region geriye deyer donen, parametr alan 
        public int Method3Sum(int a, int b)
        {
            int sum =a+b;
            return sum;
        }
        #endregion

        #region method-un parametrine default deyerin verilmesi

        //public static void Sum1(int a, int b = 0, int c = default)
        //{
        //    Console.WriteLine(a+b+c);
        //}
        #endregion

        #region ref ve out keywordleri
        /*
         * Kohne .net framework versiyalarinda ref ve out key-leri arasinda bir ferq var idi ,
         *  oda refin baslangic deyer alma mecburiyyeti idi.
         *  Stack ve Heap movzularini tekrarlayin.
         */

        /*
         * Burada normal qaydada refden istifade edilmeseydi deyer kopyalanacaqdi ancaq
         * ref keywordu vasitesi ile deyer kopyalanmir  heapde yaradilir ve iki deyisende ona reference/muraciet
         * edir.
         *
         * Ref: aralarindaki ferq evveller colde istifade edilen deyisen deyer baslangic almali idi yoxsa xeta verecekdi,
         * OuT : ehtiyyac yox idi baslangic deyere
         *
         */
        static void AssignValue(ref double value)
        {
            value = value * 0.18;
        }

        #endregion

        #region params
        /*
         * deyisken sayda parametr almaq params key vasitesi ile
         *
         * params dan sonra yox parametrler ondan evvel teyin edilmelidir
         */
        static void Sum2(int a,params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
        #endregion
        #endregion
    }
}
