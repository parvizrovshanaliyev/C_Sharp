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

#endregion
