using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Aritmetik
{
    class Program
    {
        static void Main(string[] args)
        {
            soru2();
            Console.ReadKey();
        }
        static void soru2()
        {
            int x = 6, y = 5, z = 4;
            z += y += x *= 2;
            Console.WriteLine("{0}\t{1}\t{2}", x, y, z);
        }
        
    }
}
