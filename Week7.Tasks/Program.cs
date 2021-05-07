using System;
using System.Collections;

namespace Week7.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1

            Laptop laptop = new Laptop
            {
                Brand = "Lenovo",
                Model = "thinkPad",
                CPU = "i7",
                PurchasePrice = 1500m,
                SalePrice = 1600m,
                DiscountPrice = 1000m,
                Barcode = "123456"
            };

            Laptop laptop1 = new Laptop
            {
                Brand = "1",
                Model = "1",
                CPU = "i7",
                PurchasePrice = 1500m,
                SalePrice = 1600m,
                DiscountPrice = 1000m,
                Barcode = "123456"
            };

            Database.Add(laptop);
            Database.Update(1,laptop1);
            //Database.Remove(laptop.Id);
            #endregion
        }
    }

    #region task1
    /*
     * Productin database elave edilmesi, silinmesi, redakte edilmesi,butun mehsullarin gosterilmesi.
     * Taski yerine yetirerken kecdiyimiz yeni movzulari
     * ehate etmesine fikir verilmelidir. 2 mehsul tipimiz olacaq biri Tv digeri ise Laptop.
     *
     *
     * Product
     * Id : sistem terefinden genarete olunacaq , set oluna bilmez, 1-den baslayaraq artan olmalidir.
     * Barcode : DataBase-de eyni barcode-a sahip mehsulun olub olmamasi yoxlanmalidir.
     * Purchase price : mehsulun alis qiymeti 0-dan kicik ve ya beraber ola bilmez.
     * Sale price : mehsulun satis qiymeti alis qiymetinden kicik ola bilmez.
     * Discount price : mehsulun endirimli qiymeti 0-dan kicik ve ya beraber ola bilmez.
     * CreateDate : set edile bilmez.
     * Brand
     * Model
     * IsDeleted (bool)
     * DeletedDate : set edile bilmez
     * UpdatedDate : set edile bilmez
     * *Laptop
     * cpu
     * ram
     * videoCard
     *
     * * Tv
     * SmartTv (bool)
     * Inch
     * HDMi (bool)
     *
     * *Database 
     * Add : mehsulun elave edilmesi
     * Remove : mehsulun silinmesi
     * GetAll : IsDeleted statusu false olanlarin siyahisinin gosterilmesi 
     * Update : Mehsulun Brand,Model,Discount price,Sale price,Purchase price, Barcode xususiyyetleri redakte edilecek.
     *
     *
     */

    #region entities

    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            _id = counter;
            counter += 1;
        }
        public static int counter = 1;
        /// <summary>
        /// id colden daxil edilmeyecek , set edilmeyecek
        /// </summary>
        ///
        private int _id;

        public int Id
        {
            get => _id;
            private set
            {
            }
        }
        /// <summary>
        /// Daxil edilen barkodun db-da  olub olmamasi yoxlanilmalidir .
        /// </summary>
        private string _barcode;

        public string Barcode 
        {
            get => _barcode;
            set
            {
                bool existBarcode = Database.ExistBarcode(value);
                if (existBarcode)
                {
                    Console.WriteLine("bu barcode artiq istifade edilib");
                }
                else
                {
                    _barcode = value;
                }
                
            }
        }


        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }


    }

    public class Product : BaseEntity
    {
        /// <summary>
        /// Brand/Markalar yoxlanacaq buna uygun productlar yaradilacaq
        /// </summary>
        public string Brand { get; set; }
        public string Model { get; set; }

        /// <summary>
        /// 0-dan kicik olmamalidir
        /// </summary>
        private decimal _purchasePrice;

        public decimal PurchasePrice
        {
            get => _purchasePrice;
            set
            {
                if (value <= 0)
                    Console.WriteLine("alis qiymeti 0-dan kicik ve ya beraber ola bilmez...");

                else
                    _purchasePrice = value;
            }
        }

        /// <summary>
        /// satis qiymeti alis qiymetinden ucuz ola bilmez
        /// </summary>
        private decimal _salePrice;

        public decimal SalePrice
        {
            get => _salePrice;
            set
            {
                if (value < _purchasePrice)
                    Console.WriteLine("Satis qiymeti alis qiymetinden kicik ola bilmez...");
                else
                    _salePrice = value;
            }
        }
        /// <summary>
        /// kampaniya satis qiymeti endirim ile
        /// 0-dan kicik ola bilmez
        /// </summary>
        private decimal _discountPrice;

        public decimal DiscountPrice
        {
            get => _discountPrice;
            set
            {
                if (value <= 0)
                    Console.WriteLine("endrim qiymeti 0-dan kicik ve ya beraber ola bilmez...");

                else
                    _discountPrice = value;
            }
        }
    }

    public class Tv : Product
    {
        /// <summary>
        /// bool
        /// </summary>
        public bool SmartTv { get; set; }
        /// <summary>
        /// bool
        /// </summary>
        public bool HDMI { get; set; }
        /// <summary>
        /// string
        /// </summary>
        public string INCH { get; set; }
    }

    public class Laptop : Product
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string VideoCard { get; set; }
    }

    #endregion

    public static class Database
    {
        private static readonly ArrayList Db = new ArrayList();

        
        public static void Add(BaseEntity data)
        {
            if (data != null && !string.IsNullOrEmpty(data.Barcode))
            {
                Db.Add(data);
            }
        }
        public static void Remove(int id)
        {
            if (Db != null && Db.Count > 0)
            {

                foreach (var item in Db)
                {
                    BaseEntity entity = (BaseEntity)item;
                    if (entity != null&& entity.Id== id)
                    {
                        Db.Remove(entity);
                    }

                }
            }
           
        }

        public static void Update(int id,Product data)
        {
            if (Db != null && Db.Count > 0)
            {
                if (data != null && !string.IsNullOrEmpty(data.Barcode))
                {
                    foreach (var item in Db)
                    {
                        Product entity = (Product)item;
                        if (entity != null && entity.Id == id)
                        {
                            entity.Brand = data.Brand;
                            entity.Model = data.Model;
                        }

                    }
                }
                
            }

        }
        public static bool ExistBarcode(string barcode)
        {
            bool control = false;
            if (Db != null && Db.Count > 0)
            {
                foreach (var item in Db)
                {
                    BaseEntity baseEntity = (BaseEntity) item;

                    if (baseEntity != null && baseEntity.Barcode == barcode)
                    {
                        control = true;
                    }
                }
            }

            return control;
        }
    }
    #endregion
}
