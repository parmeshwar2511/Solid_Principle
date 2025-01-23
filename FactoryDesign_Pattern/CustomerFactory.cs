using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign_Pattern
{
    public  class CustomerFactory
    {

        static Dictionary<string, Customer> _customers;

        static CustomerFactory()
        {
            _customers = new Dictionary<string, Customer>();
            _customers.Add("SILVER", new SilverCustomer());
            _customers.Add("GOLD", new GoldCustomer());
            _customers.Add("PLATINUM", new GoldCustomer());
        }
        public static Customer GetInstance(string customerType)
        {
            #region way1
            //if (customerType == "SILVER")
            //{
            //    return new SilverCustomer();
            //}
            //else if (customerType == "GOLD")
            //{
            //    return new GoldCustomer();
            //}
            //else if (customerType == "PLATINUM")
            //{
            //    return new PlatinumCustomer();
            //}
            //else
            //{
            //    return new Customer();
            //}

            #endregion way1

            #region wey 2

            //switch (customerType)
            //{
            //    case "SILVER":
            //        return new SilverCustomer();
            //    case "Gold":
            //        return new GoldCustomer();
            //    case "PLATINUM":
            //        return new PlatinumCustomer();
            //    default:
            //        return new Customer();
            //}
            #endregion wey 2

            #region way 3

            if (_customers.ContainsKey(customerType))
            {
                return _customers[customerType];
            }
            else 
            {
                return new Customer();
            }

            #endregion way 3

        }

    }
}
