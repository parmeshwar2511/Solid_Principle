using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignpattern_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SingletonClass object

            //// DataBaseConnection db1 = new DataBaseConnection();
            //DataBaseConnection db1 = DataBaseConnection.GetInstance;
            //int counter = db1.GetNumber();
            //Console.WriteLine($"Value : {counter}");

            //counter = db1.GetNumber();
            //Console.WriteLine($"Value : {counter}");

            ////DataBaseConnection db2 = new DataBaseConnection();
            //DataBaseConnection db2 = DataBaseConnection.GetInstance;
            //counter = db2.GetNumber();
            //Console.WriteLine($"Value : {counter}");

            //DataBaseConnection db3 = DataBaseConnection.GetInstance;
            //counter = db3.GetNumber();
            //Console.WriteLine($"Value : {counter}");

            #endregion SingletonClass object

            Customer C1 = Customer.GetCustomer;
            Customer C2 = Customer.GetCustomer;
            Customer C3 = Customer.GetCustomer;

            Customer C4 = Customer.GetCustomer;  // error 
            Console.ReadLine();

        }
    }
}
