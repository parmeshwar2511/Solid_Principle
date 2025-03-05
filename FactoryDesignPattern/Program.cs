using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter customer type");
            string customerType = Console.ReadLine().ToUpper();

            Customer c;
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

            Customer C = CustomerFactory.GetInstance(customerType);
            C.print();

            Console.ReadLine();
        }
    }
}
