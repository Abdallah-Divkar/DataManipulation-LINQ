using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdallah_Divkar_Ex_04
{
    internal class Program
    {
        public delegate bool IsOddDelegate(int num);
        public delegate string MaxDelegate(string str1, string str2, string str3);
        static void Main(string[] args)
        {
            //Instance of IsOddDelegate
            IsOddDelegate isOddDelegate = new IsOddDelegate(IsOdd);

            //Using deleagte to call method
            Console.WriteLine($"The number is odd: {isOddDelegate(3)}");
            Console.WriteLine($"The number is odd: {isOddDelegate(8)}");

            //Instance of MaxDelegtae
            MaxDelegate maxDelegate = new MaxDelegate(Max);

            //Using delegate to call method
            Console.WriteLine($"Largest string: {maxDelegate("five", "Abdallah", "two")}");
        }
        private static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        private static string Max(string str1, string str2, string str3)
        {
            if (str1.Length >= str2.Length && str1.Length >= str3.Length)
            {
                return str1;
            }
            else if(str2.Length >= str1.Length && str2.Length >= str3.Length)
            {
                return str2;
            }
            else
            {
                return str3;
            }
        }
    }
}
