using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter customer type");
            string customerType = Console.ReadLine().ToUpper();

           // Customer c;
            //if (customerType == "SILVER")
            //{
            //    c = new SilverCustomer();
            //}
            //else if (customerType == "GOLD")
            //{
            //    c = new GoldCustomer();
            //}
            //else 
            //{
            //    c = new Customer();
            //}

            Customer c = CustomerFactory.GetInstance(customerType);

            c.Print();

            



            Console.ReadLine();


        }
    }
}
