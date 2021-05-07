using System;

namespace CSharp.PartialClass
{
    public partial class Student
    {
        #region methods
        /// <summary>
        /// Yeni telebenin elave edilmesi
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>id</returns>
        public int Add(Customer customer)
        {
            // db-ya elave edilme emeliyyatlari yerine yetirilir
            Console.WriteLine("Yeni telebe elave edildi");
            // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
            // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
            // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz
            return 1;
        }

        /// <summary>
        /// Telebenin redakte edilmesi
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>result</returns>
        public int Update(Customer customer)
        {
            int result = 1;
            // db-daki telebe redakte edilir
            Console.WriteLine("telebe redakte edildi");
            // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
            // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
            // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz

            return result;
        }

        /// <summary>
        /// Telebenin silinmesi
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id</returns>
        public int Remove(int id)
        {
            Console.WriteLine("telebe silindi");
            // gelecekde ola bilerki add method size insert olunan modelden geriye id qaytarsin.
            // ve ya her hansisa result tipi qaytara biler geri qayidan result tipinide if le yoxlayib
            // emelliyatin ugurlu olub olmadigini yoxlaya bilersiz
            return 1;
        }

        #endregion
    }
}
