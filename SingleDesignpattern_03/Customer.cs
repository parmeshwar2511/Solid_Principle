using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignpattern_03
{
    public  class Customer
    {
        private static Customer _Customer;
        private static int _Counter = 1;

        private Customer()
        {
            
        }

        public static Customer GetCustomer
        {
            get 
            {
                if (_Counter <= 3)
                {
                    _Customer = new Customer();
                    _Counter++;
                    return _Customer;
                }
                else 
                {
                    throw new Exception("Only 3 object are Allowed.$th object is Not Allowed");
                }
            }
            
        
        }
    }
}
