using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdallah_Divkar_Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stocks = new List<string>
            {
                "AAPL",
                "AMZN",
                "HD",
                "GE",
                "DIS",
                "NKE",
                "BA",
                "SBUX",
                "TSLA",
                "GOOG"
            };

            //Search a stock and return message
            string searchStock = "MSFT";
            bool stockFound = stocks.Contains(searchStock);
            Console.WriteLine(stockFound ? $"Value found: {searchStock}" : $"Value not found: {searchStock}\n");

            //Sort values
            stocks.Sort();
            Console.WriteLine("Sorted values: ");
            int counter = 1;
            foreach ( var stock in stocks ) 
            {
                Console.WriteLine($"{counter}: {stock}");
                counter++;
            }
            Console.WriteLine();

            //Insert a value
            stocks.Add("NFLX");
            Console.WriteLine("Stock values after insertion: ");
            counter = 1;
            foreach (var stock in stocks)
            {
                Console.WriteLine($"{counter}: {stock}");
                counter++;
            }
            Console.WriteLine();

            //Removing a value
            stocks.Remove("GE");
            Console.WriteLine("Stock values after removing a stock: ");
            counter = 1;
            foreach (var stock in stocks)
            {
                Console.WriteLine($"{counter}: {stock}");
                counter++;
            }
            Console.WriteLine();


        }
    }
}
