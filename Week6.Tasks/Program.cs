using System;
using System.Collections.Generic;
using System.Linq;

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

            var students = new List<Student>
            {
                new Student{Id = 1, Name = "A",Address = "12",Number = "121"},
                new Student{Id = 2, Name = "A",Address = "12",Number = "121"},
                new Student{Id = 3, Name = "A",Address = "12",Number = "121"},
                new Student{Id = 4, Name = "A",Address = "12",Number = "121"},
                new Student{Id = 5, Name = "A",Address = "12",Number = "121"}
            };

            ConsoleDataFormatter.PrintSeparatorLine();
            ConsoleDataFormatter.PrintRow("Id", "Name", "Address", "Number");
            ConsoleDataFormatter.PrintSeparatorLine();

            foreach (var item in students)
            {
                ConsoleDataFormatter.PrintRow(item.Id.ToString(), item.Name, item.Address, item.Number);
                //Console.WriteLine(item.Id.ToString(),item.Name,item.Address,item.Number);
            }
            ConsoleDataFormatter.PrintSeparatorLine();

        }
    }


    public static class ConsoleDataFormatter
    {
        private const int TableWidth = 80;

        public static void PrintSeparatorLine()
        {
            Console.WriteLine(new string('-', TableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            // (80 - 4)/4= 19
            int columnWidth = (TableWidth - columns.Length) / columns.Length;

            const string seed = "|";

            string row = columns.Aggregate(seed, (separator, columnText) =>
                separator + GetCenterAlignedText(columnText, columnWidth) + seed);

            Console.WriteLine(row);
        }

        private static string GetCenterAlignedText(string columnText, int columnWidth)
        {
            columnText = columnText.Length > columnWidth
                ? columnText.Substring(0, columnWidth - 3) + "..."
                : columnText;

            //  text: id length=2
            //  (columnWidth-((columnWidth - columnText.Length) / 2) = 19-(19-2)/2=10.5
            string text = string.IsNullOrEmpty(columnText)
                ? new string(' ', columnWidth)
                : columnText.PadRight(columnWidth - ((columnWidth - columnText.Length) / 2)).PadLeft(columnWidth);
            return text;
        }
    }

    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
    }
}
