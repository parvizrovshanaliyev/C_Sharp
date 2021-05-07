using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Customer
    {
        public Customer()
        {
            id = IdGenerator();
        }
        // field
        int id;
        string name;
        string surname;
        string email;

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public string Name { get; set; }
        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                this.surname = value;
                this.email = $"{this.name}.{this.surname}@gmail.com";
            }
        }
        public string Email { get;}
        
        private int IdGenerator()
        {
            Random rnd = new();
            return rnd.Next(10000, 90000);
        }
    }
}
