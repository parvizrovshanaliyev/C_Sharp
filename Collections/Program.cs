using System;
using System.Collections;

#region collections
/*
 * Array ve Collection arasindaki ferq nelerdir?
 *
 * Bu level ucun oyreneceyimiz colection-lar deyer olaraq object tipinden
 * deyerleri  qebul etdikleri ucun(dezavantajlardan biri)  ve . net framework strukturunda
 * butun classlar object classindan inheritance(qabaqki derslerde danisacayiq) aldigi ucun butun data typelari
 * qebul ede bilecek mexanizme sahibdirler.
 *
 * Collectionlarda Array-de oldugu kimi her hansisa serhed yoxdur.
 *
 * Collectionlarda teyin olunan yer/serhed doldugu zaman avtomatik olaraq
 * icerisindeki movcud yeri artira bilirler.
 *
 * Generic movzusundan sonra Generic Collectionlari goreceyik.
 *
 * Collection-larin avantajlari :
 * eyni ve ferqli tiplerde deyerleri bir yerde
 * saxlayib istifade ede bilmeyimiz.
 *
 * Array-lerde uzunluq mecburi sekilde qeyd edilerken , collection
 * dinamikdir.
 *
 * Collection-a element elave etdikce capacity dinamik olaraq artirilir,
 * Ram-daki yere gore
 *
 *
 * Collection icindeki elementlere foreach(iterator) ile cata bilerik,
 * bunun sebebi Collection-larin IEnumerable interface-ni implement etmesinden
 * qaynaqlanir,
 * burdanda bu neticeye gelmek olarki, her collection base obyektlerimiz
 * IEnumerable(OOP-derslerimizde bu movzuya geri qayidacagig helelik oxuyub kecin) interface-ni implement etmekdedir.
 *
 * https://docs.microsoft.com/tr-tr/dotnet/api/system.collections.arraylist?view=netframework-4.8
 *
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
//ArrayList f = new ArrayList();
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

#region hashTable
/*
 * HashTable bir cox xususiyyetine gore array liste oxsayir,
 * amma arrayList-de index value pair , hashTable-da key value pair-dir.
 * Hashtable-da daxil edilen key-ler unique olmalidir, eger olmazsa xeta verecek.
 *
 */

#region yeni deyer elave edilmesi

//Hashtable h1 = new Hashtable();

//h1.Add("Car","Masin");
//h1.Add("Key","Acar");


#endregion

#region helper methods

#region Contains
/*
 * Arraylistde Contains-le deyere gore yoxlama aparilarken hashtableda
 * key-deyerine gore yoxlama aparilmaqdadir.
 */
//Hashtable h1 = new Hashtable();

//h1.Add("Car", "Masin");
//h1.Add("Key", "Acar");

//bool result = h1.Contains("car");
//bool result = h1.ContainsKey("car");
//bool result = h1.ContainsValue("car");

#endregion

#region Clear collection icersindeki elementleri silir



#endregion

#region CopyTo




#endregion

#region Remove

/*
 * keye uygun gelen deyerin silinmesi
 */
//Hashtable h2 = new Hashtable();

//h2.Remove("Car");
#endregion

#region update

//Hashtable h3 = new Hashtable();
//h3.Add("Old","kohne data");

//h3["Old"] = "Yeni data";
#endregion

#endregion

#region example

#region mini luget hazirlayin.
/*
 * Ingilis-Azerbaycan mini luget hazirlayin.
 *
 * Lugete yeni soz elave etmek isteyirsinizmi? b/x (beli/xeyr)
 *
 * Beli cavabinda yeni soz elave edilir.
 * Istifadeci once Ingilis dilinde sozu daxil edir,
 * Sozun Lugetde olub olmamasi yoxlanilir,
 * Yoxdursa Bu sefer sozun Azerbaycan dilinde qarsiligini daxil edir.
 * Xeyr cavabinda elave edilmis sozlerin hamisi istifadeciye gosterilir.
 *
 */
//Hashtable vocabulary = new Hashtable();

//do
//{
//    Console.Clear();

//    Console.WriteLine("Lugete elave etmek ucun deyeri daxil edin");
//    Console.Write("En:\t");
//    string wordEN = Console.ReadLine();

//    if (vocabulary.Contains(wordEN))
//    {
//        Console.WriteLine("Daxil edilen {0} deyeri lugetde movcuddur {0} qarsiligi {1}, ferqli deyer daxil edin", wordEN, wordEN, vocabulary[wordEN]);

//    }
//    else
//    {
//        Console.WriteLine("{0} deyerinin qarsiligini daxil edin", wordEN);
//        Console.Write("AZ:\t");
//        string wordAZ = Console.ReadLine();
//        vocabulary.Add(wordEN, wordAZ);
//        Console.WriteLine("Elave edildi");


//    }
//    Console.Write("Lugete yeni soz elave etmek isteyirsinizmi? b/x (beli/xeyr):\t");
//    Console.ReadLine();


//} while (Console.ReadLine().ToUpper() != "X");

