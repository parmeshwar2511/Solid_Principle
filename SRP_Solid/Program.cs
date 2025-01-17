using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Solid
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start Here..! ");

            Console.WriteLine("Enter Customer Type");
            string customerType = Console.ReadLine().ToUpper();

            Customer c = null;
            if (customerType == "SILVER")
            {
                c = new SilverCustomer();
            }
            else if(customerType == "GOLD")
            {
                c = new GoldCustomer();
            }
            else if (customerType == "PLATINUM")
            {
                c = new platinumCustomer();
            }
            else if (customerType == "ENQUIRY")
            {
                c = new Enquiry();
            }
            if (c != null)
            {
                c.ShowsTimings();
                //c.PrintTicket();
            }
            else 
            {
                Console.WriteLine("INVALID CUSTOMER");
            }

           // ICustomer c2 = new Enquiry();  // error

            Console.WriteLine("Program Ends Here..! ");
            Console.ReadLine();
        }
    }
}
