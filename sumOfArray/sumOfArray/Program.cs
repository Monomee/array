using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            nums[0] = 2;
            nums[1] = 5;
            nums[2] = 9;
            nums[3] = 6;
            nums[4] = 7;
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[3]);
            int total = 0;
            foreach (int ele in nums)
            {
                total += ele;
            }
            Console.WriteLine(total);
            Console.WriteLine(total.ToString());
            Console.ReadLine();
        }
    }
}
