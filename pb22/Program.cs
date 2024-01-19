using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstArrayInput = Console.ReadLine();
            string[] firstArray = firstArrayInput.Split(' ');
            string secondArrayInput = Console.ReadLine();
            string[] secondArray = firstArrayInput.Split(' ');

            int count = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                    if (firstArray[i] == secondArray[j]) count += 1;
                if (count > 0) Console.Write(firstArray[i] + " ");
            }
        }
    }
}
