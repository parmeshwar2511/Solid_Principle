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

            Customer c = new Customer();
            if (CustomerType == "SILVER")
            {
                c.Insert();
            }
            else
            {
                c.Insert();
            }


          




            Console.WriteLine("Programs Ends Here.. ");
            Console.ReadLine();
        }
    }
}
