using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.MessageBoxNotification
{
    internal class Customer
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }

        #region Overrides of Object

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        #endregion
    }

    internal class VirtualDB
    {
        public static readonly List<Customer> Customers;

        static VirtualDB()
        {
            Customers = new List<Customer>();
        }
    }
}
