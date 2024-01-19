using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] s = arrayInput.Split(' ');

            string secondArrayInput = Console.ReadLine();
            string[] p = secondArrayInput.Split(' ');


            int k = 0;
            int count = 0;

            for (int i = 0; i < s.Length; i += 1)
            {
                if (s[i] == p[k])  k += 1; 
                else { i -= k; k = 0; }
                if (k == p.Length) { count += 1; i -= k - 1; k = 0; }
            }

            Console.WriteLine(count);
        }
    }
}
