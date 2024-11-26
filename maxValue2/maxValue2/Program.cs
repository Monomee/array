using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxValue2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            int row = 0;
            int col = 0;
            do
            {
                Console.WriteLine("Enter Row (0 < row < 10): ");
                string input1 = Console.ReadLine();
                bool con1 = int.TryParse(input1, out row);
                Console.WriteLine("Enter Column (0 < col < 10): ");
                string input2 = Console.ReadLine();
                bool con2 = int.TryParse(input2, out col);
                isValid = con1 && con2;
                if (!(isValid && row < 10 && col < 10 && row > 0 && col > 0))
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (!(isValid && row < 10 && col < 10 && row > 0 && col > 0));

            double[,] arr = new double[row, col];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Row {0}, column {1}", i + 1, j + 1);
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            double max = Double.MinValue;
            int[] index = new int[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        index[0] = i+1;
                        index[1] = j+1;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Max value is: {0} at row {1} and column {2}", max, index[0], index[1]);

            Console.ReadLine();
        }
    }
}
