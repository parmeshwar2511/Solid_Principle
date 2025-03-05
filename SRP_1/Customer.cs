using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_1
{
    public  class Customer
    {
        public  void Insert()
        {
            try
            {
                int a = 10, b = 0;
                int c = a / b;
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"Logs/errors.txt", $"{ex.Message}");
   
            }
        
        }
    }
}
