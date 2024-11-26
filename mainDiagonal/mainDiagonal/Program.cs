using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            int size = 0;
            do
            {
                Console.WriteLine("Enter Size(0 < size < 10): ");
                string input = Console.ReadLine();           
                isValid = int.TryParse(input, out size);
                if (!(isValid && size < 10 && size > 0))
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (!(isValid && size < 10 && size > 0));

            double[,] arr = new double[size, size];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Row {0}, column {1}", i + 1, j + 1);
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i, i];
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();
        }
    }
}
