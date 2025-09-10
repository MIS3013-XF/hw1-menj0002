// HW1a Sales Total

// Your Name: Rita Menja
// Did you seek help ? If yes, specify the helper or web link here: Pooja

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string product = Console.ReadLine();
            Console.WriteLine("How many Football Ticket's do you want to buy?");
            string quantity = Console.ReadLine();
            Console.WriteLine("What is the price for each Football Ticket");
            string price = Console.ReadLine();

           double Price =  Convert.ToDouble(price);
           double Quantity = Convert.ToDouble(quantity);

        
           double subtotal = Price * Quantity;


            const double salestax = 0.085;
            double tax = salestax * subtotal;
            double total = tax + subtotal;

            Console.WriteLine("Subtotal---" + subtotal);

            Console.WriteLine("Sales Tax---" + tax);

            Console.WriteLine("Total---" + total);

            Console.ReadKey();


        }
    }
}
