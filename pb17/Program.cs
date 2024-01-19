using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(ConversionToLaterBase(b, n));
        }

        private static string ConversionToLaterBase(int laterBase, double num)
        {
            int integerValue = (int)num;
            string result = "";

            while (integerValue > 0)
            {
                result = DigitToChar(integerValue % laterBase) + result;
                integerValue /= laterBase;
            }

            double fractionalPart = num - (int)num;
            if (fractionalPart > 0)
            {
                result += ".";

                for (int i = 0; fractionalPart > 0 && i < 10; i++)
                {
                    fractionalPart *= laterBase;
                    int digit = (int)fractionalPart;
                    result += digit.ToString();
                    fractionalPart -= digit;
                }
            }
            return result;
        }

        private static char DigitToChar(int digit)
        {
            if (digit < 10)
            {
                return (char)(digit + '0');
            }
            else
            {
                return (char)(digit - 10 + 'A');
            }
        }
    }
}
