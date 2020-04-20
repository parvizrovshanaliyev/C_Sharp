using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.One
{
    class Product
    {
        public int Id { get; set; }
        public string Code { get; set; } // 232323233442323
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }

        public Product(
            int id,
            string code,
            string name,
            double price)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }
    }
}
