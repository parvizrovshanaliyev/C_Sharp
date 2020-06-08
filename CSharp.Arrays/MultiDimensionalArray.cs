using System;

namespace CSharp.Arrays
{
    public static class MultiDimensionalArray
    {
        public static int[,] Arr { get; } =
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        public static void SumDiagonal(int[,] arr)
        {
            int sum = 0;

            for (int i = 0; i < Math.Min(arr.GetLength(0), arr.GetLength(1)); i++)
                sum += arr[i, i];

            Console.WriteLine(sum);
        }

        public static void SumAntiDiagonal(int[,] arr)
        {
            int sum = 0;

            for (int i = 0; i < Math.Min(arr.GetLength(0), arr.GetLength(1)); ++i)
                sum += arr[i, arr.GetLength(1) - 1 - i];

            Console.WriteLine(sum);
        }
    }
}
