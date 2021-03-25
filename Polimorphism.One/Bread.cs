using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.One
{
    public enum BreadType
    {
        White = 1,
        Wheat,
        WholeGrain
    }

    public enum Weight
    {
        Hundred = 100,
        OneHundredTwentyFive = 125,
        TwoHundred = 200
    }

    class Bread : Product
    {
        public BreadType Type { get; set; }
        public Weight Weight { get; set; }
        public string Producer { get; set; }

        public Bread(
            int id,
            double price,
            BreadType type)
        {
            switch (type)
            {
                case BreadType.White:
                    Price = 1.0;
                    Weight = Weight.Hundred;
                    break;
                case BreadType.Wheat:
                    Price = 2.0;
                    Weight = Weight.OneHundredTwentyFive;
                    break;
                case BreadType.WholeGrain:
                    Price = 3.0;
                    Weight = Weight.TwoHundred;
                    break;
            }
        }
    }
}
