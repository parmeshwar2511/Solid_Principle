using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public  class CustomerFactory
    {
        static Dictionary<string, Customer> _Customer;

        static CustomerFactory()
        { 
          _Customer = new Dictionary<string, Customer>();
            _Customer.Add("SILVER", new SilverCustomer());
            _Customer.Add("GOLD", new GoldCustomer());
            _Customer.Add("PLATINUM", new PlatinumCustomer());
        }


        public static Customer GetInstance(string CustomerType)
        {
            #region Way
            //if (CustomerType == "SILVER")
            //{
            //    return   new SilverCustomer();
            //}
            //else if (CustomerType == "GOLD")
            //{
            //    return  new GoldCustomer();
            //}
            //else if (CustomerType == "PLATINUM")
            //{
            //    return new PlatinumCustomer();
            //}
            //else
            //{
            //    return new Customer();
            //}
            #endregion Way

            #region Way2
            //switch (CustomerType)
            //{
            //    case "SILVER":
            //         return new SilverCustomer();
            //    case "GOLD":
            //        return new GoldCustomer();
            //    case "PLATINUM":
            //        return new PlatinumCustomer();
            //    default:
            //        return new Customer();

            //}

            #endregion Way2

            #region Way 3
            if (_Customer.ContainsKey(CustomerType))
            {
                return _Customer[CustomerType];
            }
            else 
            {
              return new Customer();
            }

            #endregion Way 3
        }
    }
}
