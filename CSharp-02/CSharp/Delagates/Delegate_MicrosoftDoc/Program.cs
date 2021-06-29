using System;

namespace Delegate_MicrosoftDoc
{
    class Program
    {
        static void Main(string[] args)
        {
            #region delegate

            /*
             * Delegate method imzasini temsil eden reference typedir.
             * Delegate vasitesile bir sira geri donus tipine ve ya parametr qebul eden method=larin cagrilmasini
             * temin ede bilerik : delegate ozunde methodlari saxlamaqdadir ve onlari ram uzerinde depolayir.
             * her hansisa bir method delegate-den instance almaqla ise salina bilmekdedir.
             *
             * Delegate method-lari basqa methodlara argument olaraq oture bilmeyimize imkan yaradir.
             *
             * Windows form-da qarsimiza cixan Event Handler ozude delegate type dir.
             *
             * Delegate vasitesile invoke edilen methodlarin geri donus deyeri ve qebul etdiyi parametrler
             * bire bir eyni olmalidir.
             *
             *
             * Delegate vasitesile ard-arda birden cox method invoke edile bilmekdedir .
             *
             * **************
             * Delegate ise salinmasi ucun once onu bir deyisen olaraq teyin edirik sonra ona eyni imzaya sahib
             * methodlari set edirik en sonda invoke emeliyyati yerine yetirilir.
             *
             * Declare : [access modifier] delegate [return type] [delegate name]([parameters])
             *
             *           public delegate void MyDelegate(string msg);
             *
             * Delegate class daxilinde ve xaricinde teyin edile bilmekdedir.
             *
             * Bir delegate teyin edildikden sonra set edilecek bir method ve ya lambda expression istifade
             * edilmelidir
             *
             *
             * https://www.tutorialsteacher.com/csharp/csharp-delegates
             */

            #endregion

            // invoke
            del.Invoke("Hello World!");
            // or 
            //del("Hello World!");

            #region Passing Delegate as a Parameter

            MyDelegate del1 = ClassA.MethodA;
            ClassA.InvokeDelegate(del);

            del1 = ClassB.MethodB;
            ClassA.InvokeDelegate(del);

            del1 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            ClassA.InvokeDelegate(del);

            #endregion

            #region Generic Delegate



            #endregion
        }
        public delegate int PerformCalculation(int x, int y);



        #region set target methods or lambda expressions and Invoke
        public delegate void MyDelegate(string msg); // declare a delegate

        // set target method
        //static MyDelegate del = new MyDelegate(MethodA);
        // or 
        static MyDelegate del = MethodA;
        // or set lambda expression 
        //static MyDelegate del = (string msg) => Console.WriteLine(msg);

        // target method
        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }

        #endregion

        #region Passing Delegate as a Parameter
        public delegate void MyDelegate1(string msg); //declaring a delegate
        static class ClassA
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }

            public static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
            {
                del("Hello World");
            }
        }

        static class ClassB
        {
            public static void MethodB(string message)
            {
                Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
            }
        }

        #endregion

        #region Generic Delegate
        public delegate T add<T>(T param1, T param2); // generic delegate

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
        #endregion
    }

}
