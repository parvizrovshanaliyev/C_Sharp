
using System.IO;

namespace SystemIO.DirectoryOperations.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region using System.IO;
            /*
             * System.IO kitabxanasindan istifade ederek file uzerinde yazma oxuma emeliyyatlarini ve ya directory ile
             * bagli emeliyyatlari yerine yetire bilerik. Burada olan IO input output qisaltmasidir.
             *
             *
             * System.IO namespace https://docs.microsoft.com/en-us/dotnet/api/system.io?view=net-5.0
             * https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Temel_I/O_işlemleri
             */


            #endregion

            #region example

            #region Directory.CreateDirectory

            CreateNewFolder(@"C:\Test");

            #endregion

            #region exist

            bool existDirectory=ExistsDir(@"C:\Test");

            if(!existDirectory) CreateNewFolder(@"C:\Test");
            else System.Console.Write("daxil edilen adress movcuddur");
            #endregion

            #region delete

            DeleteDir(@"C:\Test");

            #endregion

            #endregion


            #region Directory.CreateDirectory
            /*
             *  Directory.CreateDirectory vasitesile daxil edilen adresde yeni folder yarada bilerik.
             *  geriye DirectoryInfo tipinde data qaytarir.
             */
            static void CreateNewFolder(string path)
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
            }

            #endregion

            #region Directory.Exists
            /*
             * Directory.Exists methodu bildirilen adressin movcud olub olmadigi yoxlayir ve geriye bool qaytarir.
             */
            static bool ExistsDir(string path)
            {
                return Directory.Exists(path);
            }
            #endregion

            #region Directory.Delete
            /*
             * Directory.Delete methodu ilk daxil edilen parametrde qeyd edilen adresi silir, ikinci daxil edilen parametrde ise
             * daxil edilen addresdeki qovluq icerisinde data varsa onu da silir.
             */
            static void DeleteDir(string path)
            {
                bool control = ExistsDir(path);

                if (control)
                {
                    System.Console.WriteLine("qovluq silindi");
                    Directory.Delete(path);
                }
                //if (control) Directory.Delete(path,true); 
                else System.Console.WriteLine("daxil edilen addres tapilmadi");

            }
            #endregion

            #region Directory.Move
            /*
             * Directory.Move bir addresden digerine dasima.
             */
            static void Move(string sourceDirPath, string destinationDirPath)
            {
                Directory.Move(sourceDirPath, destinationDirPath);
            }
            #endregion
        }
    }
}
