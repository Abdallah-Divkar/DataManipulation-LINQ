using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdallah_Divkar_Ex_01
{
    public class Invoice
    {
        private int quantity;
        private decimal price;
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0M) // check if price is non-negative
                {
                    price = value;
                }
            }
        }

        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartDescription = partDescription;
            PartNumber = partNumber;
            Quantity = quantity;
            Price = price;
        }
    }
}
