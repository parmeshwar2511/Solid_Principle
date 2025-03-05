using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public  class Customer
    {
        public virtual void print()
        {
            Console.WriteLine("CUSTOMER PRINT");
        }

    }

    public class SilverCustomer : Customer 
    {
      public override void print()
        {
            Console.WriteLine(" SILVER CUSTOMER PRINT");
        }
    }
    public class GoldCustomer : Customer
    {
        public override void print()
        {
            Console.WriteLine(" Gold CUSTOMER PRINT");
        }
    }

    public class PlatinumCustomer : Customer
    {
        public override void print()
        {
            Console.WriteLine(" Platinum CUSTOMER PRINT");
        }
    }
}
