using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public static class ReverseArr
    {
        public static void Reverse()
        {
            int[] oldArr = { 5, 13, 20, 30, 15, 40 };
            int i, j, x, n = oldArr.Length;
            int[] newArr = new int[n];

            Console.WriteLine("old array");
            
            for (j = 0; j < n; j++)
                Console.Write(oldArr[j] + " ");

            for (i = 0; i < n; i++)
            {
                newArr[n - 1 - i] = oldArr[i];
            }

            Console.WriteLine("reversing array");
            for (x = 0; x < n; x++)
                Console.Write(newArr[x] + " ");
        }
    }
}
