using System;

namespace OOP.InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OOP.InnerType
            /*
             * OOP-de tez-tez istifade edilen inner type olaraq adlandirdigimiz mefhumu
             * ic-ice obyektlerin istifadesidir.
             *
             */
            #endregion

            Customer customer = new Customer{
                Id = 1,
                FinCode = "234fgh",
                Name = "Qedir",
                Surname = "Qedirov",

                //CustomerAddresses = new []
                //{
                //    new CustomerAddress
                //    {
                //    },
                //    new CustomerAddress{

                //    },
                //    new CustomerAddress{

                //    },
                //}
               
               
            };

            // xeta verecek
            customer.CustomerAddresses[0] = new CustomerAddress()
            {
                AddressType = "Is Yeri",
                City = "Baki",
                Address = "Yasamal",
                Country = "Azerbaycan"
            };
        }
    }

    public class Customer
    {
        public Customer()
        {
            CustomerAddresses = new CustomerAddress[5];
            CustomerContacts = new CustomerContact[5];
            CustomerOrders = new CustomerOrder[5];
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FinCode { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; } = DateTime.Now;

        #region Inner Type properties
        //public string AddressType { get; set; }
        //public string Country { get; set; }
        //public string City { get; set; }
        //public string Address { get; set; }

        public CustomerAddress[] CustomerAddresses;
        public CustomerContact[] CustomerContacts;
        public CustomerOrder[] CustomerOrders;

        #endregion


    }

    public class CustomerAddress
    {
        public string AddressType { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }

    public class CustomerContact
    {
        public string Code { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
    }

    public class CustomerOrder
    {
        public string OrderNumber { get; set; }
    }
}
