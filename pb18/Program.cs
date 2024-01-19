using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');

            int x = int.Parse(Console.ReadLine());

            double result = 0;

            for (int i = 0; i < nums.Length; i += 1)
            {
                result = result + int.Parse(nums[i]) * toPow(x, nums.Length - i - 1);
            }

            Console.WriteLine(result);
        }

        private static double toPow(int num, int power)
        {
            int result = 1;

            while (power > 0)
            {
                result *= num;
                power -= 1;
            } 

            return result;
        }
    }
}
