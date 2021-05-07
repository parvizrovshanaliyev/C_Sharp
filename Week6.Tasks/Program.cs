﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using static Week6.Tasks.Product;

namespace Week6.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tasks

            #region rectangle
            /*
             * Console-dan daxil edilen en ve uzunluga gore duzbucaqlinin sahesinin hesablanmasi.
             * class member-ler ve encapsulation movuzlarina uygun isleyin.
             * Qeyd: daxil edilenlerden her hansisa birinin menfi olub olmamasini yoxlayin.
             * menfidirse deyeri 0 beraber edin.
             */
            #endregion

            #region teacher class
            /*
             *  Muellim modeli yaradin, id, adi,soyadi,vezifesi,dogum tarixi, ise baslama tarixi, islediyi yer
             *  datalarini saxlasin.
             *  Id: sadece oxuna biler auto yaradilacaq.
             *  Vezife: daxil edilmeyibse null-dursa Teacher deye set edilsin.
             *  Ise Baslama tarixi : Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.
             */
            #endregion

            #region gelende eve corey al
            /*
             *  Online alis veris :
             *  * Console ekaraninda musterini ilk once  menu qarsilamalidir,
             *  mehsullari menudan sececek( qiymetleri de olmalidir) sonra hansindan ne qeder istediyini qeyd edecek
             *  bildiklerinizi tetbiq ederek asagidaki numune cekin hazilanmasi
             *  lazimdir. Mehsul adlari onlarin qiymetleri edv olub olmamasi mehsulda endirim olub olmamasi
             *  siz terefden serbest teyin olunacaq.(burada gosterilenler hayel urunudur hic biri gercegi yansitmamaktadir).
             *
             *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam|
             *  | Un                | 5 kq     |  1       |0 %  |5     |
             *   Sizin qazanciniz=================== 0,495             |
             *  | quzu eti          | 3,5 kq   |  12      |18 % |42    |
             *   Sizin qazanciniz=================== 0,90              |
             *  | cay               | 2   eded |  1,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | alma qirmizi      | 2   kq   |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | alma sari         | 2   kq   |  2       |18 % |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | goyerti           | 2   eded |  0,15    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | makaron           | 2   eded |  2       |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | baliq konservasi  | 2   eded |  3,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | lavas             | 1   eded |  1,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | corek             | 2   eded |  0,50    |18 % |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | pomidor           | 2   kq   |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | xiyar             | 2   kq   |  2       |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | toyuq             | 2   eded |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90
             * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
             * Endirim                                          | 2,48 |
             * vergi edv                                        | 5,02 |
             * yekun mebleg                                     | 54,50|
             * odenis novu: kartla odenib                        
             * tarix 20:04:21
             * qebz nomresi : 12
             *
             * Musterinin hesabinda umumi 450 azn pul var,
             * elave olaraq musteri bravo endirim kartina sahib oldugu ucun her alis verishinde
             * umumi meblegin 2% qeder endirim elde edir. Musteri odenisi kartla ederse 0,18 elave deyer vergisinin
             * 10 % qederini , negd pulla ederse 15 % qederini yeniden musterinin hesabina kocurulur.
             *
             * sizin qazanciniz :
             * | Un                | 5 kq     |  1       |0 %  | 5
             *  Sizin qazanciniz=================== 0,495 ( 5 % endirim olub bu mehsulda digerlerinde de bu sekilde endrim olarsa hesablanmalidir.)
             *  0,495 qaliqlarda yuvarlasdirmada edersiz 
             * EDV :
             *  asagida gosterildiyi kimi bezi mehsullarda 0% bezilerinde 18% edv olmalidir.
             *  Sonda elave deyer vergisi-de hansi mehsullarda varsa toplanib yekun meblegin
             *  uzerine gelmelidir. Musteri odenisi kart-la  edibse 10% negd yolla odenis edibse
             *  15 % umumi edv-den musterinin hesabina pul qayidacaq.
             *
             *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam
             *  | Un                | 5 kq     |  1       |0 %  |5
             *   Sizin qazanciniz=================== 0,495
             *  | quzu eti          | 3,5 kq   |  12      |18 % |42
             *
             *
             *  alis veris 15 azn den azdirsa catdirilma ucun 4,50 azn teleb olunacaq.
             */


            #endregion

            #endregion

            //Console.Clear();
            //Console.WriteLine("xos gelmisiniz");
            //do
            //{
            //    var products = new ArrayList
            //    {
            //        new Product{Name = "Alma", Discount = 5, HaveVAT = true,Price = 2 },
            //        new Product{Name = "Cay", Discount = 0, HaveVAT = true,Price = 1.50 }
            //    };
            //    // menu
            //    Shop.PrintMenu(products);

            //    Console.Write("Menuya geri don? b/x (beli/xeyr):\t");


            //} while (Console.ReadLine().ToUpper() != "X");

            //_products.AddRange(new ArrayList
            //{
            //    new Product {Name = "Alma", Discount = 5, HaveVAT = true, Price = 2},
            //    new Product{Name = "Cay", Discount = 0, HaveVAT = true,Price = 1.50 }
            //});

            var products = new ArrayList
            {
                new Product {Name = "Alma", Discount = 5, HaveVAT = true, Price = 2},
                new Product{Name = "Cay", Discount = 0, HaveVAT = true,Price = 1.50 }
            };
            // menu
            Product.PrintProductList(products);

            var productId = Convert.ToInt32(Console.ReadLine());
            var quantity = Convert.ToInt32(Console.ReadLine());

            foreach (var item in products)
            {
                var product = (Product)item;

                if (product.Id == productId)
                {
                    product.Quantity = quantity;
                    product.CalcTotalPrice();

                    Console.WriteLine($"Adi:{product.Name}  Sayi:{product.Quantity} Qiymeti:{product.Price}");
                }
            }

            #region MyRegion

            //foreach (var item in products)
            //{
            //    var product1 = (Product) item;
            //    product1.CalcTotalPrice();
            //}
            //Product product = new Product
            //{
            //    Name = "X",
            //    Discount = 5,
            //    HaveVAT = true,
            //    Price = 100
            //};
            ////product.CalcTotalPrice();
            //Console.WriteLine($"Discount:{product.Discount}");
            //Console.WriteLine($"Gain:{product.Gain}");
            //Console.WriteLine($"VAT:{product.VAT}");
            //Console.WriteLine($"Price:{product.Price}");

            #endregion
        }

    }


    public class Product
    {
        #region dataBase

        //public static ArrayList _products;

        #endregion
        public Product()
        {
            Id = GenerateId();
        }

        //static Product()
        //{
        //    _products = new ArrayList(); // bir defe ilk instance alinan zaman yaranacaq;
        //}

        #region fields and props

        private static int _id = 0;
        private const double _vat = 18;
        public int Id { get; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double Gain { get; private set; }
        public string VAT => HaveVAT ? $"{_vat} %" : "0 %";
        public bool HaveVAT { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; } = 0;
        public bool QuantityOrWeight  { get; set; }

        #endregion

        #region methods
        public void CalcTotalPrice()
        {
            double price = this.Price * this.Quantity;

            if (price > 0 && HaveVAT)
            {
                price += (price * _vat) / 100;
            }
            Gain = (price * Discount) / 100;
            price -= Gain;

            Price = price;
        }


        //static int GenerateId()
        //{
        //    return _id++;
        //}


        static int GenerateId()
        {
            /*
             * https://docs.microsoft.com/en-us/dotnet/api/system.threading.interlocked.increment?redirectedfrom=MSDN&view=net-5.0#System_Threading_Interlocked_Increment_System_Int32__
             */
            return Interlocked.Increment(ref _id);
        }

        public static void PrintProductList(ArrayList products)
        {
            foreach (var item in products)
            {
                var product = (Product)item;

                Console.WriteLine($"Mehsul :{product.Name} Qiymet :{product.Price}");
            }
        }

        #endregion
    }
    public static class Shop
    {
    }
    //class ShoppingCart
    //{
    //    private List<GroceryItem> orders;

    //    public List<GroceryItem> Orders
    //    {
    //        get
    //        {
    //            return orders;
    //        }
    //        set
    //        {
    //            orders = value;
    //        }
    //    }

    //    public double Calculate()
    //    {
    //        double price = 0;
    //        if (this.Orders != null)
    //        {

    //            foreach (GroceryItem order in this.Orders)
    //            {
    //                price += order.Calculate();
    //            }

    //        }
    //        return price;

    //    }
    //}


}
