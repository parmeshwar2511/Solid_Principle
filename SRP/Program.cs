using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Starts Here");

            Console.WriteLine("Enter Customer Type");
            string CustomerType = Console.ReadLine().ToUpper();

            Customer c = null;
            if (CustomerType == "SILVER")
            {
                c = new SilverCustomer();
            }
            else if(CustomerType == "GOLD")
            {
                c = new GoldCustomer();
            }

            else if (CustomerType == "PLATINUM")
            {
                c = new PlatinumCustomer();
            }

            else if (CustomerType == "ENQUIRY")
            {
                c = new Enquiry();
            }

            if (c != null)
            {
                c.ShowsTiming();
                c.printTicket();
            }
            else
            {
                Console.WriteLine("Invalid Customer");
            }

       



            Console.WriteLine("Programs Ends Here.. ");
            Console.ReadLine();
        }
    }
}
