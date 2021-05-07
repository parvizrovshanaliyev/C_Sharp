using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string

            //string groupName = "CSharp-02";

            //string courseName = "Pragmatech Education ";

            //Console.WriteLine(courseName +" "+ groupName);
            //Console.WriteLine("{0} {1}",courseName,groupName);

            //Console.WriteLine(groupName);
            //string toUpperCaseCourseName = courseName.ToUpper();
            //string toLowerCaseCaseName = groupName.ToLower();
            //string sbstrName = groupName.Substring(0, 6);
            //Console.WriteLine("----------string metodlari---------");
            //Console.WriteLine(toUpperCaseCourseName);
            //Console.WriteLine(toLowerCaseCaseName);
            //Console.WriteLine(sbstrName);
            #endregion

            #region char

            //char choise = 'a';

            #endregion

            #region byte, int

            //byte value = 10;

            //int value2 = 100;
            //Console.WriteLine("---byte");
            //sbyte byteMinVal = sbyte.MinValue;
            //sbyte byteMaxVal = sbyte.MaxValue;
            //Console.WriteLine(byteMinVal);
            //Console.WriteLine(byteMaxVal);

            //Console.WriteLine("---int");
            //int intMinVal = int.MinValue;
            //int intMaxVal = int.MaxValue;
            //Console.WriteLine(intMinVal);
            //Console.WriteLine(intMaxVal);

            #endregion

            #region double , float, decimal

            // double

            //double doubleVal = 10.2;
            //double doubleVal1 = 10;
            //double doubleVal2 = 10.9d;

            #endregion

            #region alistirma

            //Console.Write(" ad ve soyadinizi daxil edin: ");
            //string name = Console.ReadLine();

            //Console.Write("yasinizi daxil edin: ");
            //byte age = Convert.ToByte(Console.ReadLine());

            //Console.Write("yasadiginiz seher: ");
            //string city = Console.ReadLine();

            //Console.Clear();

            //Console.WriteLine(name);
            //Console.WriteLine(age);
            //Console.WriteLine(city);

            #endregion

            #region type conversion

            // implicit - bilincli
            // converting a smaller type to a larger type size
            // char -> int -> long -> float -> double

            //byte num1 = 10;
            //int num2 = num1;

            //// explicit - bilinciz
            ////Explicit Casting(manually) -converting a larger type to a smaller size type
            ////double -> float -> long -> int -> char

            //int num3 = 254;
            //byte num4 = (byte) num3;

            #endregion

            #region object
            #region boxing

            //int a = 5;
            //object b = a;

            #endregion

            #region unBoxing

            //object age3 = 28;
            //int age2 = (int) age3;






            #endregion

            #region casting
            //checked
            //{
            //    decimal Sayi1 = 9999999990;
            //    int Sayi2 = (int)Sayi1;
            //}
            //unchecked
            //{
            //    int Sayi1 = 999999999;
            //    byte Sayi2 = (byte)Sayi1;
            //}
            #endregion

            #endregion

            #region type conversion 2

            #region string uzerinde emelliyyatlar

            #region parse
            // ancaq stringden diger tipe kecen zaman
            //istifade edilir

            //string request = "123";

            //Console.WriteLine(request + 5);

            //short x =short.Parse(request);
            //Console.WriteLine(x*5);
            //string a = "Parviz";
            //int a2 = int.Parse(a);
            /////
            //string b = "evli";
            //bool b2 = bool.Parse(b);

            #endregion

            #region convert
            // her bir tipi diger tipe cevirmek olar
            //string x1 = "25";
            //int x3=Convert.ToInt32(x1);
            //Console.WriteLine("x3:{0}",x3);
            //
            //string x = "3,14";
            //double d=Convert.ToDouble(x);

            #endregion

            #endregion

            #region diger tipler uzerinde emeliyyatlar

            #region convertToString

            //int a = 25;

            //string s = Convert.ToString(a);

            #endregion

            #region toString
            // butun tiplerde istifade edile biler
            //float f = 35;
            //string f2 = f.ToString();

            #endregion

            #endregion

            #region implicit
            // compiler terefinden
            //int a = 3000;
            //float a2 = a;
            //
            //short x = 123;
            //long x2 = x;

            #endregion

            #region expilict
            // manual
            //int c = 60000;
            //short c1 = (short)c;


            //int v = 3000;
            //short s = (byte) v;
            //Console.WriteLine(s);
            #endregion

            #region checked - unChecked
            // explicit
            // data itkisini yoxlayiriq xeta verir
            //checked
            //{
            //    int a = 500;
            //    byte b = (byte) a;
            //    Console.WriteLine(b);
            //}

            //// unchecked explicit
            //// default olan formasi
            //// xata vermir
            //unchecked
            //{
            //    int a = 500;
            //    byte b = (byte)a;
            //    Console.WriteLine(b);
            //}

            #endregion

            #region special type conversion

            //bool b = true;
            //int i = Convert.ToInt32(b);
            //Console.WriteLine(i);

            //int a  = -123;
            //bool b = Convert.ToBoolean(a);
            // char
            // ASCII
            //char a = 'A';
            //int b = (int) a;

            //Console.WriteLine(b);

            //int c = 99;
            //char d = (char) c;

            //Console.WriteLine(d);

            #endregion

            #endregion

            int[] items = Test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 });

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        #region test

        static int[] Test(int[] numbers)
        {
            int size = numbers.Length, index = 0;
            int[] newArr =new int[size];

            for (int i = 0; i < size; i++)
            {
                if (numbers[i] != 5)
                {
                    ++index;
                    newArr[index] = numbers[i]; // index ramda 1 olsada emelliyat once geldiyinden  newArr[0]=0 yeni 1 olur
                }
            }
            return newArr;
        }
        //static int[] test(int[] numbers)
        //{

        //    return null;
        //}
        #endregion
    }
}
