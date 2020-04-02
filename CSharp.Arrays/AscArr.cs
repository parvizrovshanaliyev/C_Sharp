using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public static class AscArr
    {
        public static void Ascending()
        {
            int[] intArray = {2, 9, 4, 3, 5, 1, 7};
            var temp = 0;
            int i, j;
            for (i = 0; i <= intArray.Length - 1; i++)
            for (j = i + 1; j < intArray.Length; j++)
                if (intArray[i] > intArray[j])
                {
                    temp = intArray[i];
                    intArray[i] = intArray[j];
                    intArray[j] = temp;
                }

            Console.WriteLine("Array sort in ascending order");
            foreach (var item in intArray) Console.WriteLine(item);
        }
    }
}
