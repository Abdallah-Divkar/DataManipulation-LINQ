using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdallah_Divkar_Ex_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialize list
            List<Invoice> invoices = new List<Invoice>()
            {
                new Invoice(87,"Electric Sander",7, 57.98M),
                new Invoice(87, "Power Saw", 18, 99.99M),
                new Invoice(87, "Sledge Hammer", 11, 21.50M),
                new Invoice(87, "Hammer", 76, 11.99M),
                new Invoice(87, "Lawn Mower", 3, 79.50M),
                new Invoice(87, "Screw Driver", 106, 6.99M),
                new Invoice(87, "Jig saw", 21, 11.00M),
            };

            //Display Part Description & Price
            Console.WriteLine("  Part Description |  Price");
            Console.WriteLine("----------------------------");
            foreach (Invoice invoice in invoices)
            {
                Console.WriteLine($" {invoice.PartDescription,-18}|{invoice.Price,6}");
            }
            Console.WriteLine();

            Console.WriteLine(" Part Number | Part Description | Quantity | Price");
            Console.WriteLine("--------------------------------------------------");
            foreach (Invoice invoice in invoices.OrderBy(i => i.PartNumber))
            {
                Console.WriteLine($"{invoice.PartNumber,-12} | {invoice.PartDescription,-16} |{invoice.Quantity,-10}|{invoice.Price,6}");
            }
            Console.WriteLine();

            Console.WriteLine($"The part that has the highest quantity: {invoices.OrderByDescending(i => i.Quantity).First().PartDescription}");
            
        }
    }
}