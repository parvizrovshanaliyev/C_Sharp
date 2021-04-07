using System;
using System.Collections;

#region collections
/*
 * Array ve Collection arasindaki ferq nelerdir?
 *
 * Bu level ucun oyreneceyimiz colection-lar deyer olaraq object tipinden
 * deyerleri  qebul etdikleri ucun  ve . net framework strukturunda
 * butun classlar object classindan inheritance(qabaqki derslerde danisacayiq) aldigi ucun butun data typelari
 * qebul ede bilecek mexanizme sahibdirler.
 *
 * Collectionlarda Array-de oldugu kimi her hansisa serhed yoxdur.
 *
 * Collectionlarda teyin olunan yer/serhed doldugu zaman avtomatik olaraq
 * icerisindeki movcud yeri artira bilirler.
 *
 * Generic movzusundan sonra Generic Collectionlari goreceyik.
 */

#region arrayList
/*
 *
 */
//string[] values = new string[10];
//ArrayList a = new ArrayList();

#region add
/*
 * object tipinde qebul etdiyi ucun ferqli tipleri add ede bilirik,
 * yalniz bir deyer daxil eden zaman
 */
//ArrayList a = new ArrayList();
//a.Add("Birinci deyer");


#endregion

#region addRange
/*
 * eyni anda birden cox deyerin ArrayListe daxil edilmesi
 */
//ArrayList a2 = new ArrayList();

//a2.Add("Ikinci deyer");
//a2.Add(1234);

//a.AddRange(a2);


#endregion

#region capacity,Count
/*
 * Capacity collection-nin ala bileceyi maksimum deyeri ifade edir.
 * Count hazirda icerisindeki element sayini ifade edir.
 *
 * Collectiona yaranan zaman bunlar ikiside 0 olaraq teyin edilir,
 * Lakin collectiona bir deyer menimseden zaman Count 1 ,
 * Capacity 4 olaraq deyismektedir.
 *
 * her defe yeni element daxil edilerken belece capacity artmaqdadir.
 * ArrayList-den evvel bunu elmizle etmeli idik sonrada net framework bele bir
 * struktur yaratdi ve arraye nisebeten cox istifade oluna veziyyete geldi,
 * hazirki zaman ucun arrayListlerde GenericCollectionlara nisbetde az istifade
 * edilir.
 */

//int capacity = 0;
//int count = 0;
//ArrayList b = new ArrayList();
//b.Add("1");
//b.Add("2");
//capacity = b.Capacity;
//count = b.Count;
#endregion

#region arrayListden deyerini oxuma ve deyisdirme
/*
 * Array strukturunu basa dusulmesi onemlidir, cunki
 * ArrayListde-de indexer dediyimiz operator ile istenilen indexdeki
 * elementin deyerini oxuya bilerik.
 */
//ArrayList c = new ArrayList();
//c.Add("1");
//c.Add("2");

//object c1 = c[0];
//string c2 = c[0].ToString();


//c[0] = "deyisdirilen deyer";

#endregion

#region deyerin silinmesi
ArrayList f = new ArrayList();
//f.Add("silinecek");
// uygun deyere sahib elementi silir
//f.Remove("silinecek");
// removeRange
/*
 * Remove range bizden basyacagi Index-i ve silinecek element sayini
 * isteyir.
 */
//f.Add("Yeni 0-ci deyer");
//f.Add("Yeni 1-ci deyer");
//f.RemoveRange(0,1);
//f.Add("1");

// removeAt
/*
 * uygun idexe sahib elementi silir.
 */
//f.RemoveAt(0);
#endregion

#region siralama
/*
 * A-Z siralama // Sort
 * qeyd: sort-la siralayan zaman meselen stringler icersinde birdene
 * int tipinde elementiniz varsa size xeta verecek.
 * Reverse tersine cevirme // Reverse
 */


#endregion

#region helpers commands
/*
 * deyerin collectionda olub olmamasini yoxlaya bilerik ve geriye bool deyer
 * qaytarir.
 */
