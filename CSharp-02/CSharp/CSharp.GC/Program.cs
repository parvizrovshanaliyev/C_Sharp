using System;

namespace CSharp.GC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region garbage collector
            /*
             * .Net Framework based development eden zaman memory meseleleri deyerken
             * ilk agila gelen tebii ki, Garbage Collector olacaq , cunki isin mentiqinde
             * artiq istifade olunmayan datalari biz bir bir manual sekilde silme zehmetine
             * girmirik , kobudca bizden sonra butun zir zibili bu qedesh temizleyir, amma isleme
             * prinsipi ve isin ozu bu qeder sade deyil.
             *
             * Managed platformlarda (.net, java ve s.) memory emeliyyatlari bu .net platformasi
             * terefinden oz daxilinde idare edilir. Biraz daha low -level dillerde memory managment
             * developer terefinden manage edilmelidir. C/C++ da malloc() ve free() methodlari vasitesile
             * memory manage isleri gorule bilmekdedir.
             *
             * .Net-de CLR run olunan zaman obyektlerimiz/datalarimiz ucun "managed heap" deye bir sahe
             * yaradir. GC-de bu sahedeki datalari onceliye gore siralayir  ya silir yada daha sonra silinmek
             * ucun bir sonraki istifadeye qeder yaddasda saxlayir.
             *
             * GC collector bes neye esasen bu silme isini aparir deye bilersiz yeni nece bilir ki bu obyekt
             * silinmelidir, daha onceki derslerimizde bunun ustunden qisa kecmisdik , dusunun ki sadece birdefe
             * cagrilacaq bir method yazmisiz ve hemin methodun skoplari daxilinde bir nece class-dan
             * yeni instance-lar almisiz tebii ki yaradilan her data ram-da bir yerde saxlanilmalidir ki
             * biz o datani istifade edek , dediyimiz senariye uygun heleki problem yoxdu amma method cagrildi ve
             * onunla isimiz bitdi , bu zaman onun daxilindeki obyektler global istifade edilmediyinden
             * gc terefinden silinecek .
             *
             * GC-nin ozunden 3 Generation var ve bu genererationlar mutemadi olaraq gen0, gen1, gen2 oz aralarinda
             * datalari bir birine oturur ,bu struktur neye imkan verir? Demeli gen0 da olan obyekt
             * sirasi ile gen1 gen2 oturulmekle gc eslinde o obyekti qoruyub saxlayir yeni bu global olaraq
             * istifade edilen bir data-dir hemcinin gen1 uzerindeki datalari oturur ki yeni yaranaq olan
             * obyektlere yer acilsin , buradanda aydin olurki obyektin omru oldugu generation nomresine gore daha cox
             * olacaq.
             *
             * Gen0
             * GC en cox bu generation isleyir cunki baslagic gen0 dir , gen0 da olan ve hele silinmeyen
             * obyekt gen0 da yeteri qeder yer olmadigi teqdirde yaddas uzerindeki addressi gen1 sahesine kopyalanir
             *
             * Gen1
             * Buradaki obyektler gen0 dakilara nisbeten daha uzun omurludur lakin kifayet qeder yer yoxdursa
             * gen2 ye koculur ancaq bundan evvel GC Roots hissesinde memorydeki referanslarina baxilir,
             * yeni istifade edilirmi ya referansi yoxdurmu aydinlasdirilir eger referansi olmazsa memory-den silinir.
             *
             *
             * Gen2
             * En uzun omurlu qaqalar gen2 de saxlanilir, static deyisenler ve s.
             * Bir obyektin bu generationa qeder gelmesi onun global helede referanslari oldugu menasina gelir,
             * amma biz kodumuzda olur olmadiq sekilde lazimsiz formada obyektleri uzun omurlu teyin etsek
             * birazdan bizde performans problemleri Salamumaeykum edecek
             *
             *
             * GC butun thread-lerden musteqil bir thread olaraq isleyir, runtime-da esasen
             * generationlarda yer azalanda ise dusur ve diger threadleri dayandirir bu emeliyyatlar
             * millisaniye seviyyesinde oldugundan coxda bir sey his edilimir , amma problem yaratdigi
             * meqamlarda var, evvela butun theadlerden elave bir thread olaraq islemesi elave bir yukdur.
             *
             * GC.Collect() methoduna dector kecerken bir salam vermisdik  bu method vasitesile GC ise salinir.
             * amma istifadesi performans problemlerine getirib cixara biler coxda meslehet gorulmur .
             *
             * Dispose ve Finalize methodlari memory-ni duzgun sekilde idare ede bilmek ucun bir biri ile
             * elaqeli sekilde istifade edilir. Dispose vasitesile managed and unmanaged resourclari idare edirik,
             * Finalize vasitesile ile dector ise dusmezden evvelki emeliyyatlari ve ya lazim olarsa umumiyyetle dector-un
             * ise dusmemesini idare ede bilerik.
             *
             *
             * Dispose icerisinde , gc terefinden obyektimizin finalize emeliyyatina meruz qalmasini temin ede veya
             * mueyyen sertlerle finalize emeliyyatini texire sala bilerik.
             *
             * Finalization ozunde freachable queue ve finalization queue olaraq 2 yere bolunur, bunlar memory uzerindeki
             * obyektler haqqinda melumat saxlayirlar , yeni instance alinan zaman hemin obyektin eger ki dectoru varsa
             * hemin obyektin pointeri finalization queue elave edilir, ve GC artiq class-in dectoru var ya yoxyoxlamagina ehtiyyac qalmir,
             * GC GC Rootsa baxan zaman silinecek obyektleri teyin edir bu zaman o finalization queue da hemin obyekt haqqinda melumat varmi deye baxir ,
             * silinecek olan obyektleri finalization queue-dan freachable queue hissesine dasiyir ve runtime-da ayrica bir thread obyektlerin dectorlarini
             * cagirir ve quyrugdaki sirani bosaldir.
             *
             */


            #endregion
        }

        void Test()
        {
            var arr1 = new int[3] {1, 2, 3};
            var arr2 = new int[3] {1, 2, 3};

            int a = 5;
        }
    }
}
