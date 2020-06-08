using System;

namespace CSharp.Arrays
{
    public static class JaggedArr
    {
        public static void CreateInnerArr()
        {
            int[][] matrix = new int[3][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3];                  // Create inner array

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = i * 3 + j;
                }
            }


        }
    }
}
