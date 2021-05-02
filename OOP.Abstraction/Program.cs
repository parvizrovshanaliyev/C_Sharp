using System;
using System.ComponentModel.DataAnnotations;

namespace OOP.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OOP.Abstraction
            /*
             * Abstract class sualina cavab olaraq deye bilerik ki, ortaq ozellikleri
             * olan class-larin base class-i olaraq yaradilir.
             * Abstract class-dan instance alinmaz ve bir class-in abstract olaraq
             * teyin etmek ucun abstract keyword-den istifade edilir
             *
             * ****** access modifier
             * Abstract c. private , protected, private internal ile isaretlene bilmezler.
             *
             * ****** sealed keyword
             *
             * Abstract c. sealed keyword-u ile istifade edilmir.
             * sealed ile isarelenmis classdan inheritance alinmaz deye A.c ile uygun gelmir.
             *
             * ****** static
             * Static methodlar teyin edile bilmez
             *
             * ****** method
             *
             * Abstract method sadece abstract c. icerisinde teyin edile biler ve bu methodlar override
             * edilmelidir.
             * Abstract method private olaraq teyin edile bilmez.
             * Abstract methodlarin body-si derived class-da yazilir.
             *
             * ****** abstract vs virtual
             * abstract -da bir nov ozunu virtual kimi aparir aralarindaki ferq virtual-in override edilme
             * mecburiyyeti yoxdur.
             */


            #endregion

            #region examples

            #region 3.log

            LogBase sqlLog = new SqlLog();

            LogBase fileLog = new FileLog();

            // file yazib oxuma emeliyyatlari

            try

            {

                // read file

                Console.WriteLine("*read file");

                fileLog.WriteLog();

                throw new Exception();

            }

            catch (Exception)

            {

                // exception

                fileLog.WriteErrorLog();

            }

            // Sql CRUD emeliyyatlari
            try
            {

                // Sql insert success

                Console.WriteLine("*Sql İnsert success");

                sqlLog.WriteLog();

                throw new Exception();

            }

            catch (Exception)

            {

                sqlLog.WriteErrorLog();

            }

            Console.ReadKey();

            #endregion

            #region MyRegion

            Product p = new();

            #endregion

            #endregion
        }
    }

    #region examples

    #region how to define absctract class

    public abstract class User
    {
    }

    #endregion

    #region method

    public abstract class AirPlane
    {
        public int PassengerCapacity { get; set; }
        public string AirCraftCompany { get; set; }

        // method
        public abstract void Price();
    }

    public class BigAirplane:AirPlane
    {
        #region Overrides of AirPlane

        public override void Price()
        {
            Console.WriteLine("1.000.000");
        }

        #endregion
    }
    public class MidAirplane : AirPlane
    {
        #region Overrides of AirPlane

        public override void Price()
        {
            Console.WriteLine("500.000");
        }

        #endregion
    }
    #endregion

    #region 3.log
    public abstract class LogBase

    {
        public abstract void WriteLog();

        public abstract void WriteErrorLog();

    }

    public class SqlLog : LogBase

    {

        public override void WriteLog()

        {

            Console.WriteLine("SqlLog yazıldı.");

        }

        public override void WriteErrorLog()

        {

            Console.Write("Sql Error Log yazıldı");

        }

    }
    public class FileLog : LogBase

    {

        public override void WriteLog()

        {

            Console.WriteLine("File Log yazıldı.");

        }

        public override void WriteErrorLog()

        {

            Console.WriteLine("File Error Log yazıldı.");

        }

    }
    #endregion


    #region base entity
    public abstract class BaseEntity
    {
        public int Id { get; set; }

    }
    public abstract class AuditableEntity: BaseEntity
    {
        public DateTime CreatedDate { get;}=DateTime.Now;

       public string CreatedBy { get;} = "admin";

       public DateTime UpdatedDate { get;} = DateTime.Now;

        public string UpdatedBy { get;} = "admin";
    }

    public class Product: AuditableEntity
    {
        
    }

    #endregion
    #region 4.
    abstract class EmployeBaseManager
    {

        ///---> Çalışan Bilgilerin Saklanacağı Değişkenler <---\\\
        private string isim, soyisim, unvan;
        private double maas;
        private int yillikizin;
        ///---> Çalışan Kişilerin Bilgilerini Yazdıracağımız Metot Tanımlaması <---\\\
        private string ayrac = new string('-', 20);
        public void getInfo()
        {
            if (yillikizin > 0) ///---> Çalışan oluşturulurken yıllık izin belirtildiği için, çalışan oluşturulmadıysa bilgileri yazdırmayıp uyarı vermesini istiyorum.
                Console.WriteLine("{0}\n<Abstract Company Employe>\n{1}\n-> İsim: {2}\n-> Soyisim: {3}\n-> Ünvan: {4}\n-> Maaş: {5} TL\n-> Yıllık İzin: {6}\n{7}", ayrac, ayrac, isim, soyisim, unvan, maas, yillikizin, ayrac);
            else
                Console.WriteLine("{0}\n<Employe Not Found>\n{1}\n-> Sistem üzerinde getirmek istediğiniz kullanıcıların bilgisine erişemedim.\n{2}", ayrac, ayrac, ayrac);
        }
        public void setInfo(string isim, string soyisim, double maas)
        {
            if (isim.Length >= 3 && soyisim.Length >= 2)
            {
                if (maas > 2500)
                {
                    this.isim = isim;
                    this.soyisim = soyisim;
                    this.maas = maas;
                    if (maas > 3000 && maas < 4000)
                    {
                        this.unvan = "Deneyimli " + unvan;
                        this.yillikizin = 20;
                    }
                    else if (maas > 4000 && maas < 5000)
                    {
                        this.unvan = "Kıdemli " + unvan;
                        this.yillikizin = 24;
                    }
                    else if (maas > 5000)
                    {
                        this.unvan = "Uzman " + unvan;
                        this.yillikizin = 30;
                    }
                    else
                        this.yillikizin = 14;
                }
                else
                    Console.WriteLine("{0}\n<ERROR BRO>\n{1}\n-> Çalışanlara minimum 2500 TL vermeniz gerekmektedir. Çalışan Oluşturulamadı.\n{2}", ayrac, ayrac, ayrac);
            }
            else
                Console.WriteLine("{0}\n<ERROR BRO>\n{1}\n-> Çalışan isim uzunluğu ya da soy isim uzunluğu yeterli uzunlukta gözükmüyor.\n{2}", ayrac, ayrac, ayrac);
        }
        ///---> Maaş Bilgilerine Erişim Sağlayacağım Getter ve Setter Metot Tanımlamalarım <---\\\
        public double getMaas()
        {
            return maas;
        }
        public void setMaas(double maas)
        {
            this.maas = maas;
        }
        public void setUnvan(string unvan)
        {
            this.unvan = unvan;
        }
        ///---> Her Sınıf İçin Özel Zam Seçenekleri Olacağı İçin Abstract Metot Tanımlaması <---\\\
        public abstract void zamYap();
        public abstract void zamYap(double zamOrani);
    }

    class EmployeManager : EmployeBaseManager
    {
        public EmployeManager()
        {
            setUnvan("Beden İşçisi");
        }
        public override void zamYap()
        {
            double maas = getMaas();
            double zam = maas + 50;
            setMaas(zam);
        }
        public override void zamYap(double zamOrani)
        {
            double maas = getMaas();
            double zam = maas + (maas * zamOrani);
            setMaas(zam);
        }
    }

    class EngineerManager : EmployeBaseManager
    {
        public EngineerManager()
        {
            setUnvan("Mühendis");
        }
        public override void zamYap()
        {
            double maas = getMaas();
            double zam = maas + 250;
            setMaas(zam);
        }
        public override void zamYap(double zamOrani)
        {
            double maas = getMaas();
            double zam = maas + (maas * zamOrani) + (maas % 2);
            setMaas(zam);
        }
    }

    class CreateEmployeManager
    {
        public EmployeBaseManager employeBaseManager;
        private string ayrac = new string('-', 20);
        private string isim, soyisim;
        private double maas;
        public void create()
        {
            Console.Write("{0}\n<Create Employe Manager>\n{1}\n-> Çalışanın İsmi: ", ayrac, ayrac);
            isim = Console.ReadLine();
            Console.Write("-> Çalışanın Soyismi: ");
            soyisim = Console.ReadLine();
            Console.Write("-> Çalışanın Maaşı: ");
            maas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ayrac);
            employeBaseManager.setInfo(isim, soyisim, maas);
        }
        public void getInfo()
        {
            employeBaseManager.getInfo();
        }
        public void zamYap()
        {
            employeBaseManager.zamYap();
            Console.WriteLine("{0}\n<Zam Uygulandı>\n{1}\n-> Yeni Maaş: {2} TL\n{3}", ayrac, ayrac, employeBaseManager.getMaas(), ayrac);
        }
        public void zamYap(double zamOrani)
        {
            employeBaseManager.zamYap(zamOrani);
            Console.WriteLine("{0}\n<Zam Uygulandı>\n{1}\n-> Yeni Maaş: {2} TL\n{3}", ayrac, ayrac, employeBaseManager.getMaas(), ayrac);
        }
    }
    #endregion
    #endregion
}
