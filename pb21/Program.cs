using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstArrayInput = Console.ReadLine();
            string secondArrayInput = Console.ReadLine();

            if (String.Compare(firstArrayInput, secondArrayInput) > 0)
                Console.WriteLine(secondArrayInput);
            else if (String.Compare(firstArrayInput, secondArrayInput) < 0)
                Console.WriteLine(firstArrayInput);
            else Console.WriteLine("They're the same");
                
        }
    }
}
