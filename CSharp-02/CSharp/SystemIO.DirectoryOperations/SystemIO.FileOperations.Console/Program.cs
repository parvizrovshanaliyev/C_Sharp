using System;
using System.IO;

namespace SystemIO.FileOperations.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SystemIO.FileOperations

            /*
             * File uzerindeki emeliyyatlar Directory class-i ile oxsardir sadece qovluq uzerinde yox file uzerinde
             * yazma oxuma silme kimi emeliyyatlar yerine yetirilir
             */

            #endregion


            #region examples

            #region create file
            /*
             * xeta : System.IO.DirectoryNotFoundException: 'Could not find a part of the path 'C:\Test\createdFile.txt'.'
               daxil edilen adresde Test qovluqu olmadigina gore bele bir xeta verir...
             */
            FileCreate(@"C:\test\createdFile.txt");

            #endregion

            #region exist

            bool control = Exist(@"C:\test\createdFile.txt");
            if(control) System.Console.WriteLine("Daxil edilen fayl artiq movcuddur");
            else FileCreate(@"C:\test\createdFile.txt");

            #endregion

            #region delete

            bool control2 = Exist(@"C:\test\createdFile.txt");
            if (control2) FileCreate(@"C:\test\createdFile.txt");
            else System.Console.WriteLine("Daxil edilen fayl movcud deyil");

            #endregion

            #region move
            Move(@"c:\test\createdFile.txt", @"c:\test1\createdFile.txt");
            #endregion
            #endregion

            #region File.Create
            /*
             * bu method vasitesile daxil edilen adressde her hansi bir fayl yaradilir.
             * geriye FileStream qaytarir.
             *
             * asagida istifade edilen Close() method-u yaranan file yarandiqdan sonra bize FileStream olaraq
             * geri donerken arxa terefde aciq qalir bu problem yaranmasin deye istifade edilmelidir.
             */

            static void FileCreate(string path)
            {
                FileStream fileStream=File.Create(path);
                fileStream.Close();
            }

            #endregion

            #region File.Exist
            /*
            * qeyd edilen adresde fayl olub olmamasini yoxlayir.
            */

            static bool Exist(string path)
            {
                return File.Exists(path);
            }
            #endregion

            #region File.Delete
            /*
            * qeyd edilen adresde faylin silinmesi
            */

            static void Delete(string path)
            {
                File.Delete(path);
            }
            #endregion

            #region File.Move
            /*
             * daxil edilen adrese file dasinmasi...
             */

            static void Move(string sourceFile, string destinationFile)
            {
                File.Move(sourceFile, destinationFile);
            }
            #endregion

            #region File.Copy
            /*
             * daxil edilen adrese file dasinmasi...
             */

            static void Copy(string sourceFile, string destinationFile)
            {
                File.Copy(sourceFile, destinationFile);
            }
            #endregion

            #region File.AppendAllText
            /*
             * yaradilan her hansisa file data daxil edilmesi
             */

            static void AppendAllText(string path, string data)
            {
                File.AppendAllText(path, data);
            }
            #endregion

            #region File.ReadAllText
            /*
             * yaradilan her hansisa filedan data oxunmasi 
             */

            static string ReadAllText(string path)
            {
              return File.ReadAllText(path);
            }
            #endregion
        }
    }
}
