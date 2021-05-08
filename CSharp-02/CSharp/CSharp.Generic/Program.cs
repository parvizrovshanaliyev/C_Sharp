using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic
            /*
             * Umumilikde Genericler bize tek bir tip ile deyil ferqli tiplerle islemeyimize
             * ve daha az kod yazaraq islerimizi hell etmeye imkan yaradir.
             *
             * Generic sekilde teyin etdiyimiz interface , class, metod ve ya parametrler
             * bir tip ucun deyil proyekde olan diger tiplerle de islemeyimize imkan yaradan
             * bir sablon hazirlamagimiza imkan yaradir ve bununlada Generic serviceler,
             * repositoryler yaradaraq tekrarlanan emeliyyatlarimizi bir yerden idare ede bilirik.
             *
             *
             * Generic -ler >.Net 2.0 ile birlikde istifadeye verilmisdir.
             *
             ******** Avantajlar
             * *Tekrarlanan kod bloklarinin tekrar yazmagin qarshisini alir.
             * *Daha yaxsi idare oluna bilen ve keyfiyyetli kod yazmagimiza imkan verir
             * *RunTime da lazimsiz Cast Boxing-UnBoxing emeliyyatlarina ehtiyyac qalmir
             * bunun ucun daha effektivdir.
             *
             *
             * **** Generic ve CLR desteyi
             * Generic-ler dil seviyyesinde bir ozellik deyil, .Net CLR
             * genericleri avtomatik sekilde taniyir. Yaradilan Generic
             * class, method ve ya parametr sadece bir defe yaradilir ve generic
             * struktura oturulen her tip ucun CLR arxa planda gedib ilk yaradilan
             * generic strukturu ve daxilindeki emeliyyatlari istifade edir.
             *
             *
             * *** Generic Class
             * *** Generic Methods
             * *** Generic Type Parameters
             * *** Generic Interface
             * *** Generic Constraint
             */
            #endregion

            #region examples

            #region non generic class

            Customer customer = new Customer
            {
                Id = 1,
                Name = "Customer1",
                Surname = "Customer1"
            };

            #endregion

            #region Generic class
            // 
            CustomerGeneric<int> customerGeneric = new CustomerGeneric<int>
            {
                Id = 1,
                Name = "Customer1",
                Surname = "Customer1",
                CustomerNo = 1
            };

            CustomerGeneric<Guid> customerGeneric1 = new CustomerGeneric<Guid> {Id = Guid.NewGuid()};

            #endregion

            #region Generic class real case

            GenericRepository<CustomerGenericRealCase> customerRepository =
                new GenericRepository<CustomerGenericRealCase>();

            List<CustomerGenericRealCase> customers = customerRepository.GetAll();
            // product
            GenericRepository<Product> productRepository =
                new GenericRepository<Product>();
            #endregion

            #region CLR desteyi
            MyList<int> myIntList = new MyList<int>();
            MyList<int> myIntList2 = new MyList<int>();

            MyList<double> myDoubleList = new MyList<double>();

            MyList<SampleClass> mySampleList = new MyList<SampleClass>();

            Console.WriteLine(myIntList.Count);
            Console.WriteLine(myIntList2.Count);
            Console.WriteLine(myDoubleList.Count);
            Console.WriteLine(mySampleList.Count);
            Console.WriteLine(new MyList<SampleClass>().Count);

            Console.ReadLine();
            #endregion
            #endregion
        }
    }

    #region examples

    #region Non-Generic class

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }


    #endregion
    #region Generic class
    public class CustomerGeneric<T>
    {
        public T Id { get; set; }
        public T CustomerNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        #region method

        public T GetCustomerNo()
        {
            return CustomerNo;
        }
        #endregion
    }
    #endregion
    #region Generic class real case
    /*
     * Database | MSSQl
     * Application | Console C#
     *
     * tblCustomer
     * id int
     * customerNo uniqueIdentify (C# GUID)
     * name nvarchar(50) string
     * surname nvarchar(50) string
     * birthdate Datetime
     *
     *
     * UnitOfWorks => Generic Class | Generic Interface
     *
     *
     */

    public class CustomerGenericRealCase
    {
        public int Id { get; set; }
        public Guid CustomerNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GenericRepository<T>
    {
        private readonly List<T> dataList;
        #region ctor

        public GenericRepository()
        {
            /*
             * Database ile elaqe qurulacaq
             */
            // context : EF DBFirst
            dataList = new List<T>();
        }

        #endregion


        #region methods

        public virtual List<T> GetAll()
        {
            // Gelen T tipini database uzerinden cekib elde etmis oldugu
            // datani Generic Collection olaraq ustdeki layere oturmek
            return dataList;
        }

        public virtual void Add(T data)
        {
            /*
             * Gelen T tipine uygun databasedeki cedvele insert isi gorulur.
             */
            if (data != null)
            {
                dataList.Add(data);
            }
        }
        #endregion


    }
    #endregion

    #region CLR desteyi
    public class MyList<T>
    {
        private static int objCount = 0;

        public MyList()
        {
            objCount++;
        }

        public int Count => objCount;
    }
    class SampleClass { }

    #endregion
    #endregion
}
