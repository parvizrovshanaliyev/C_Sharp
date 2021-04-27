using System;

namespace OOP.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region encapsulation
            //EncapsulationWithMethodClass encapsulationWithMethod = new();
            //encapsulationWithMethod.XSet(5);
            //Console.WriteLine(encapsulationWithMethod.XGet());
            #endregion

            Customer customer = new();
            Console.WriteLine(customer.Id.ToString());
        }
    }

    #region Encapsulation

    /*
     * Ecapsulation obyektlerimizde ki field-lerimizi property-ler vasitesile
     * istifade etmekdir ki bu istifade zamani colden bir basa fielde deyil sadece property-e
     * cata bilirik. Kapsul icerisine alinan field kontrollu bir sekilde istifade edilir.
     *
     * Umumiyyetle ireli seviyye derslerde bir cox pattern yanasmalarinda bu anlayisi praktikada
     * goreceksiniz.
     *
     * C# -da Encapsulation method ve property vasitesi ile edilir.
     *
     * Property gelene qeder encapsulation ucun sadece method-lardan istifade edilirdi.
     */

    // method vasitesi ile encapsulation
    class EncapsulationWithMethodClass
    {
        private int x;

        public int XGet()
        {
            return this.x;
        }

        public void XSet(int val)
        {
            this.x = val;
        }
    }

    ///propfull tab
    class EncapsulationWithProp
    {
        private int _a;

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

    }

    #endregion
}
