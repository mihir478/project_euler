using System;

namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[20][];
            for (int grid_i = 0; grid_i < 20; grid_i++)
            {
                string[] grid_temp = Console.ReadLine().Split(' ');
                grid[grid_i] = Array.ConvertAll(grid_temp, Int32.Parse);
            }
            findMaxProduct(grid, 4);
            Console.ReadKey();
        }

        static void findMaxProduct(int[][] grid, int factors)
        {
            int maxProduct = 0;

            for (int i = 0; i < grid.Length; ++i)
                for (int j = 0; j < grid[0].Length - factors + 1; ++j) {
                    int intermediateProductHorizontal = grid[i][j];
                    for (int k = 1; k < factors; ++k)
                        intermediateProductHorizontal *= grid[i][j + k];
                    maxProduct = Math.Max(maxProduct, intermediateProductHorizontal);
                }

            for (int i = 0; i < grid.Length - factors + 1; ++i)
                for (int j = 0; j < grid[0].Length; ++j)
                {
                    int intermediateProductVertical = grid[i][j];
                    for (int k = 1; k < factors; ++k)
                        intermediateProductVertical *= grid[i + k][j];
                    maxProduct = Math.Max(maxProduct, intermediateProductVertical);
                }

            for (int i = 0; i < grid.Length - factors + 1; ++i)
                for (int j = 0; j < grid[0].Length - factors + 1; ++j) {
                    int intermediateProductDiagonal = grid[i][j];
                    for (int k = 1; k < factors; ++k)
                        intermediateProductDiagonal *= grid[i + k][j + k];
                    maxProduct = Math.Max(maxProduct, intermediateProductDiagonal);
                }

            for (int i = factors - 1; i < grid.Length; ++i)
                for (int j = 0; j < grid[0].Length - factors + 1; ++j) {
                    int intermediateProductAntiDiagonal = grid[i][j];
                    for (int k = 1; k < factors; ++k)
                        intermediateProductAntiDiagonal *= grid[i - k][j + k];
                    maxProduct = Math.Max(maxProduct, intermediateProductAntiDiagonal);
                }

            Console.WriteLine(maxProduct);
        }
    }
}
