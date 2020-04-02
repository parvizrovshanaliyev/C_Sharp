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

        public static void Reverse_v2()
        {
            int[] arr = {5, 6, 9, 12, 15, 7, 3, 20, 14, 36 , 24};
            int temp;
            int i;
            for (i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }

            foreach (var item in arr) Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
