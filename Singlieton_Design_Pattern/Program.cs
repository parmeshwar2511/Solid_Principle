using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlieton_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region singleton class object
            ////  DatabaseConnection db1 = new DatabaseConnection();
            //DatabaseConnection db1 = DatabaseConnection.GetInstance;
            //int counter = db1.GetNumber();
            //Console.WriteLine($"value : {counter}");  // 0

            //counter = db1.GetNumber();
            //Console.WriteLine($"Value : {counter}");   // 1

            //// DatabaseConnection db2 = new DatabaseConnection();
            //DatabaseConnection db2 =  DatabaseConnection.GetInstance;
            //counter = db2 .GetNumber();
            //Console.WriteLine($"value : {counter}");    // 0

            //DatabaseConnection db3 =  DatabaseConnection.GetInstance;
            //counter = db3.GetNumber();
            //Console.WriteLine($"Value : {counter}");

            #endregion singleton class object

            Customer c1 = Customer.GetCustomer;
            Customer c2 = Customer.GetCustomer;
            Customer C3 = Customer.GetCustomer;

            Customer c4 = Customer.GetCustomer;


            Console.ReadLine();
           
        }
    }
}
