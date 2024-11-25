using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findStudentName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.Write("Enter the name: ");
            string input = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (input.Equals(students[i]))
                {
                    Console.WriteLine("Position of " + students[i] + " is " + i);
                    isExist = true;
                    break;
                }
            }
            if (!isExist) 
            {
                Console.WriteLine("Not found.");
            }
            Console.ReadLine();
        }
    }
}
