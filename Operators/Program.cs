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

            Console.ReadLine();

        }
    }
}