//ArrayList n = new ArrayList();
//n.Add("axtarilan deyere sahib element");
//bool check1 = n.Contains("axtarilan deyere sahib element");

/*
 * IndexOf
 * uygun deyere sahib elementin index qarsiligini verir.
 */
//n.Add("IndexOf");
//if (n.Contains("IndexOf"))
//{
//    int itemIndex = n.IndexOf("IndexOf");
//    n.RemoveAt(itemIndex);
//}

/*
 * Clear collection icerisindeki deyerleri silir.
 *
 */
//n.Clear();

/*
 * Clear metodu ile elementler silinse bele capacity deyismeden oldugu kimi
 * qalmaqdadir.
 *
 */
//n.TrimToSize();
#endregion

#region toArray

//object[] objects = n.ToArray();

#endregion

#region example 10 elementli array listi z-a-ya siralayin



#endregion
#endregion

#region tasks

#region arrayList

#region Create,List,Update,Delete,Search
/*
 * Asagida gosterilen emeliyyatlarin icra edilmesi lazimdir (arrayList).
 * Once asagidaki menu cap edilecek ve sonra istifadecinin secimine gore
 * emeliyyatlar icra edilecek, emeliyyatlarin icrasi istifadeci 6.Cixis
 * emeliyyatini secenedek davam ede biler ard-arda, her emeliyyatdan sonra
 * console penceresi temizlenir.
 *
 *  
 *
 *     Console.WriteLine("Menu");
 *     Console.WriteLine("1. Deyer Elave Et");
 *     Console.WriteLine("2. Butun Deyerleri Goster");
 *     Console.WriteLine("3. Axtar");
 *     Console.WriteLine("4. Redakte Et");
 *     Console.WriteLine("5. Deyer Sil");
 *     Console.WriteLine("6. Cixis");
 *     Console.Write("Secin:\t");
 *
 * 1.Deyer Elave Et - istifadeci deyeri daxil etdikden sonra,
 * elave edilme barede mesaj gosterilecek.
 * ve asagidaki kodu elave edersiz en son
 * Console.WriteLine("Davam edin");
   Console.ReadLine();
 *
 * 2. Butun Deyerleri Goster- array list daxilindeki butun deyerlerin
 * siyahisi gosterilir.
 *
 * 3. Axtar - Istifadeci axtarmaq istediyi deyeri daxil edir, ona gore deyerin
 * tapilib tapilmamasi barede xeberdarliq mesaji eger tapilibsa elave olaraq
 *  deyerin index sirasi ve deyeri gosterilir.
 * Axtarilan deyer siyahida yoxdursa :
 * Axatardiginiz deyer siyahiya elave edilsinmi ? b/x (b: beli,x:(xeyr)
 * cavaba gore axtarilan deyeri siyahiya elave edirsiz.
 * Console.WriteLine("Davam edin");
   Console.ReadLine();
 *
 * 4. Redakte Et - Istifadeci siyahida olan elementlerden redakte edeceyi deyeri daxil edir.
 * Redakte edilen elementin yeni deyerini daxil edir, netice olaraq deyer deyisdirildikden sonra redakte haqqinda
 * xeberdarliq mesaji gosterilir.
 * Console.WriteLine("Davam edin");
   Console.ReadLine();
 *
 *
 *
 * 5. Deyer Sil - Butun deyerleri silmek isteyirsinizmi? : b/x (b: beli,x:(xeyr)
 * Daxil edilen b ise butun siyahidaki elementler silinir, deyilse silmek istediyi deyeri isteyirik,
 * emeliiyatin sonund xeberdarliq mesaji verilir.
 *Console.WriteLine("Davam edin");
  * Console.ReadLine();
 */

