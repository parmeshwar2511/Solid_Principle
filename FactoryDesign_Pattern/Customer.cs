using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign_Pattern
{
    public  class Customer
    {
        public virtual void Print()
        {
            Console.WriteLine("CUSTOMER PRINT");
        }
    }
    public class SilverCustomer  : Customer
    {
        public override void Print()
        {
            Console.WriteLine("SILVER CUSTOMER PRINT");
        }
    }

    public class GoldCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("GOLD CUSTOMER PRINT");
        }
    }
    public class PlatinumCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("PLATINUM CUSTOMER PRINT");
        }
    }

}
