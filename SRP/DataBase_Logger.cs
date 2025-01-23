using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public  class DataBase_Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Message Logged to database");
        }
    }
}