////1
//foreach (var item in vocabulary.Keys)
//{
//    Console.WriteLine("EN: {0} : AZ: {1}",item, vocabulary[item]);
//}

////2. item.GetType().Name
//foreach (DictionaryEntry item in vocabulary)
//{
//    Console.WriteLine("EN: {0} : AZ: {1}", item.Key, item.Value);
//}

#endregion

#endregion
#endregion

#region sortedList
/*
 * SortedList-de(sl) HasTable kimi key value pair mexanizmi ile isleyir,
 * ferqi sl key deyrlerini a-z ye olacaq sekilde siralayir,
 * bunun ucunde key deyerleri eyni tipde olmalidir,
 * meselen string keyler olan liste int tipinde deyer sahib key yerlesdirsez siralama
 * zamani bize xeta verecek.
 *
 * Kicik olculu isler datalarla isleyerken serferli olsa bele
 * Boyuk datalar uzerinde performasi daha asagidir.
 */
//SortedList sortedList = new SortedList();
//sortedList.Add(100,"Yuz");
//sortedList.Add(40,"fourty");
//sortedList.Add(95,"ninety five");
//sortedList.Add("form","form");

#endregion

#region Stack
/*
 * Stack-de diger oyrendiyimiz collectionlar kimi collection base classlardan biridir.
 * Stack LIFO(Last In First Out) mentiqi ile isleyir.
 * ICollection, IEnumerable, ICloneable interface-lerini implement edir.
 *
 *
 * https://docs.microsoft.com/tr-tr/dotnet/api/system.collections.stack?view=netframework-4.8
 */
// default olaraq capacity 10 teyin edilir.
//Stack myStack = new Stack();

//// ICollection implement eden her hansi sinifden stack collection yaradilir
//myStack = new Stack(new ArrayList());

//// eger capacity yeterli olmazsa 2 qat artirilir.
//myStack = new Stack(10);
//var myStackCount = myStack.Count;

#region methods
#region push(Object)
/*
 * bu method collection-a yeni bir element elave etmeyimize imkan verir.
 */


#endregion
#region pop()
/*
 * bu method collection-a elave edilen en son elementin deyerini bize verir,
 * ve hemin elementi collection-dan xaric edir.
 *
 */


#endregion

#region peek()
/*
 *bu method collection-nin son elementini bize verir ancaq collectiondan silmir.
 */


#endregion

#region clear



#endregion
#region contains



#endregion
#region toArray



#endregion
#region clone



#endregion

#region getEnumerator
//Stack myStack = new Stack();
//myStack.Push(10);
//myStack.Push(20);
//myStack.Push(30);

//IEnumerator enumerator = myStack.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    Console.WriteLine(enumerator.Current);
//}


#endregion
#endregion

#region foreach

//foreach (var item in myStack)
//{
//    Console.WriteLine(item);
//}

#endregion
#endregion
#region Queue
/*
 * Sira/Quyruq - First In First Out
 *
 * https://docs.microsoft.com/tr-tr/dotnet/api/system.collections.queue?view=netframework-4.8
 */
//Queue myQueue = new Queue();

//myQueue = new Queue(10);

#region Dequeue() == stack-deki pop()
/*
 * siranin ilk elementini verir ve onu siradan silir.
 *
 * Eger queue-da element yoxdursa bu methodun istifadesi zamani
 * InvalidOperationException() xetasi alacagiq.
 */


#endregion

#region Enqueue(Object) == stackdeki push()
/*
 * siranin sonuna yeni element elave edir
 */


#endregion

#region Peek()
/*
 * siradaki ilk elementi verir lakin onu siradan silmir
 */


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

//#region C# IEnumerable ve IEnumerator Interface
///*
//* IEnumerable interface-i bir collection base classin elementleri
//* arasinda irelilemek ucun istifade edilir
//*
//* IEnumerator interface-i ise bir collectiondaki her bir elemente
//* catmaq ve uzerinde diger emeliyyatlar aparamaq ucun implement edilmelidir.
//*
//*
//*
//*/

//#region task todo
////   todo Collections: C# IEnumerable ve IEnumerator Interface InTerfaceleri kecende bura qayidacagiq
//class Product
//{
//    public string Name { get; set; }

//}

//class ProductCollection : IEnumerable
//{
//    private Product[] _products;

//    public ProductCollection(Product[] products)
//    {
//        _products = products;
//    }

//    #region Implementation of IEnumerable

//    public IEnumerator GetEnumerator()
//    {
//        throw new NotImplementedException();
//    }

//    #endregion
//}

//class ProductEnumerator : IEnumerator
//{
//    Product[] _products;

//    private int _index = -1;

//    public ProductEnumerator(Product[] products)
//    {
//        _products = products;
//    }

//    #region Implementation of IEnumerator

//    public object Current => this._products[_index];



//    public bool MoveNext()

//    {

//        _index++;

//        return (_index < _products.Length);

//    }

//    public void Reset()

//    {

//        this._index = -1;

//    }

//    #endregion
//}

//#endregion

//#endregion