using System;
using System.Data;
using OOP.CTOR;

//using static OOP.NestedTypeClass;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region class

            #region field
            //MyClass myClass = new MyClass();
            //var myClassNumber = myClass.number;
            #endregion

            #region indexer

            //MyClassIndexer myClassIndexer = new MyClassIndexer();

            //myClassIndexer[0] = 5;

            #endregion

            #region nested type

            //NestedTypeClass.InnerClass innerClass1 = new NestedTypeClass.InnerClass();
            //InnerClass innerClass2 = new InnerClass();
            #endregion

            #region summary

            //SummaryClass summary = new SummaryClass();

            #endregion

            #endregion
            #region shallow copy deep copy
            /*
             * Shallow copy
             */
            //ShallowCopyClass shallowCopy1 = new ShallowCopyClass();
            //ShallowCopyClass shallowCopy2 = shallowCopy1;
            //ShallowCopyClass shallowCopy3 = new();


            #endregion
            #region special class memeber
            #region ctor

            //Credit credit = new Credit(4, 600, 0.3);

            //credit.Calc();

            #endregion

            #region destructor

            //CreateMyClass();
            //GC.Collect();
            //Console.ReadLine();

            //void CreateMyClass()
            //{
            //    MyClass myClass = new MyClass();
            //}

            #endregion

            #region deconstruct method

            //City city = new City
            //{
            //    Name = "Baku",
            //    Population = 100_000_000
            //};

            //var (x, y) = city;
            //Console.WriteLine(x,y);

            #endregion

            #endregion
            
            #region Records

            #region Init Only Properties



            #endregion

            #endregion

            #region examples

            #region car
            /*
             *  masinin hazirda benzin deposunda neqeder benzin var ,  depoda olan benzinle nece km yol qet
             * ede biler , yanacaq serfiyyati
             *
             * km / litr serfiyyat benzin  = 1 litr ile gedile bilecek yol 100 / 6 = 16,6
             */
            Car vaz07 = new Car(50, 8);

            Console.WriteLine(vaz07.CurrentFuel);
            Console.WriteLine(vaz07.MaxDistance);
            Console.WriteLine();
            #endregion


            #endregion
        }
    }

    #region OOP
    /*
     * Object Oriented Programming
     *
     * OOP nedir ? bu yanasmaya niye ehtiyyac var ?
     *
     * Umumiyyetle hazirda OOP yanasmasi  bir cox diller terefinden desteklenir.
     * Kecmise nezeren bu yanasmadan sonra programlasdirma daha sistematik daha suretli
     * veziyyete geldi.
     * Development zamani bu yanasmanin ozeyi real heyatdaki her seyi her hansisa obyektin
     * simulasyonu olaraq gorub yanasmaqdir. Yanasmaya gore her seyin ozeyinde object dayanir.
     * Obyektleri ise class vasitesi ile modelleye bilirik , bununlada obyekt anlasila bilen, mena kesb eden
     * bir hala gelir.
     *
     * Object Reference type-dir.
     *
     * Developer olaraq Stack bolge bizim ucun elcatan olsada HEAP ele deyil adindan da melum oldugu kimi reference etmek
     * mefhumu buradan gelmektedir,
     *
     * https://www.w3schools.com/cs/cs_oop.asp
     */


    #endregion

    #region class
    /*
     * Programlasdirmada class mefhumu bir obyektin modelidir.
     * Class reference type-dir.
     *
     * class yaradilan zaman class__name_() syntax-dan istifade edirik.
     * Class namespace icerisinde , namespace-den kenarda ve
     * class icerisinde(Nested Type) yaradila biler.
     *
     * namespace icerisinde : olan zaman eyni namespacede olan classlarin bir birine bir basa
     * accessi olur.
     *
     * namespace-den kenarda : olan zaman ise ferqli namespace uzerinden connection qururlar.
     *
     * Birden cox eyni adli class yaradila bilmez.
     * class icerisinde yaradilan varaible(deyisen) field adlanir.
     *
     *
     */

    #region class members

    /*
     * field
     * property (encapsulation)
     * method
     * indexer
     */

    #region field
    /*
     * Field Obyekt icerisinde uygun tipe gore data saxlayir.
     * Oyrendiyimiz varaible anlayisi class scope-da teyin olunan zaman
     * field adlanir.
     * Field type gore default deyer alir. Sadece field-da default deyer assign edilir.
     *
     *
     */

    //class MyClass
    //{
    //    public int number;
    //}
    #endregion

    #region property
    /*
     * Obyekte ozellikler qazandirir. Ozeyinde property method-dur.
     * Property-nin method-dan ferqi parametr almamasi ve icinde get,set
     * bloklarinin olmasidir. Method () teyin edilerken propertyde yoxdur.
     *
     * Property ile obyektimizin field-lerine access elde edirik bir basa field-e
     * deyil property uzerinden access elde edirik.
     * Bu danisdigimiz yanasma diger dillerde method vasitesile ,
     * C# da property vasitesile temsil edilir ki, bu yanasmada
     * Encapsulation anlayisidir.
     *
     * Property-nin set blokunu silsen sadece deyerini oxuya bilersen readonly.
     * Property-nin get blokunu silsen sadece onu deyerini set ede bilersen.
     *
     */
    //public void Print() {
    //Console.Write("Hello world")
    //}

    //public int MyProperty { get; set; }
    //public int MyProperty {
    //        get // deyer oxunan zaman  get
    //        {
    //            return 0;
    //        }; set // deyer set edilen zaman bu blok ise dusur
    //        {

    //        };
    //}
    //class MyClassProps
    //{
    //    //private int _number;

    //    //********** Full Property
    //    //public/*access modifier*/ int /*geriye donus tipi*/ Number
    //    //{
    //    //    get
    //    //    {
    //    //        return _number;
    //    //    }
    //    //    //get => number;
    //    //    set
    //    //    {
    //    //        _number = value; // buradaki value property hansi tipdedirse o tipe burunur.
    //    //    }
    //    //    //set => number = value;
    //    //}

    //    //********** Prop
    //    // field teyin etemeye ehtiyyac yoxdur
    //    // compiler terefinden arxa terefde field teyin edilir.
    //    // . readonly ola biler, writeonly ola bilmez
    //    //public int MyProperty { get; set; }

    //    /*
    //     * ***********Auto Property Initializers (C# 6.0)
    //     * bu ozellikle readonly prop-lara suretli sekilde deyer assign ede bilirik.
    //     * Obyektimizin property-sine ilk deyerini vere bilirik
    //     */
    //    //public double Percent { get; set; } = 0.18;
    //    //public byte Age { get; set; } = 40;
    //    //public string Name { get; set; } = "Samir";
    //    //public DateTime CreatedDate { get; set; }=DateTime.Now;


    //    /*
    //     * ************ C# 7.2 Ref ReadOnly Returns
    //     *
    //     * Normal bir class-da onun her hansisa property-sine catmaq ucun
    //     * her defe o class-dan yeni bir instance almagimiz lazim gelir,
    //     * bu davranis ram-da her defe onun fieldlarinin ve propertylerinin de
    //     * tekrar tekrar yaranmasina sebebiyyet vermektedir, lakin bizim elimizde
    //     * onceden baslangic deyeri verilmis bir property varsa eyni deyerin
    //     * RAM-da tekrar tekrar teyin edilmesindense birdefe teyin edilib diger instance
    //     * -larin hemin  deyere reference etmesini isteyirik.
    //     * Bu movzunun static anlayisini kecdikden sonra daha da aydin olacagini dusunurem.
    //     * Umumi optimizasya isleri zamani istifade edilir, sadece qarsilasdiginiz zaman
    //     * bunun da property oldugunu bilin.
    //     */
    //    // normal teyin edilme
    //    //public string Name { get; set; } = "Parviz";
    //    // Ref ReadOnly Returns
    //    //private string _name = "Parviz";
    //    //public ref readonly string Name => ref _name;

    //    /*
    //     * Computed Properties
    //     *
    //     * propertu icerisinde her hansisa riyaz isler gorulur.
    //     */
    //    //private int _a = 5;
    //    //private int _b = 8;
    //    //public int Sum
    //    //{
    //    //    get
    //    //    {
    //    //        return _a +_b;
    //    //    }
    //    //}

    //    /*
    //     * Expression-Bodied Property
    //     *
    //     * property-de lambda expression istifade ede bilmeyimizi temin edir.
    //     * sadece redonly-lerde istifade edilir.
    //     * lambda expression dersi irelide kecilecek.
    //     */
    //    //private int _a = 5;
    //    //private int _b = 8;
    //    //public int Sum => _a + _b;

    //    /*
    //     * Init-Only Properties-Init Accessor C# 9.0
    //     *
    //     * Obyektin ilk yaradildigi anda property-lerine deyer atamaqdadir.
    //     * RunTime zamani deyeri deyisdirilmemeli olan obyetler ucun qabaqlayici
    //     * tedbirdir deye bilerik.
    //     * Object initializers dersinde etrafli kececeyik.
    //     */
    //}
    #endregion

    #region method
    /*
     * Evvelki derslerden method-haqqinda tanisligimiz var.
     * Class memeber-lerden olan method esas isimizi gorduyumuz kod yazdigimiz hissedir.
     *
     */
    #endregion

    #region indexer
    /*
     * Obyekte indexer xususiyyeti qazandirir, evvelki derslerde oyrendiyimiz indexer operatoru vasitesile
     * obyektin instancedan sonra uygun indexe gore class daxilindeki array veya collectiondan get ve ya set isi gore bilirik.
     * ozunde property-e cox oxsardir(
     * her hansisa type-la isleyeceyin ucun property-de nece geri donus deyerini bildirirdikse,
     * buradada eyni veziyyet olacaq).
     *
     * syntax : access modifier __ type(geri donus deyeri) _ this(keyword) [parameters]
     */

    //class MyClassIndexer
    //{
    //    int[] _numbers = new int[5];

    //    public int this[int index]

    //    {

    //        get

    //        {

    //            return _numbers[index];

    //        }

    //        set

    //        {

    //            _numbers[index] = value;

    //        }

    //    }
    //}
    #endregion
    #endregion

    #region nested type
    /*
     * Class basqa bir class icerisindede teyin edile biler ancaq
     * class member sayilmir.
     * Class memeber olmadigindan dolayi InnerClass-a icerisinde oldugu
     * class-in instance-ni alaraq memberlerde oldugu kimi cata bilmerik.
     */
    //public class NestedTypeClass
    //{
    //    public class InnerClass
    //    {


    //    }
    //}

    #endregion

    #region summary 
    /*
     * Classlarimiza ve onun memberlerine description elave ede bilerik.
     * hansiki hazir istifade etdiyimiz class-larda bu descriptionlar movcuddur.
     */
    /// <summary>
    /// Summary Class-i classlara nece aciqlama yaza bileceyimizi gostermek ucun yaradilib.
    /// </summary>
    //class SummaryClass
    //{
    //    /// <summary>
    //    /// Ad saxlamaq ucun istifade edilecek.
    //    /// </summary>
    //    public string Name { get; set; }
    //}

    #endregion

    #region this keyword

    /*
     * This keywordu class memberlerin icerisinde cagrila biler.
     * Class-a aid obyekti temsil edir.
     * Static Classlarda, memberlerde this istifade edilmez.
     */
    //class MyClass
    //{
    //    private int _a = 5;
    //    public void Sum() // method
    //    {
    //        this.Sum();
    //    }
    //}

    //static class MyClass2
    //{
    //    public static void Sum() // method
    //    {
    //        //this.Sum();
    //    }
    //}

    /*
     * class memeber olan field-le method parametri eyni adli olarsa,
     * bu zaman this-le birbasa membere muraciet ede bilerik.
     *
     * this keywordunun qarsiligi o anki yaradilan obyekt-dir, bunun ucunde
     * this-le onun memberlerine ozu kimi cata bilirik lakin this yazmasaqda
     * cata bilerik eslinde bu  arxa planda this istifade edilir demekdir.
     * Compiler seviyyesinde bu basa dusulur.
     */

    //class MyClass3
    //{
    //    private int a; // class member
    //    private int _a2; // class member adlandirma zamani _ istifade edilir.

    //    public void Sum(int a /*method parametri*/) // method
    //    {
    //        var i = this.a; // class memeber a

    //        var i1 = a; // method-dan gelen a

    //        var i2 = a; // class memeber
    //    }
    //}

    /*
     * This hemcinin bir constructor-dan diger bir constructor-u cagirmaq ucun de
     * istifade edile biler.
     */

    #endregion


    #region speacial members

    #region constructor method

    /*
     * Constructor (ctor) method bir obyekt yaradilarken ilk ise dusen method-dur.
     *
     * ctor adi class adi ile eyni olmalidir, bu tip xususu memeberler istisna olmaqla
     * diger member-lerin adi class-la eyni ola bilmez,
     * ctor-un geriye donus deyeri yoxdur .
     *
     * ctor-un access modifier-i pyblic olmalidir (private olan veziyyetlerede baxacagiq)
     */

    //class MyClassCtorExample // class
    //{
    //    private int _number1;
    //    private int _number2;

    //    public MyClassCtorExample(int number1, int number2) // ctor method
    //    {
    //        _number1 = number1;
    //        _number2 = number2;
    //    }
    //}
    /*
     * Default Constructor
     * Her Hansisa yaradilan class icerisinde siz ctor teyin etmesez bele default olaraq orada
     * ctor var, bu compiler trfdn yerlesdirilir,
     * bunu new instance () => operatordan yadda saxlaya bilersiz bu ctor-dur.
     *
     * Biz ozumuz ctor deyin ederken default ctor-u override etmis oluruq.
     * new MyClass(); ()=>ctor
     *
     */

    /*
     * ctor-da access modifier private olan zaman basqa bir overload ctor yoxdursa ,
     * hemin classdan yeni instance ala bilmersiz.
     */

    //class MyClassPrivateCtor
    //{
    //    MyClassPrivateCtor() // private ctor
    //    {

    //    }
    //}
    /*
     * this keyword-u classa aid obyekti yemsil edir,
     * hemcinin this-le class-in ctor-lari arasinda kecid ede bilerik.
     */
    //class MyClass
    //{
    //    public MyClass()
    //    {
    //        Console.WriteLine("1.ctor");
    //    }

    //    public MyClass(int a) : this() // : this() => yuxaridaki MyClass() ctor-nu ise salir/
    //    {

    //    }
    //}

    #endregion

    #region destructor/finalizer

    /*
     * ctor-un eksine destructor  class-da en son auto ise dusen method-dur,
     * bu da o demekdir ki artiq hemin classa aid obyektle isimiz bitib,
     * ve hemin obyekt silinecek yaddasdan.
     *
     * obyektin silinmesi ucun bezi sertler lazimdir ki bunlardan biri obyektin hec bir
     * reference yoxdursa  GC-terefinden silinecek,
     * ve ya obyektin yaradildigi skopla bagli is bitibse ve o obyekt skopdan kenarda istifade
     * edilmirse GC-terefinden silinecek.
     *
     * ctor-un eksine parametr qebul etmir,
     * overload edile bilmez : yeni bir classda bir destructor method ola biler.
     */


    //class MyClass
    //{
    //    public MyClass()
    //    {
    //        Console.WriteLine("ctor");
    //    }

    //    ~MyClass() // destructor
    //    {
    //        // operations
    //        Console.WriteLine("Destructor");
    //    }
    //}

    #endregion

    #region deconstruct method

    /*
     * Bir class icersinde Deconstruct deye adlandirdigimiz method
     * Compiler terefinden xususi olaraq qeyde alinir ve class-a aid obyektden geriye
     * tuple tipi qaytarir.
     *
     *  deconstruct method-un access modifier-i public olmalidir,
     *  void method olmalidir.
     *
     */

    //class City
    //{
    //    public string Name { get; set; }
    //    public int Population { get; set; }

    //    public void Deconstruct(out string x, out int y)
    //    {
    //        x = Name;
    //        y = Population;
    //    }
    //}

    #endregion

    #region static constructor

    /*
     * Static ctor-u normal ctor-la qarshilasdirsaq asagidaki kimi bir sira ferqler var.
     * Static ctor overload olmur, yeni parametr de qebul etmeyecek ve class icerisinde sadece
     * 1 eded static ctor olacaq, access modifier olmur .
     *
     * Class-da ilk ise dusen method ctor-dur demisdik , lakin class-dan yeni bir obyekt yaradilanda (sadece ilk
     * yaradilan instance-da) static ctor  ctor-da once ise dusur, sonra hemiseki kimi ctor once ise dusecek,
     * yeni yaradilan ilk instance-dan sonra static ctor ise dusmeyecek.
     *
     * Static ctor sadece ilk instance-da deyil  hemcinin diger static memeberlerin istifadesi zamanida bir defe ise dusur,
     * burdan bu neticeye gele bilerik ki static ctor hem ilk instance zaman , hem de static memeberin istifadesi zamani ise dusecek.
     *
     */
    class MyClass
    {
        public MyClass() // ctor
        {

        }

        static MyClass() // static ctor
        {

        }
    }

    #region Singleton Design Pattern
    /*
     * Design Pattern ler daha ust level derslerdir , sadece burada static ctor-un real praktikasi
     * var deye gostermek isteyirem.
     *
     *
     * Singleton : bir class-dan sadece tek bir obyektin yaradilmasini isteyirikse bu pattern istifade edilir.
     */
    //class DataBase
    //{
    //    DataBase()
    //    {

    //    }

    //    static DataBase()
    //    {
    //        _dataBase = new DataBase();
    //    }

    //    private static DataBase _dataBase;

    //    static DataBase GetInstance => _dataBase;
    //}

    #endregion
    #endregion

    #endregion

    #endregion

    #region Garbage Collector
    // todo Garbage Collector etrafli arashdirin
    /*
     * 
     */

    #endregion

    #region object concept

    /*
     * What Is Object ?
     *
     * Obyektler complex deyerlerdir, obyetleri modellediyimiz class-lar ise
     * Complex Type-lardir. Demeli biz ortaq xussiyyetleri dasiyan obyektleri bir model
     * ile temsil edib yeni class-la sonra o model uzerinden obyektlerimizi yarada bilerik.
     *
     */

    /*
     * Instance syntax : new Type()
     * C#-da yeni bir obyekt yarada bilmek ucun new operatoru istifade edilir.
     */

    //class MyClass
    //{
    //    public string Name { get; } = "Csharp";

    //    private MyClass2 myClass2 = new();
    //}

    //class MyClass2
    //{
    //    public void Print()
    //    {
    //        MyClass myClass = new MyClass();

    //        Console.WriteLine(myClass.Name);
    //    }
    //}

    #endregion

    #region Target-Typed New Expressions  C# 9.0

    /*
     * todo c#9.0 Target-Typed New Expressions
     * Type x= new Type();
     * Type x= new(); yeni gelen ozellik
     *
     * bu ozelliyi istifade ede bilmek ucun netcoreapp3.1 dirse veya daha asagi versiya
     * onu  net5.0 deyismek lazimdir.
     *
     */


    //class MyClass
    //{


    //    private MyClass2 myClass2 = new();
    //}

    //class MyClass2
    //{

    //}

    #endregion

    #region Reference - object reference relationship

    /*
     * What is Reference ?
     *
     * Evvelki derslerimizden reference ve value type anlayislarini bildiyimizi ferz
     * ederek devam  etsek eger value type-lar stack-de reference type-lar heapde-de
     * yerlesdirilir. Burada nezerde tutulan type-in deyeri heapde reference ise stackde yerlesirki
     * reference anlayisida buradan ireli gelmektedir.
     * Reference Type bir obyekte deyere reference etmeyede biler , bu zaman o null olacaq.
     *
     */

    #endregion

    #region Shallow Copy

    /*
     * Bir obyektin, deyerin referansinin kopyalanmasidir. Yeni elimizdeki deyer
     * coxaldilmir sadece ona birde artiq referansla muraciet ede bilirik.
     */

    //public class ShallowCopyClass
    //{
    //    public string Name { get; } = "Shallow Copy";
    //}
    /*
     * Deep copy
     */
    //class DeepCopy
    //{
    //    public DeepCopy Clone()
    //    {
    //       return this.MemberwiseClone() as DeepCopy;
    //    }
    //}

    #endregion

    #region Records

    /*
     * todo c# 9.0 Records , Init-Only Properties
     *
     * C# 9.0 ile her hansi bir obyektin property-lerine ilk deyerlerin
     * menimsedilmesi ve sonradan o deyerlerin de deyisdirile bilmemesini temin
     * eden Init-Only Properties xususiyyeti gelmisdir.
     *
     * Init-Only Properties ile sadece getonly readonly arasindaki ferq readOnly olan
     *  property-ye obyekt ilk initialize, yaradildigi an ona deyer vere bilmirik.
     * Object Initializer.
     *
     * Record nedir?
     *
     * Init-Only properties xususiyyeti ile biz class daxilindeki property-lerimizi deyismez
     * sadece oxuna bilir veziyyete getiririk , lakin biz obyektin ozunude deyismez sabit olmasini
     * temin etmek isteyirikse burada record istifade edilir.
     *
     * Record-a lightweight class-da deye bilerik.
     *
     * Class-da on planda olan her zaman obyekt, Record-da ise on planda olan onun daxilindeki
     * deyerlerdir.
     *
     * Classin her instance-i ferqli deyerler olaraq qebul edilerken,
     * Record daxilinde deyerler eyni oldugundan  instance-lar ferqli bele olsa eyni deyer olaraq
     * qebul edilirler.
     *
     * Ferqi Class-in iki ferqli instance-ni bir biri ile Equals(instance1, instance2)
     * qarsilasdirilmasi false , Record-da true olacaq.
     *
     *
     */

    #region Init-Only Properties

    //class MyClassInitOnly
    //{
    //    public int MyPropertyReadOnly { get; } = 3; // readonly property
    //    public int MyPropertyInitOnly { get; init; } // init keywordu vasitesile ile
    //}

    //class MyClass2
    //{
    //    public void Test()
    //    {
    //        MyClassInitOnly myClass = new MyClassInitOnly
    //        {
    //            /*
    //             * Obyekt ilk yaradilan zaman ona deyer verdik ve
    //             * onu readonly etdik
    //             */
    //            MyPropertyInitOnly = 3
    //        };
    //    }
    //}

    #endregion

    #region Record
    /*
     * Init-Only Properties xususiyyeti record-da daha cox istifade edilir.
     */
    //record MyRecord
    //{
    //    public int MyProperty { get; set; }
    //}

    //class MyClass
    //{
    //    public int MyProperty { get; set; }
    //}
    //class MyClassTest
    //{
    //    public void Test()
    //    {

    //     MyRecord record1 = new MyRecord
    //     {
    //         MyProperty = 5
    //     };

    //     MyRecord record2 = new MyRecord
    //     {
    //         MyProperty = 5
    //     };
    //     Console.WriteLine(record1.Equals(record2)); // true
    //     MyClass myClass1 = new MyClass
    //     {
    //         MyProperty = 5
    //     };

    //     MyClass myClass2 = new MyClass
    //     {
    //         MyProperty = 5
    //     };

    //     Console.WriteLine(myClass1.Equals(myClass2)); // false
    //    }

    //}
    #region with expression
    /*
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/with-expression
     */
    #endregion
    #endregion
    #endregion
}
