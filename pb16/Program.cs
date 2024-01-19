using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pb16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');

            int cmmdc = int.Parse(nums[0]);

            for (int i = 1; i < nums.Length; i += 1)
            {
                cmmdc = cmmdcBetween2Values(cmmdc, int.Parse(nums[i]));
            }

            Console.WriteLine(cmmdc);
        }

        static int cmmdcBetween2Values(int x, int y)
        {
            int aux;
            while (y != 0)
            {
                aux = y;
                y = x % y;
                x = aux;
            }
            return x;
        }
    }
}
