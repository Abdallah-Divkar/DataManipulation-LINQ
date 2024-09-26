using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdallah_Divkar_Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            string[] stringArray = { "Abdallah", "Mohammad", "Ahmad", "Ibrahim", "Jonah" };

            Console.WriteLine($"3: {SearchArray(intArray, 3)}");
            Console.WriteLine($"8: {SearchArray(intArray, 8)}");

            Console.WriteLine($"Ibrahim: {SearchArray(stringArray, "Ibrahim")}");
            Console.WriteLine($"Apple: {SearchArray(stringArray, "apple")}");
        }

        private static string SearchArray<T>(T[] inputArray, T item)
        {
            foreach(T element in inputArray)
            {
                if (element.Equals(item))
                {
                    return "Element Found";   
                }
            }
            return "Element not Found";
        }
    }
}
