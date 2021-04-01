using System;
using System.Globalization;
using System.Threading.Channels;

#region arrays
/*
 * bir deyisen altinda birden cox eyni tipli deyeri saxlamagimiza
 * imkan verir.
 *
 * Demeli arrayler prosedual programlasdirmanin temel anlayislarindan
 * olmaqla yanasi daha sonra oyreneceyimiz Collection-larinda temelini ozeyini
 * teskil etmektedirler.
 *
 * Reference tipindedirler. Ozlerinde onlarda bir classdir deye bilerik.
 *
 * Demeli bunlar reference type olduqlarindan ramde -heap hissesinde saxlanirlir.
 *
 * Hemcinin Arrayler icerisindeki elemetleri daginiq sekilde deyil indexleyerek,
 *
 * sirali bir sekilde depolayir. Index her zaman 0-dan n-1 qeder gedir.
 *
 * [] - indexer adlanir.
 *
 * arrayler serhedi olan anlayislardir. Yeni nece element teyin edilecek sayi bildirilmelidir.
 *
 * sayi bildirilen arrayler daxil edilen say qeder ramde yer tuturlar (istifade etsekde etmesekde) bu zaman
 *
 * once tipin default deyeri sonra index nomresi qeyd olunur index : value
 *
 * qeyd edilen arrayin serhedini kecsek yeni int [7] 7 elementli bir arraye ondan elave
 * element artira bilmerik. xeta verir
 *
 *
 *
 */

#region array yaradilmasi


//// array yaradilmasi
//int[] ages = new int[10];
//int[] ages = new[] { 1, 2, 3, 4 };
//int[] ages = { 1, 2, 3, 4 };

#endregion


//// arrayin elementlerine deyerlerin menimsedilmesi

//ages[0] = 15;
//ages[4] = 20;

#region arraylerde loop

//string[] products = new string[10];

//for (int i = 0; i < products.Length; i++)
//{
//    products[i] = "product" + i;
//    Console.WriteLine(products[i]);
//}

//Console.WriteLine(products.Length);

#endregion

#region foreach
//string[] products = new string[10];

//for (int i = 0; i < products.Length; i++)
//{
//    products[i] = "product" + i;
//}

//foreach (var item in products)
//{
//    Console.WriteLine(item);
//}

#endregion

#region array class
/*
 * Array class nedir ?
 *
 * class movzusunu OOP-de etrafli baxacayiq.
 *
 * Array olaraq yaradilan deyisenler eslinde Array classindan gelmektedir.(inheritance)
 * Arraylerde array clasindan gelen metodlar ve ozellikler movcuddur.
 *
 */

// normal qaydada array teyin ederken indexer operatorundan istifade etmeliyik
// class olaraq teyin edilerse indexer ehtiyyac yoxdur.
//int[] numbers = new int[3]; // algoritmlerde / operativ istifade edilir
//Array numbers2 = new int[3];  //

#region array classinin elementlerine deyer verilmesi

//Array numbers = new int[]{1,2,3};
//Array numbers = new int[3]{1,2,3};
//Array numbers = new[] {1,2,3};

//2.

//Array numbers = new int[3];

//numbers.SetValue(10,0);

// deyerin oxunmasi

//object val = numbers.GetValue(1);
#endregion

#region methods

#region clear
/*
 * array-in icerisindeki elementlerin deyerini arrayin tipine uygun default deyer
 * menimsedir.
 * yeni silmir default deyer verir.
 */
//Array names = new[] {"Resad", "Ferid", "Avaz"};
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names.GetValue(i));
//}
//Array.Clear(names, 0, names.Length);
//Console.WriteLine("+++++++");
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names.GetValue(i));
//}
#endregion

#region copy
/*
 * Bu metodla bir arrayin deyerlerini basqa bir arraye kopyalayiriq.
 */
//Array names = new[] { "Resad", "Ferid", "Avaz" };

//string[] names2 = new string[names.Length];

//Array.Copy(names,names2,2);

#endregion

#region indexOf
/*
 * Bir array-de element olub olmadigini yoxlayir.
 * Axtarilan deyerin index nomresini qaytarir. yoxdursa -1 qaytarir
 */
//Array names = new[] { "Resad", "Ferid", "Avaz" };

//var index=Array.IndexOf(names, "Resad");

//if (index != -1)
//{

//}
#endregion

#region reverse
/*
 * array icerisinde elementleri tersine siralayir
 */
//Array names = new[] { "Resad", "Ferid", "Avaz" };
//Array.Reverse(names);
#endregion

