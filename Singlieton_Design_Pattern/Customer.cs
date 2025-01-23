using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlieton_Design_Pattern
{
    public  class Customer
    {
        private static Customer _customer;
        private static int _counter = 1;

        private  Customer() 
        {
        }

        public static Customer GetCustomer
        {
            get
            {
                if (_counter <= 3)
                {
                    _customer = new Customer();
                    _counter++;
                    return _customer;
                }
                else
                {
                    throw new Exception(" only 3 object are allowed.4th object is not possible..");
                }
            }
        }
        
    }
}
