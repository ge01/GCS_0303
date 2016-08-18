using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0303_081216
{
    class Program
    {
        static void Main(string[] args)
        {
            // Suppose a retail business is planning to have a storwide sale in which
            // the prices of all items will be reduced by a spedified percentage.
            // This program calculates the sale price of an item after the discount 
            // is subtracted

            // Get the item's original price.
            Console.Write("Enter the item's original price:");
            var originalPrice = decimal.Parse(Console.ReadLine());

            // Get the discount percentage.
            Console.Write("Enter the discount percentage: ");
            var discountPercentage = decimal.Parse(Console.ReadLine());

            // Move the percentage's decimal point left two spaces.
            discountPercentage = discountPercentage / 100;

            // Calculate the amount of the discount.
            var discountAmount = originalPrice * discountPercentage;

            // Calculate the sale price.
            var salePrice = originalPrice - discountAmount;

            // Display the sale price.
            Console.WriteLine("Sale price: " + salePrice);
            Console.ReadLine(); 
        }
    }
}
