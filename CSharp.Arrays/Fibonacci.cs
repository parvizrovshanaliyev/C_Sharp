using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public static class Fibonacci
    {
        public static void Arr()
        {
            var a = new int[20];
            a[0] = 1;
            a[1] = 1;
            int i;
            for (i = 2; i < a.Length; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }

            foreach (var item in a) Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
