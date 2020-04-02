using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Class
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class People
    {
        public string Name { get; }
        public int Weight { get; }

        public People(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
    }
}
