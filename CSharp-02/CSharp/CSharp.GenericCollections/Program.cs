using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic Collections
            /*
             * 
             *
             * Generic collection-lar(gc)
             * Non-Generic collection-lar(ngc)
             * Generic collection-lar(gc) System.Collections.Generic namespace-si altinda yerlesir.
             * NGC-de type safety yoxdur , elementleri object tipine boxing edirdiler,
             * GC-de ise type safety var ve buna gore de ngc-deki kimi boxing ve ya unboxing emeliyyatlarina
             * ehtiyyac qalmir, bu ozluyunde performans artisi demekdir.
             *
             *
             * *** Genericden once
             *
             * *** Generic collections
             *  GC                      NGC
             * Queue<T>               \ Queue
             * SortedDictionary<K,T>  \ SortedList
             * Stack<T>               \ Stack
             * List<T>                \ ArrayList
             * Dictionary<K,T>        \ Hashtable
             *
             *
             *                                                   |------------ Stack<T>
             *                                 IEnumerable<T> <--|
             *                                       ^           |------------ Stack<T>
             *                                       |
             *                                       |
             *                |------------->ICollection<T><-------------|
             *                |                      ^                   |
             *                |                      |                   |
             *                |                      |                   |
             *          HasSet<T>                    |               LinkedList<T>
             *                                       |
             *                                    IList<T>
             *                                       ^
             *                                       |
             *                              |------------------|
             *                              |                  |
             *                              |                  |
             *                              |                  |
             *                              |                  |
             *                           List<T>             Collection<T>
             *
             *
             * https://www.tutorialsteacher.com/csharp/csharp-collection
             */
            #endregion
            #region Genericden evvel Type Safety c# 1.0

            VirtualDataBase.Add(1);


            #endregion
            #region List<T>
            /*
             * ngc olan ArrayList-in gc olan formasidir.
             */
            List<string> namesList = new List<string>();
            List<string> namesList1 = new()
            {
                "Aleksandr",
                "Nikolay",
                "Patric"
            };
            foreach (var item in namesList1)
            {
                Console.WriteLine(item); 
            }
            namesList1.ForEach(i=>Console.WriteLine(i));

            Console.WriteLine(namesList1[0]);

            // insert
            /*
             * insert vasitesile lazim olan indexe deyer assign ede bilerik lakin bu zaman hemin indexe uygun
             * deyer varsa yeni deyerden sonraya kecir
             */

            /*
             * burada 1-ci indexde artiq saiq deyeri 2. indexde ise Nikolay deyeri olacaq
             */
            namesList1.Insert(1,"Saiq");

            /*
             * Any bool tipi qaytarir
             * Collection icerisinde deyer olub olmamasini ve ya deyer varsa uygun serte gore deyerin olub olmamasini
             * yoxlayir
             */

            List<int> scores = new List<int> {10, 20, 30, 40, 50};

            bool result1 = scores.Any(); // scores icerisinde deyer varmi varsa true qaytarir
            bool result2 = scores.Any(i => i > 20 && i < 50); // uygun serte gore deyer axtarir varsa true
            
            /*
             * yuxaridakilardan elave asagidaki kimi bir sira diger methodlar var bunlara aid  her birine bir numune yazacaqsiz task olaraq.
             * Sort()
             * Remove()
             * RemoveAll()
             * RemoveAt()
             * Max()
             * Min()
             */
            
            #endregion

            #region Dictionary<K,T>
            /*
            * ngc olan Hastable-in gc olan formasidir.
            * Bu collection iki deyer tipi almaqdadir birinci K tipi collectiondaki elementlerin keyleri,
            * ikinci T tipi K tipindeki key-lere uygun deyerlerdir.
            */
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Year", 1990);
            dictionary.Add("Age", 31);
            //dictionary.Add("Name","User1");// xeta

            #endregion
        }
    }

    #region Genericden evvel Type Safety c# 1.0

    public static class VirtualDataBase
    {
        private static readonly ArrayList ArrayList = new ArrayList();

        public static void Add(int data)
        {
            ArrayList.Add(data);
        }
    }


    #endregion
}
