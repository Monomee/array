using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");
            } while (size > 20);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + ((j == array.Length - 1) ? " " : ", "));
            }

            Console.WriteLine();
            bool isValid = false;
            int pos;
            do
            {
                Console.WriteLine("Enter the position to insert: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out pos);
                if ((!isValid) || (pos > array.Length || pos < 0))
                {
                    Console.WriteLine("Invalid!");
                }
            } while ((!isValid) || (pos > array.Length || pos < 0));
            int[] newArr = new int[size + 1];
            Array.Copy(array, newArr, pos);
            Console.WriteLine("Enter the number: ");
            int x = Int32.Parse(Console.ReadLine());
            newArr[pos] = x;
            Array.Copy(array, pos, newArr, pos + 1, array.Length - pos);
            Console.WriteLine(string.Join(", ", newArr));

            Console.ReadLine();
        }
    }
}
