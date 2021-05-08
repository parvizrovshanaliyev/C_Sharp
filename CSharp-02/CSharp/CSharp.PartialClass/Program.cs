using System;

namespace CSharp.PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Partial class

            /*
             * Partial class anlayisi C# 2.0 ile birlikde gelmisdir.
             * Bu ozellik heddinden artiq kod setirlerinden ibaret class-i hisselere ayirmaga
             * yarayir, yeni class-in memberlerini ferqli partial class-larda saxlaya bilerik.
             */

            #endregion

            Customer customer = new Customer
            {
                Id = 1,
                Name = "Filankes",
                Surname = "Filankesov",
                Email = "filankesov@gmail.com"
            };

            var result = customer.Add(customer);

            if (result > 0)
            {
                Console.WriteLine("Yeni musteri dbya elave edildi");
            }

        }
    }

    public class Customer
    {
        #region props

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// Yeni musterinin elave edilmesi
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>id</returns>
        public int Add(Customer customer)
        {
            // db-ya elave edilme emeliyyatlari yerine yetirilir
            Console.WriteLine("Yeni musteri elave edildi");
            // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
            // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
            // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz
            return 1;
        }

        /// <summary>
        /// Musterinin redakte edilmesi
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>result</returns>
        public int Update(Customer customer)
        {
            int result = 1;
            // db-daki musteri redakte edilir
            Console.WriteLine("musteri redakte edildi");
            // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
            // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
            // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz

            return result;
        }

        /// <summary>
        /// Musterinin silinmesi
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id</returns>
        public int Remove(int id)
        {
            Console.WriteLine("musteri silindi");
            // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
            // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
            // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz
            return 1;
        }

        #endregion
    }
}
//public partial class Student
//{
//    #region props
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public string Email { get; set; }
//    #endregion
//}
//public partial class Student
//{
//    #region methods
//    /// <summary>
//    /// Yeni telebenin elave edilmesi
//    /// </summary>
//    /// <param name="customer"></param>
//    /// <returns>id</returns>
//    public int Add(Customer customer)
//    {
//        // db-ya elave edilme emeliyyatlari yerine yetirilir
//        Console.WriteLine("Yeni telebe elave edildi");
//        // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
//        // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
//        // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz
//        return 1;
//    }

//    /// <summary>
//    /// Telebenin redakte edilmesi
//    /// </summary>
//    /// <param name="customer"></param>
//    /// <returns>result</returns>
//    public int Update(Customer customer)
//    {
//        int result = 1;
//        // db-daki telebe redakte edilir
//        Console.WriteLine("telebe redakte edildi");
//        // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
//        // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
//        // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz

//        return result;
//    }

//    /// <summary>
//    /// Telebenin silinmesi
//    /// </summary>
//    /// <param name="id"></param>
//    /// <returns>id</returns>
//    public int Remove(int id)
//    {
//        Console.WriteLine("telebe silindi");
//        // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
//        // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
//        // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz
//        return 1;
//    }

//    #endregion
//}
