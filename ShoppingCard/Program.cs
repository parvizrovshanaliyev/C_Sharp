using System;
using System.Collections.Generic;

namespace ShoppingCard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FreshGrocery freshGrocery = new FreshGrocery {Name = "Fresh grocery", Price = 30, Weight = 0.5};

            Grocery grocery = new Grocery {Name = "Grocery", Price = 50, Quantity = 2};

            ShoppingCart cart = new ShoppingCart {Orders = new List<GroceryItem> {freshGrocery, grocery}};

            double price = cart.Calculate();

            Console.WriteLine("Price: {0}", price);
        }
    }

    abstract class GroceryItem
    {
        private string _name;
        private double _price = 0;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public abstract double Calculate();
    }

    class FreshGrocery : GroceryItem
    {
        private double weight = 0;

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public override double Calculate()
        {
            return this.Price * this.Weight;
        }
    }

    class Grocery : GroceryItem
    {
        private int quantity = 0;
        private double gst = 10; // In Percentage

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public override double Calculate()
        {
            double calculatedPrice = this.Price * this.Quantity;

            // VAT
            if (calculatedPrice > 0)
            {
                calculatedPrice += calculatedPrice * (gst / 100);
            }

            return calculatedPrice;
        }
    }

    class ShoppingCart
    {
        private List<GroceryItem> orders;

        public List<GroceryItem> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        public double Calculate()
        {
            double price = 0;
            if (this.Orders != null)
            {

                foreach (GroceryItem order in this.Orders)
                {
                    price += order.Calculate();
                }

            }
            return price;

        }
    }
}
#region MyRegion





#endregion