#region sort
/*
 * siralama isini gorur
 */


#endregion

#region createInstance

//int[] values = new int[3];

//Array valuesArray=Array.CreateInstance(typeof(int),3);

#endregion

#endregion

#region properties / ozellikler

#region IsReadOnly



#endregion

#region IsFixedSize



#endregion

#region Length



#endregion

#region Rank

/*
 * arrayin derecesini nece multidimensional
 *
 */

#endregion

#endregion
#endregion

#region c# 8.0 ranges  and indices // System.Ranges - System.Index opearator .. ^
/*
 * index tipi arrayler ve collectionlardaki elementin indexini saxlamaqdadir.
 * ^ operator tersine istifade edilerse normal arraylerde
 * 0-dan baslayib n-1 bire gedirdise burada 1-den baslayib n- gedir
 */

//string[] names = {"a", "b", "c"};
//Index index = 2; // "c"

//Index index2 = ^2; // "b"

#region range System.Range
/*
 * deyer araligi vererek istifade edilir.
 */
//int[] numbers = new[]{ 1, 2, 3,4,5,6,7,8,9 };

//Range range = 3..7; // 3 indexdir ; 7 ise siradir
//Range range1 = ^3..7; // 3 indexdir ; 7 ise siradir


//Range range = ..; // kopyalama ucun bele istifade edile biler

//var numbers2 = numbers[range];
#endregion
#endregion

#region example

#region 1.

/*
 * int tipinde bir array yaradin, hemin arrayin nece elementden
 * ibaret olacagini istifadeci daxil etsin, bundan sonra hemin arrayin
 * elementlerinin deyerlerini daxil edir, netice olaraq arrayin daxilindeki
 * elementlerin tek-tek deyerlerini, cemini ve oratalamasini cap edin.
 */
//Console.Write("Array ucun element sayini daxil edin:\t");
//int arrLength=Convert.ToInt32(Console.ReadLine());

//int[] numbers = new int[arrLength];

//for (int i = 0; i < arrLength; i++)
//{
//    Console.Write(" INDEX: {0}. elementin deyerini daxil edin:\t",i);
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//int total = 0, average = 0;
//Console.WriteLine("+++++++++++++");
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//    total += item;

//}

//average = total / arrLength;
//Console.WriteLine("+++++++++++++");
//Console.WriteLine("total:\t{0}, average:\t{1}",total,average);

#endregion

#region 2. random
/*
 * 20 elementden ibaret olan bir array yaradin.
 * Arrayin elementlerin deyerlerini Random classinin next funksiyasi ile
 * 1-10 arasinda deyerler ile doldurun. Elementlerini ekrana cap etdikden sonra,
 * array icerisinde nece eded 4 oldugunu tapin.
 */
//Random random = new Random();

//int[] numbers = new int[20];

//for (int i = 0; i < numbers.Length;i++)
//{
//    numbers[i] = random.Next(1, 10);
//}

//int controlIteration = 0;
//Console.WriteLine("+++++++++++++");
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//    if (item is 4)
//        controlIteration++;
//}

//if (controlIteration is 0)
//    Console.WriteLine("array icersinde 4 deyeri yoxdur");
//else
//    Console.WriteLine("array icerisinde 4 deyerinin sayi:\t{0}",controlIteration);


#endregion

#endregion

#region task

#region Reverse an array without using Array.Reverse()
//int[] arr = { 1, 3, 4, 9, 8 };

//foreach (var i in arr)
//{
//    Console.WriteLine(i);
//}

////for (int i = 0; i < arr.Length / 2; i++)
////{
////    int tmp = arr[i];
////    arr[i] = arr[arr.Length - i - 1];
////    arr[arr.Length - i - 1] = tmp;
////}

//foreach (var i in arr)
//{
//    Console.WriteLine(i);
//}
#endregion

#region Array sort in asscending order

//int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
//int temp = 0;

//for (int i = 0; i <= intArray.Length - 1; i++)
//{
//    for (int j = i + 1; j < intArray.Length; j++)
//    {
//        if (intArray[i] > intArray[j])
//        {
//            temp = intArray[i];
//            intArray[i] = intArray[j];
//            intArray[j] = temp;
//        }
//    }
//}
//Console.WriteLine("Array sort in asscending order");
//foreach (var item in intArray)
//{
//    Console.WriteLine(item);
//}
//Console.ReadLine();

#endregion

#endregion
#endregion

#region multidimensional



#endregion
