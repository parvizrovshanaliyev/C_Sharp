using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arithmetic
            // +
            // -
            // *
            // /
            // %
            #region geriye donus deyeri 

            //int result = 3 + 5;
            //int x = 3;
            //int y = 5;
            //int result = x * y;
            // eyni tipde geriye ortaq tipi verir
            //double x = 3;
            //double y = 5;
            //double result = x / y;
            //decimal x = 1234;
            //decimal y = 4356;
            //var result = x % y;
            // ferqli tipler uzerinde emeliyyatlar
            // hansi tip boyukdurse result-in tipi o olacaq
            // implicit casting
            //int x = 10;
            //double y = 5;
            //var result = x + y;

            /////////string////////
            // string + int (string)
            // int +string(string)
            // string + string (string)


            #region istisna (byte) * (byte)
            // geriye int qaytarir hemise
            //byte x = 250;
            //byte y = 6;
            //var result = x * y;

            #endregion

            #endregion

            #region operator onceliyi

            //var x = 7 + 3 * 10;
            /*
             * ++
             * --
             * 
             */
            //int i= 10
            //Console.WriteLine(i++); // 10 // ram 11
            //Console.WriteLine(++i); // 11 // ram 11
            #endregion

            #region example
            /*
             * HI,
             * Name
             * Surname
             * Birthdate
             *
             * clear console
             *
             * Hi , Name Surname age
             *
             */
            //Console.WriteLine("HI, ");
            //Console.Write("Name : ");
            //string name = Console.ReadLine();
            //Console.Write("Surname : ");
            //string surname = Console.ReadLine();
            //Console.Write("Birthdate : ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //int currentYear = DateTime.Now.Year;
            //int age = currentYear - year;

            //Console.Clear();

            //Console.WriteLine("HI, {0} {1}  age: {2}",name, surname, age);


            #endregion

            #region example 2

            /*
             * Enter number 1 :
             * Enter number 2 :
             *
             *Result
             *
             * + :
             * - :
             * / :
             * * :
             * % :
             */

            #endregion

            #endregion

            #region relational
            // iki deyer arasinda boyuk , kicik ve beraber olmasini
            // munasibetini qarsilasdiran operatorlardir
            // geriye boool tipi qaytarir
            /*
             * <
             * >
             * <=
             * >=
             * ==
             */

            #endregion

            #region logical
            /*
             * &&  ve
             * ||  ve ya
             * ^   ya da
             */

            //Console.WriteLine(true && true); // true
            //Console.WriteLine(true && false); // false
            //Console.WriteLine(false && false); // false
            //Console.WriteLine(false && true); // false

            //Console.WriteLine(true || true); // true
            //Console.WriteLine(true || false); // true
            //Console.WriteLine(false || false); // false
            //Console.WriteLine(false || true); // true

            //Console.WriteLine(true ^ true); // false
            //Console.WriteLine(true ^ false); // true
            //Console.WriteLine(false ^ false); // false
            //Console.WriteLine(false ^ true); // true
            // t //t
            //Console.WriteLine((true && false) || false && ((true ^ false)&&false)||true);

            #endregion

            #region string ifadeler-de + , += , == opretatorlarinin istifadesi

            //string x = "csharp-02";
            //string y = "pragmatech";

            //Console.WriteLine(x+y);


            #endregion

            #region deyil ! != beraber deyilse

            #endregion

            #region ternary
            // bir deyisene/ metoda / property-e deger veren zaman ,
            // serte gore deyer verilecekse tek setrde sert yazmagimiza 
            // imkan verir 

            //bool isStudent = true;
            //string message = isStudent == true ? "Telebedir" : "Telebe deyil";
            ///////////


            #region example task
            /*
             * yasi 25-den kicik olanlara A,
             * 25 olanlara B ve 25-den boyuk olanlara ise C
             * deyeri veren ternary operator yazin.
             */

            //int age = 25;

            //string result = age < 25 ? "A" : (age == 25 ? "B" : "C");

            /*
             * istifadeci terefinden daxil edilen number
             * asagidaki teleblere esasen hesablayib
             * neticeni ekrana yazdirin
             *
             * number < 3                              => number * 5
             * number > 3 && number < 9                => number * 3
             * number >= 9 && number % 2 == 0          => number * 10
             * number % 2 == 1                         => number
             * hecbiri deyilse                         => -1
             */

            //Console.Write(" enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int result = number < 3
            //    ? number * 5
            //    : number > 3 && number < 9 ? number * 3 :
            //        (number >= 9 && number % 2 == 0) ? number * 10 :
            //            (number % 2 == 1) ? number : -1;

            //Console.Clear();

            //Console.WriteLine("Result: {0}",result);


            /*
             * Hava 
             */
            #endregion
            #endregion

            #region member access . operatoru

            #endregion

            #region typeof operatoru
            /*
             * typeof verilen tipin/ deyerin tipini geri verir
             * onunla elaqeli melumatlari verir
             * reflection hissesinde istifade edeceyik
             */

            //Type t = typeof(int); // int tipine aid xususiyyetler t tipine verilir
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.IsPrimitive);
            //Console.WriteLine(t.IsClass);
            //Console.WriteLine(t.IsValueType);

            #endregion

            #region default operatoru
            /*
             * verilen tipin default deyerini gerir verir
             * default deyer her tip icin standart / varsayilan deyer demekdir
             * number = 0
             * bool = false
             * string = null
             * char =\0
             * reference = null
             * */
            //Console.WriteLine(default(decimal));
            //Console.WriteLine(default(string));
            //Console.WriteLine(default(Program));
            //Console.WriteLine(default(byte));
            //int a = default;
            //int _a = default(int);
            #endregion

            #region is operatoru
            /*
             * Boxing edilmis her hansisa bir deyerin
             * oz tipini check etmek ucun istifade edilir
             * geriye bool qaytarir
             *
             * if bloklarinda istifade edilir
             * OOP-de obyektlerin tipini oyreneceyik
             */
            //object x = true;
            //Console.WriteLine(x is bool);
            #endregion

            #region is null operatoru
            /*
             * Bir deyisenin deyerinin null olub olmamasini
             * check etmek ucun istifade edilir
             * bool tipinde deyer qaytarir
             * sadece null ola bilen tiplerde istifade edilir
             * reference tiplerde
             */

            //string a = "notNull";
            //Console.WriteLine(a is null);
            //Console.WriteLine(a == null);


            #endregion

            #region is not null operatoru
            /*
             * Bir deyisenin deyerinin null olub olmamasini
             * check etmek ucun istifade edilir
             * bool tipinde deyer qaytarir
             * sadece null ola bilen tiplerde istifade edilir
             * reference tiplerde
             */

            //string a = "notNull";
            //Console.WriteLine(a is not null);


            #endregion

            #region as operatoru
            /*
             * () cast operatorunun Unboxing emeliyyatina
             * alternativ olaraq istifade edilir
             * xeta vermir null qaytarir. => () xeta verir
             * reference tiplerde istifade edilir
             */
            //object x = "123";
            //string y =  x as string;

            #endregion

            #region ? (Nullable) Operatoru
            // value type deyisenler null deyer ala bilmirler
            // BIr value type null ola bilmesi ucun  ? bu operatordan
            // istifade edilir

            //int? a = null;
            //bool? b = null;
            #endregion

            #region ?? null coalescing operatoru
            /*
             * deyisenin deyeri null oldugu halllarda
             * deyisene ferqli bir deyer vermeyimize imkan verir ??
             * operatorun her iki terefinde tipler eyni olmalidir
             */
            //string a = "course";

            //Console.WriteLine(a ?? "a is Null");

            #endregion

            #region ??= null coalescing c# 8.0
            /*
             * null deyilse deyisene deyer verir
             */
            //string x = null;

            //Console.WriteLine(x ??="is not null");
            //Console.WriteLine(x);

            //int? id = null;
            //id ??= 1;

            #endregion

            #region Example

            #region 1

            /*
             * Istifadecidenn gelen 3 ferqli imtahan neticelerinin
             * ortalamasinin 45-den  boyuk ve ya beraber olmasini
             * yoxlayin.
             * Netice olaraq console-da : Ortalama
             * deyer 45 -den boyuk  ve ya beraberdirmi ?
             * "beli ve ya xeyr"(Ortalamani 45-le muqayise etdikden
             *  sonra string ifade beli -xeyr ) : Ortalama
             * 
             */

            Console.Write("1. Exam score :");
            decimal score1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2. Exam score :");
            decimal score2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("3. Exam score :");
            decimal score3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Your values have been received, the calculation is being done");

            decimal average = (score1 + score2 + score3) / 3;

            bool controlResult = average >= 45;

            string result = controlResult ? "Yes" : "No";

            Console.Clear();

            Console.WriteLine("------------------------");
            Console.WriteLine("1. Exam score : {0}",score1);

            Console.WriteLine("2. Exam score : {0}",score2);

            Console.WriteLine("3. Exam score : {0}",score3);
            Console.WriteLine("------------------------");

            Console.WriteLine("Is the average value greater than 45 or equal to ?");
            
            Console.Write(" '{0}' : '{1}' ",result,average);
            #endregion

            #endregion

            Console.ReadLine();

        }
    }
}