//string userChoice = string.Empty;
//ArrayList valueList = new ArrayList();
//do
//{
//    Console.Clear();
//    Console.WriteLine("Menu");
//    Console.WriteLine("1. Deyer Elave Et");
//    Console.WriteLine("2. Butun Deyerleri Goster");
//    Console.WriteLine("3. Axtar");
//    Console.WriteLine("4. Redakte Et");
//    Console.WriteLine("5. Deyer Sil");
//    Console.WriteLine("6. Cixis");
//    Console.Write("Secin:\t");

//    userChoice = Console.ReadLine();

//    string searchedVal;
//    string yesOrNo;
//    switch (userChoice)
//    {
//        case "1":
//            Console.Write("Deyeri elave edin:\t");
//            string addedVal = Console.ReadLine();
//            valueList.Add(addedVal);
//            Console.WriteLine("Elave edildi");
//            Console.WriteLine("Davam edin");
//            Console.ReadLine();
//            break;
//        case "2":
//            for (int i = 0; i < valueList.Count; i++)
//            {
//                Console.WriteLine("{0}. Deyer = {1}",i,valueList[i]);
//            }
//            Console.WriteLine("Davam edin");
//            Console.ReadLine();
//            break;
//        case "3":

//            Console.Write("Axtarmag istediyiniz deyeri daxil edin: ");
//            searchedVal = Console.ReadLine();
//            int searchedValIndex = valueList.IndexOf(searchedVal);
//            if (searchedValIndex != -1)
//            {
//                string value = valueList[searchedValIndex]?.ToString();
//                Console.WriteLine("Axtarilan deyer tapildi: index sirasi :{0} -Deyer :{1}",searchedValIndex,value);
//            }
//            else
//            {
//                Console.WriteLine("Axatarilan deyer tapilmadi");
//                Console.Write("Axatardiginiz deyer siyahiya elave edilsinmi ? b/x (b: beli,x:(xeyr))");
//                yesOrNo = Console.ReadLine();

//                if (yesOrNo.ToUpper() == "B")
//                {
//                    valueList.Add(searchedVal);
//                        Console.WriteLine("Elave edildi");
//                }
//            }

//            searchedVal = string.Empty;
//            yesOrNo = string.Empty;
//            Console.WriteLine("Davam edin");
//            Console.ReadLine();
//            break;
//        case "4":
//            Console.Write("Redakte edilecek deyeri daxil edin:\t");
//            searchedVal = Console.ReadLine(); 
//            Console.Write("{0} deyerinin yerine yeni deyer daxil edin:\t",searchedVal);
//            string newVal = Console.ReadLine();
//            if (valueList.Contains(searchedVal))
//            {
//                int searchedValIndex2 = valueList.IndexOf(searchedVal);
//                valueList[searchedValIndex2] = newVal;
//                Console.WriteLine("{0} deyeri {1} deyerine redakte edildi",searchedVal,newVal);
//            }
//            else
//            {
//                Console.WriteLine("Tapilmadi");
//            }
//            searchedVal = string.Empty;
//            Console.WriteLine("Davam edin");
//            Console.ReadLine();
//            break;
//        case "5":
//            Console.Write("Butun deyerleri silmek isteyirsinizmi? : b/x (b: beli,x:(xeyr)");
//            yesOrNo = Console.ReadLine();
//            if (yesOrNo.ToUpper() == "B")
//            {
//                valueList.Clear();
//                Console.WriteLine("Siyahi temizlendi");
//            }
//            else
//            {
//                Console.Write("silmek istediyiniz deyeri daxil edin:\t");
//                searchedVal = Console.ReadLine();

//                if (valueList.Contains(searchedVal))
//                {
//                    valueList.Remove(searchedVal);
//                    Console.WriteLine("{0} deyeri silindi.",searchedVal);
//                }
//                else
//                {
//                    Console.WriteLine("tapilmadi");
//                }
//            }
//            yesOrNo = string.Empty;
//            searchedVal = string.Empty;
//            Console.WriteLine("Davam edin");
//            Console.ReadLine();
//            break;
//        default:
//            break;

//    }
//} while (userChoice!="6");

#endregion

#endregion


#endregion
#endregion
