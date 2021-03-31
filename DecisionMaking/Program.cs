using System;
using System.Diagnostics;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if else statements

            /*
             * &&
             * ||
             */

            #region example

            #region 1
            /*
             * daxil edilen deyerin 50den kicik ve ya boyuk olmasini
             * yoxla
             */

            //Console.Write("enter a number :");
            //decimal number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter a number :");
            //decimal number2 = Convert.ToInt32(Console.ReadLine());
            //decimal total = (number1 + number2);
            ////bool result = (number1 + number2) > 50;
            //// if
            //if (total  > 50)
            //{
            //    Console.WriteLine("Daxil edilen deyer 50 den boyukdur");
            //}

            /*
            // * if else if
            // * girilen deyer 100, 80 boyuk olub olmamasi yoxla
            // * if else if sertleri veren zaman mentiqi ardicilliqa fikir vermek
            // * lazimdi
            // */
            //if (total > 100)
            //{
            //    Console.WriteLine("Daxil edilen deyer 100 den boyukdur");

            //}else if (total > 80)
            //{
            //    Console.WriteLine("Daxil edilen deyer 80 den boyukdur");

            //}
            //else
            //{
            //    Console.WriteLine("Daxil edilen deyer 80 den kicikdir");

            //}
            // ternary
            //Console.WriteLine((number1 + number2) > 50 ? "Daxil edilen deyer 50 den boyukdur" : "kicikdir");

            #endregion

            #region 2 calculator

            /*
             * menu
             *
             * 1- Toplama
             * 2- Cixma
             * 3- Vurma
             * 4- Bolme
             *
             * qeyd: bolen 0 ola bilmez;
             */
            //Console.WriteLine("----MENU----");
            //Console.WriteLine("* 1- Toplama");
            //Console.WriteLine("* 2- Cixma");
            //Console.WriteLine("* 3- Vurma");
            //Console.WriteLine("* 4- Bolme");
            //Console.WriteLine("----MENU----");
            //Console.Write("emeliyyati nomresini daxil edin: ");
            //int operation = Convert.ToInt32(Console.ReadLine());

            //if (operation ==1 ||
            //    operation == 2 ||
            //    operation == 3 ||
            //    operation == 4)
            //{
            //    Console.Write("1. Daxil Edin: ");
            //    double number1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("2. Daxil Edin: ");
            //    double number2 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("-------------");
            //    if (operation == 1)
            //    {
            //        Console.Write("Netice: {0}",(number1 + number2));
            //    }
            //    else if (operation == 2)
            //    {
            //        Console.Write("Netice: {0}", (number1 - number2));

            //    }
            //    else if (operation == 3)
            //    {
            //        Console.Write("Netice: {0}", (number1 * number2));

            //    }
            //    else if (operation == 4)
            //    {
            //        if (number2==0)
            //        {
            //            Console.WriteLine("qeyd: bolen 0 ola bilmez;");
            //        }
            //        else
            //        {

            //            Console.Write("Netice: {0}", (number1 / number2));
            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("daxil edilen emeliyyat duz deyil");
            //}

            #endregion

            #region 3 birden artiq sert duz olduqda ve ya lazim olduqda

            //int num = int.Parse(Console.ReadLine());

            //// sehv istifadedir
            //if (num > 100 && num <= 200)
            //{
            //    Console.WriteLine("");
            //}else if (num > 200 && num <= 300)
            //{
            //    Console.WriteLine("");
            //}else if (num > 200 && num <= 400)
            //{

            //}

            // duz olan
            //if (num > 100 && num <= 200)
            //{
            //    Console.WriteLine("");
            //}
            //if (num > 200 && num <= 300)
            //{
            //    Console.WriteLine("");
            //}
            //if (num > 200 && num <= 400)
            //{

            //}
            #endregion

            #region scopsuz if

            //if (num > 200 && num <= 300)
            //{
            //    Console.WriteLine("");
            //}

            //if (num > 200 && num <= 300)
            //    Console.WriteLine("");
            #endregion

            #region task
            #region 1
            /*
             * Bal Ortalamasinin Hesablanmasi
             *
             * istifadeciden ad ve soyadini ,
             *  4 eded imtahan neticesini daxil etmesini isteyirik.
             *
             * netice asagidaki kimi olmalidir
             *
             * Ad ve Soyad : Parviz Aliyev
             *
             * Netice : 50
             * Netice : 40
             * Netice : 30
             * Netice : 20
             *
             * Ortalama : 35
             */
            #endregion

            #region 2 20 % endirim
            /*
             * Consoledan daxil edilen 2 eded mehsulun qiymetleri cemi
             *
             * 200 azn den coxdursa , ikinci mehsulun qiymetini 20 % endirim ile
             * hesablayib umumi meblegi gosterin. Netice asagidaki kimi olacaq.
             *
             *
             *
             *1. Mehsul : 50 azn
             *2. Mehsul : 240 azn
             *
             * --------Yekun----------
             *
             * 2. Mehsul Endirim : 20%
             *
             * Umumi : 242 azn
             * _______________________
             *
             */

            Console.Write("1.mehsulun qiymeti: ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("2.mehsulun qiymeti: ");
            decimal productPrice1 = Convert.ToDecimal(Console.ReadLine());

            bool checkTotal = (productPrice + productPrice1) > 200;

            decimal total = 0;

           

            Console.WriteLine("------------------------");
            Console.WriteLine("1.mehsulun qiymeti:{0}",productPrice);
            Console.WriteLine("2.mehsulun qiymeti:{0}",productPrice1);
            Console.WriteLine("-----------Yekun-------------");

            if (checkTotal)
            {
                Console.WriteLine("2.mehsul endrim 20 %");
                //total = productPrice1-(productPrice1 * 20 / 100) + productPrice;
                total = (productPrice1 * 80 / 100) + productPrice;
            }
            else
            {
                total = productPrice + productPrice1;
            }
            Console.WriteLine("umumi : {0}",total);

            #endregion
            #endregion

            #endregion

            #endregion

            #region switchCase

            /*
             * switch(ifade){
             * case control :
             *   operations
             * case control2 :
             *   operations
             * break;
             * default:
             * operation
             *
             * }
             */

            #region example

            #region 1
            /*
             * beraberlik muqayisesi zamani daha cox istifade edilir.
             *
             * caselerdeki deyerler deyisenlerden alinmir
             *
             * caselerin sirasi onemli deyil
             */


            /*
             * istifadeciden gelen aylarin yoxlanilmasi
             *
             */
            //Console.Write("Cari Ayi daxil edin :");
            //string month = Console.ReadLine();

            //switch (month)
            //{
            //    case "Yanvar":
            //        Console.WriteLine("01");
            //        break;
            //    case "Fevral":
            //        Console.WriteLine("02");
            //        break;
            //    case "Mart":
            //        Console.WriteLine("03");
            //        break;
            //    default:
            //        Console.WriteLine("duzgun daxil edilmeyib");
            //        break;
            //}

            /*
             * switch casede  bir nece case elave etmek olur bu zaman ||
             * ve ya serti yerine yetirili bu ve ya o 
             */

            //switch (month)
            //{
            //    case "Yanvar":
            //    case "Fevral":
            //        Console.WriteLine("01");
            //        break;
            //    case "Fevral":
            //        Console.WriteLine("02");
            //        break;
            //    case "Mart":
            //        Console.WriteLine("03");
            //        break;
            //    default:
            //        Console.WriteLine("duzgun daxil edilmeyib");
            //        break;
            //}

            #region when istifadesi

            /*
             * normal switchde ancaq beraberlik yoxlaya bilirik
             * ferqli sertler ucun when istifade edilir.
             *
             */

            //int total = 100;
            //switch (total)
            //{
            //    case 100 when (total == 5):
            //        break;
            //}
            #endregion

            #region go to istifadesi

            /*
             * beraberlik yoxlanilir deye locigal emeliyyatlar ucun
             *
             * ferqli caselerde eyni emeliyyat(kod ) istifade olunursa
             * kod tekrari olmasin deye go to ile birini sece bilirik.
             *  caseler arasinda kecid
             * go to ile break silinir;
             */
            //string choise = "a";

            //switch (choise)
            //{
            //    case "A":
            //        Console.WriteLine("a varianti");
            //        break;
            //    case "a":
            //        Console.WriteLine("a varianti");
            //        break;
            //}

            //switch (choise)
            //{
            //    case "A":
            //        Console.WriteLine("a varianti");
            //        break;
            //    case "a":
            //        goto case "A";
            //}

            // multiple go to 
            //switch (choise)
            //{
            //    case "A":
            //        Console.WriteLine("a varianti");
            //        break;
            //    case "a":
            //    case "B":
            //        goto case "A";
            //}
            #endregion

            #region switch expressions c# 8.0

            //string message = "";

            //switch (DateTime.Now.DayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        message = "Bu gun Bazar ertesidir";
            //        break;
            //    case DayOfWeek.Tuesday:
            //        message = "Bu gun Cersenbe Axsamidir";
            //        break;
            //    case DayOfWeek.Wednesday:
            //        message = "Bu gun Cersenbedir";
            //        break;
            //    case DayOfWeek.Thursday:
            //        message = "Bu gun Cume Axsami";
            //        break;
            //    case DayOfWeek.Friday:
            //        message = "Bu gun Cume";
            //        break;
            //    case DayOfWeek.Saturday:
            //        message = "Bu gun Senbe";
            //        break;
            //    case DayOfWeek.Sunday:
            //        message = "Bu gun Bazar";
            //        break;
            //}

            ////
            //string message = DateTime.Now.DayOfWeek switch
            //{
            //    DayOfWeek.Monday => "Bu gun Bazar ertesidir",
            //    DayOfWeek.Tuesday => "Bu gun Cersenbe Axsamidir",
            //    DayOfWeek.Wednesday => "Bu gun Bazar ertesidir",
            //    DayOfWeek.Thursday => "Bu gun Cersenbedir",
            //    DayOfWeek.Friday => "Bu gun Cume Axsami",
            //    DayOfWeek.Saturday => "Bu gun Cume",
            //    DayOfWeek.Sunday => "Bu gun Senbe"
            //};

            #region when
            //int total = 100;

            //string result = total switch
            //{
            //    5 when 3 == 3 => "true",
            //    var xTotal when xTotal > 100 && xTotal % 2 == 0 => "false",
            //    var x=>"default" // default
            //};


            #endregion

            #endregion
            #endregion

            #region 2



            #endregion

            #endregion

            #endregion


            #region task

            #region mini login
            /*
             * Daxil edilen istifadeci adi ve sifresini yoxlayin.
             *
             * netice olaraq "girisin ugurlu olmasi" ve ya "daxil edilen istifadeci adi ve sifre dogru deyil"
             * mesajini verin.
             *
             * qeyd: eyni taski, if, ternary operator ve switch ile yazin
             */
            

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
