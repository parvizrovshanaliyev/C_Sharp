using System;
using System.Collections;
using System.Diagnostics;

namespace Tasks
{
    class Program
    {
        static int balance = 1000;

        static void Main(string[] args)
        {
            #region week5.tasks
            /*
             * Topics: String , Method
             */

            #region 1. Havada bulut dimplom isini unut
            /*
             * Telebinin adini soyadini 3 imtahan neticesini
             * (((her hansisa imtahan neticesi daxil edilmezse default deyer 51 verilecek,
             * daxil edilen imtahan neticeleri0-dan kicik 100-den boyuk ola bilmez,
             * eded yerine simvol ve sair daxil edilen zaman xeta mesaji cixmalidir, yeniden emeliyyati duzgun yerine yetirerek davam etmelidir))) daxil edib,
             * ortalamasini hesablayaraq console-da  adi,soyadi, imtahan neticeleri,
             * ortalamasi, Diplom isine dusub dusmediyi yazilacaq(((bunun ucun ortalama 81den boyuk ve ya beraber olmalidir))).
             *
             * Taski mumkun derece kicik methodlara bolerek her methoda verilen adi ehtiva eden isler gorulsun.
             * Student classi yaradaraq method-lari orada yazib Program classi icerisinde Main methodunda istifade edeceksiz.
             */

            //string name = string.Empty;
            //string surname = string.Empty;
            //decimal score1 = 0;
            //decimal score2 = 0;
            //decimal score3 = 0;
            //decimal average = 0;
            //Student student = new Student();


            //Console.WriteLine("Salam ortalamasini hesablamaq istediyiniz telebenin" +
            //                  "melumatlarini daxil edin");

            //Console.Write("Ad :\t");
            //name = Console.ReadLine();

            //Console.Write("Soyad :\t");
            //surname = Console.ReadLine();


            //Console.Write("1.Imtahan neticesi:\t");
            //score1 = Student.CheckInputTypeInt();

            //Console.Write("2.Imtahan neticesi:\t");
            //score2 = Student.CheckInputTypeInt();

            //Console.Write("3.Imtahan neticesi:\t");
            //score3 = Student.CheckInputTypeInt();


            //student.CalculateAverage(name, surname, score1, score2, score3);

            #endregion

            #region 2. para pul el cerki 2 yakinda sinemalarda
            /*
             * Evvelceden teyin edilen pin vasitesile ATM-ye yaxinlasan vetendas pini daxil edir.
             * Qarsinina cixan menu-dan balansina baxa, negd pul cixarda, ve ya umumi hesabdan cixaris
             * isteye biler.Secilen her hansi bir emeliyyatdan sonra istifadeci yeniden menuya- geri done bilmelidir.
             *
             *
             * login
             *
             * pin:
             * pin sadece reqemlerden ibaret olmalidir // 1234
             * pin sadece 4 reqemden ibaret olmalidir.
             *
             *
             * Menu
             *
             * 1.Balans:
             * (evvelceden standart olaraq balans 1000 azn olaraq nezerde tutulur.)
             *
             * 2.Negd pulun verilmesi:
             *  Istifadeci ATM-den min 1 manat max 1000 manat ceke biler.Balans yoxlamasi olacaq,
             *  daxil edilen mebleg hansi esginasdan nece eded olacaq o sekilde netice olaraq gosterilir.
             *   
             *
             * 3.Balansdan cixaris:
             *   Eger balansdan mexaric olubsa mexaric olunan meblegi ve hemin tarixi cap edin,
             *   Yox eger hele balansdan mexaric olunmayibsa bu haqqda mesaj gosterin.
             *
             *
             * Qeyd: consoledan daxil edilenler yalniz eded ola biler bular yoxlayanacaq ,
             * mumkun derece methodlarla isleyin
             *   
             */
            #endregion

            int pin = 1234;
            bool isValidPin = false;
            Hashtable records= new Hashtable();
            // start
            Console.Clear();
            Console.WriteLine("xos gelmisiniz");
            Console.WriteLine("pin daxil edin:\t");

            ValidationForPin(pin);

            do
            {
                // menu
                PrintMenu();

                int operation = CheckInputTypeInt(1, 4, "{0}den kicik {1}boyuk olabilmez");

                switch (operation)
                {
                    case 1:
                        ShowBalance(balance);
                        break;
                    case 2:
                        GivingCash(records);
                        break;
                    case 3:
                        BankStatementPrintRecords(records);
                        break;
                }
                // 1 show balance
                //Console.WriteLine(balance);




                Console.Write("Menuya geri don? b/x (beli/xeyr):\t");


            } while (Console.ReadLine().ToUpper()!="X");

            

            #endregion
        }

