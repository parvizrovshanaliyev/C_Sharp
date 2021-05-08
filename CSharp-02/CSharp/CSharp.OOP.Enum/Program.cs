using System;
using System.Collections;
using System.Globalization;

namespace CSharp.OOP.Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OOP.Enum
            /*
             * OOP aspektinden baxarken umumilikde yazilan kodlarin setirbesetir uygun ieararxik
             * struktura sahib olgunu gore bilerik , bes bu bize ne qazandirir? daha sade emelliyyatlari
             * eslinde daha sade kod bloklari ile hell ede bilerikmi ? eslinde ede bilerik amma bunun bize
             * avantajdan cox dezavantaj olaraq geri doneceyinide unutmamaliyiq, sebeb yazilan kodlar her zaman
             * inkisaf etdirilmelidir ve bu da ozunde monolit tipli proyektlerin artiq sirketlerde qebul gormus
             * daha cox boyumeye elverisli n layer proyektlere cevrilmesi ile musahide edilir, bu zaman yazilan kodlarin
             * mueyyen prinsiplere esaslanmasi, onceden teyin edilen qaydalarin olmasi butum komonda ucun development
             * prosesini daha suretli ve duzgun qaydada ireliletmeye imkan verir.
             * Meselen evvelceden teyin edilen xeta mesajlarini fikirlesin eger ki bunlar onceden teyin edilmezse
             * proyekt uzerinde isleyen her developer ferqli desti xette malik oldugundan xeta mesajlarini, hetta ugurlu
             * yerine yetirilen emeliyyatlarin neticelerini ferqli yaza biler demekdir. Bunun olmamasi ucun zehmetlide olsa
             * bu problem yaradacaq hisseler evvelceden teyin edilmekdedir. Enum-larinda bu meselede onemli avantajlari vardir.
             *
             *
             * Enumerations kod icerisinde number deyerler ile qarsilastirma aparilan zaman , gelen deyere uygun
             * emeliyyatlari yonlendiren , daha oxunaqli kod yazilmasini temin eden struktura malikdirler.
             *
             * Enum elementlerine baslagic deyer verilmezse 0-dan baslayaraq diger elementleride nomreleyir ve
             * elementin deyeri buna uygun oxuna bilir.
             *
             * Enum-larin default deyer tipi INT-dir, inheritance ile ferqli tiplerlede islemek mumkundur.
             * byte,sbyte, short,ushort, int, uint,long, ulong
             *
             * Deyisenlerin adlandirma qaydasinda oldugu kimi enum icerisindeki elementlerin adlandirmasinda
             * da hemcinin baslangicde reqem ve ya bosluq istifade edile bilmez.
             *
             *
             */
            #endregion

            #region example

            #region 1.

            Product product = new Product
            {
                Id = 1,
                Name = "alma",

            };

            var result=VirtualDatabase.Add(product);

            Console.WriteLine(result == CrudResult.Success ? "elave edilmedi" : "xeta bas verdi");

            #endregion

            #region selectedDay

            Days selectedDay = Days.Saturday;
           
            #region conditional case
            if (selectedDay == Days.Saturday || selectedDay == Days.Sunday)
            {
                Console.WriteLine("Hefte sonu");
            }
            else
            {
                Console.WriteLine("Hefte ici");
            }
            #endregion

            string[] days = System.Enum.GetNames(typeof(Days));

            Console.WriteLine(days[0].ToString());

            #endregion

            #region exam Score

            int studentExamScore = 70;
            // casting
            ExamResult examResult = (ExamResult) studentExamScore;
            Console.WriteLine(examResult.ToString());

            //switch (examResult)
            //{
            //    case ExamResult.Fail:
            //        break;
            //    case ExamResult.MinValue:
            //        break;
            //    case ExamResult.MidValue:
            //        break;
            //    case ExamResult.GoodValue:
            //        break;
            //    case ExamResult.Perfect:
            //        break;
            //    case ExamResult.MaxValue:
            //        break;
            //    default:
            //        Console.WriteLine("bextinizi bir daha sinayin");
            //        break;
            //}
            #endregion
            #region user userType
            #region WithoutEnum

            UserWithoutEnum user1 = new()
            {
                Id = 1,
                Name = "User1",
                Type = 1 // yeni admin
            };
            
            UserWithoutEnum user2 = new()
            {
                Id = 1,
                Name = "User2",
                Type = 2 // yeni standart user
            };

            if (user1.Type == 1)
            {
                Console.WriteLine("admin");
            }else if (user1.Type == 2)
            {
                Console.WriteLine("standart user");
            }
            #endregion

            #region with enum

            UserWithoutEnum user3 = new()
            {
                Id = 1,
                Name = "User1",
                //Type = (byte) UserType.Admin //1 // yeni admin
                Type = 1 // yeni admin
            };
            UserWithoutEnum user4 = new()
            {
                Id = 1,
                Name = "User2",
                Type = 2 // yeni standart user
            };

            if (user3.Type == (byte) UserType.Admin)
            {
                Console.WriteLine("admin");
            }
            else if (user3.Type ==(byte) UserType.User)
            {
                Console.WriteLine("standart user");
            }

            #endregion
            #endregion

            #endregion
        }
}

    #region examples

    #region 1.

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public static class VirtualDatabase
    {
        private static readonly ArrayList Databese = new ArrayList();

        public static CrudResult Add(Product product)
        {
            return CrudResult.Success;
        }
    }

    #endregion

    #region selected Day
    /// <summary>
    /// enum elementlerine baslagic deyer verilmezse 0-dan baslayaraq diger elementleride nomreleyir ve
    /// elementin deyeri buna uygun oxuna bilir.
    /// </summary>
    public enum Days
    {
        Monday,
        Thursday,
        Wednesday,
        Tuesday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion

    #region exam Score

    public enum ExamResult
    {
        Fail=0,
        MinValue=45,
        MidValue=60,
        GoodValue=70,
        Perfect=80,
        MaxValue=100
    }
    #endregion

    #region user UserType

    #region WithoutEnum

    public class UserWithoutEnum
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte Type { get; set; } // user tip 1 admin 2 standart user
    }

    #endregion
    #region with enum
    public class UserWitEnum
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte Type { get; set; } // user tip 1 admin 2 standart user
    }
    /// <summary>
    /// eger ki entity icerisinde mueyyen bir ozelliyi enum-la teyin etmisizse
    /// enum-in oz tipinin default olaraq int oldugunu bilmelisiz int le deyil byte-la islemek isteyirsizse
    /// c# -da olan byte-in sql-deki tip qarsiligina baxmalisiz c# byte => sql tinyint
    /// System.InvalidOperationException :
    /// The ‘State’ property on ‘Issue’ could not be set to a ‘System.Byte’ value.
    /// You must set this property to a non-null value of type ‘IssueState’.
    /// </summary>
    public enum UserType : byte
    {
        Admin = 1,
        User
    }

    #endregion


    #endregion

    #endregion
}
