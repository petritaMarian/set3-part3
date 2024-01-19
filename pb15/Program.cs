using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');
            int n = nums.Length;
            bool verif;

            for (int i = 0; i < n - 1; i += 1)
            {
                verif = false;
                for (int j = i + 1; j < n; j += 1)
                    if (nums[i] == nums[j])
                    {
                        verif = true;
                        nums[j] = "del";
                    }

                if (verif) nums[i] = "del";
            }

            string aux;

            for (int i = 0; i < n - 1; i += 1)
                for (int j = i + 1; j < n; j += 1)
                    if (nums[i] == "del" && nums[j] != "del")
                    {
                        aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                        break;
                    }

            for (int i = 0; i < n; i += 1)
                if (nums[i] == "del") continue;
            else Console.Write(nums[i] + " ");
            Console.WriteLine();    
        }
    }
}
