using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start Here...");
            Customer c = new Customer();
            c.Insert();

            Console.WriteLine("Program Ends Here...");

            Console.ReadLine();
        }
    }
}
