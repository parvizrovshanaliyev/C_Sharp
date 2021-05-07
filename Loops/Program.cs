using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region loops
            /*
             * yazilan kodun tekrar edilmesi ucun istifade edilir
             * uygun sertlere gore emeliyyatlarimiz tekrarlanir.
             *
             * for , while , do while
             *
             * her biri bir birini evez ede biler.
             * lakin uygun konsepte gore sece bilerik.
             *
             * ard-arda emeliyyatlarda daha cox for
             * sonsuz dongu lazimdirsa while
             * her hansia bir serte uygun konseptde do while
             */
            #region for

            #region example

            //Console.WriteLine("0 i++");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("0 ++i");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("---1---");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 1-10 qeder ededleri sirala

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("------");
            //for (int i = 50; i < 60; i++)
            //{
            //    Console.WriteLine(i-49);
            //}

            #endregion

            #region 1 ile 40 arasinda cut ededlerin cemi

            //int total = 0;
            //for (int i = 1; i <= 40; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        total += i;
            //    }
            //}

            //Console.WriteLine(total);
            #endregion

            #region girilen deyerin faktorialini tapin

            //int number = Convert.ToInt32(Console.ReadLine());
            //// 1 variant
            //int faktorial = 1;
            //for (int i = 2; i <= number; i++)
            //{
            //    faktorial *= i;
            //}

            //for (int i = 1; i <= number; i++)
            //{
            //    faktorial *= i;
            //}

            // 2 variant

            //for (int i = number; i > 1; i--)
            //{
            //    faktorial *= i;
            //}
            // var result ="";
            //for (int i = number; i > 1; i--)
            //{
            //    faktorial *= i;
            //    result += i + (i==1? "=":"x")
            //}

            //Console.WriteLine(faktorial);
            #endregion

            #endregion

            #region while
            /*
             * for loopuna nezeren daha sadedir
             * sert true olduqca kecerlidir
             */

            #region while ve for qarsilastirma

            //for (int i = 0; i < UPPER; i++)
            //{

            //}

            //int i = 0;
            //while (i<10)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}
            #region consoledan daxil edilen ededden geriye dogru loop

            //Console.Write("daxil edin :");
            //int number = Convert.ToInt32(Console.ReadLine());
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            #endregion

            #region 0 ile 100 arasindaki tek ededlerin cemi

            //int i = 0, total = 0;
            //while (i<=100)
            //{
            //    if (i % 2 == 1)
            //    {
            //        total += i;
            //    }

            //    i++;
            //}

            #endregion

            #region faktorial
            //Console.Write("daxil edin :");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int fac = 1;
            //while (number>0)
            //{
            //    fac *= number--;
            //    number--;
            //}

            #endregion

            #region while aid numune

            /*
             * O anki tarixin saniye deyeri 5 kvadratidirsa
             * tarixi ekranda gosterin
             */

            //while (true)
            //{
            //    if (DateTime.Now.Second % 5 ==0)
            //    {
            //        Console.WriteLine(DateTime.Now);
            //    }
            //}
            #endregion
            #endregion

            #endregion

            #region do while

            /*
             * while : sert dogru olduqca loop gedir
             * do while : sert dogru olduqca loop gedir
             *
             * ferq: while evvelce serte baxir sonra loop gedir,
             * \
             * do while : once kodu icra edir sonra serte baxir,
             * dogrudusa loopa girir
             * sert dogru olmasa bele birdefe kod icra edilir gedir.
             *
             *
             */
            //while (false)
            //{
            //    Console.WriteLine("while");
            //}
            //do
            //{
            //    Console.WriteLine("do while");
            //} while (false);

            #endregion

            #region skopsuz loop

            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine(i);


            #endregion

            #region sonsuz dongu

            #region for
            /*
             * int deyeri kecerse sonsuz dongu olmayacaq
             */
            //for (int i = 0; true; i++)
            //{

            //}

            // sonsuz
            //for (;;)
            //{

            //}

            // sonsuz donguden cxmaq istedikde
            //bool loop = true;

            //for (;loop;)
            //{
            //    if (true)
            //    {
            //        loop = !loop;
            //    }
            //}

            #endregion

            #region while

            //bool status = false;
            //while (!status)
            //{
            //    if (true)
            //        status = !status;
            //}
            #endregion

            #endregion

            #region nested loop - ic ice looplar

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {

            //    }
            //}
            /*
             * vurma cedveli
             */

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        int result = i * j;

            //        Console.Write("{0} * {1} = {2}\t",i,j,result);

            //    }

            //    Console.WriteLine();
            //}
            //Console.Clear();
            #endregion

            #region foreach loopdurmu ?
            /*
             * Foreach loop deyil sadece iteration emeliyyatini
             * yerine yetirir
             */
            

            #endregion

            #endregion
        }
    }
}