        private static void ShowBalance(decimal balance)
        {
            Console.Clear();
            Console.WriteLine("==================");
            Console.WriteLine("Balans:\t{0}",balance);
            Console.WriteLine("==================");
        }

        private static void GivingCash(Hashtable records)
        {
            ShowBalance(balance);

            int[] banknote = {200, 100, 50, 20, 10, 5, 1};

            int money, banknoteCount, i;
            Console.Write("Meblegi daxil edin : ");

            money = CheckInputTypeInt(1, balance, "{0}-den kicik ola bilmez {1}-den boyuk");

            balance -= money;
            BankStatement(money,DateTime.Now, records);
            Console.Clear();
            if (balance!=0)
            {
            Console.WriteLine("==========================");
            Console.WriteLine("Pullar hazirlanir");
                for (i = 0; i <= banknote.Length - 1; i++)
                {
                    banknoteCount = money / banknote[i];
                    if (banknoteCount != 0)
                        Console.WriteLine(banknoteCount.ToString() + " number : " + Convert.ToString(banknote[i] + " AZN "));
                    money %= banknote[i];
                }
            }
            else
            {
                Console.WriteLine("Ba;ansda pul yoxdur");
            }
        }

        private static void BankStatement(int money, DateTime date, Hashtable records)
        {
            if (records != null)
            {
                records.Add(money, date);
            }
           
           
        }

        private static void BankStatementPrintRecords(Hashtable records)
        {
            Console.Clear();
            if (records.Count != 0)
            {
                foreach (DictionaryEntry item in records)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("Pul:{0} Tarix:{1}", item.Key, item.Value);
                    Console.WriteLine("===================");
                }
            }
            else
            {
                Console.WriteLine("Hesabdan mexaric olmayib");
            }

        }


        private static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("Menu");
            Console.WriteLine("1.Balans");
            Console.WriteLine("2.Negd pulun verilmesi");
            Console.WriteLine("3.Cixaris");
            Console.Write("emeliyyat no daxil et");
        }
        public static int CheckInputTypeInt(int min, int max, string message)
        {
            int value = 0;

            bool control = false;

            while (control is false)
            {
                control = int.TryParse(Console.ReadLine(), out value);

                if (control)
                {
                    if (value < min || value > max)
                    {
                        Console.WriteLine(message, min, max);
                        control = false;
                    }
                }
                else
                {
                    Console.WriteLine("eded daxil etmelisiz");
                }
            }
            return value;
        }

        //public static decimal CheckInputTypeIntForLang(int min,int max,string message)
        //{
        //    decimal value = 0;

        //    bool control = false;

        //    while (control is false)
        //    {
        //        control = decimal.TryParse(Console.ReadLine(), out value);

        //        if (control)
        //        {
        //            if (value < min || value > max)
        //            {
        //                Console.WriteLine(message,min,max);
        //                control = false;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("eded daxil etmelisiz");
        //        }
        //    }
        //    return value;
        //}

        public static bool  ValidationForPin(int pin)
        {
            int value = 0;
            bool control = false;
            string input = string.Empty;
            while (control is false)
            {
                input = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
                {
                    if (input.Length > 4 || input.Length < 4)
                    {
                        Console.WriteLine("Daxil edilen pin 4 kicik ve ya boyuk ola bilmez");

                    }
                    else
                    {
                        control = int.TryParse(input, out value);

                        if (control)
                        {
                            if (value < 0)
                            {
                                Console.WriteLine("Daxil edilen pin duzgun deyil");
                                control = false;
                            }

                            if (value != pin)
                            {
                                control = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Daxil edilen pin duzgun deyil");
                        }
                    }
                    

                }
                else
                {
                    Console.WriteLine("Daxil edilen pin duzgun deyil");
                }
            }

            return true;
        }

    }
}
