using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region field
            //MyClass myClass = new MyClass();
            //var myClassNumber = myClass.number;
            #endregion

            #region indexer

            //MyClassIndexer myClassIndexer = new MyClassIndexer();

            //myClassIndexer[0] = 5;

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
     */

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
    #endregion
    #endregion
}
