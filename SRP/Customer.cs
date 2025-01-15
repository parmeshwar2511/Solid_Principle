using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    // it Will deal with all Customer Operations
    public abstract class Customer
    {
        //  public string CustomerType { get; set; }


        // three types of work
        // 1. Inserting Customer to Db
        // 2. checking for Exception
        // 3. logging exception message  to text file 
        //public void Insert()
        //{

        //    try
        //    {
        //        int a = 10, b = 0;
        //        int c = a / b;
        //        // ado.net code / ef to insert customer to database
        //    }
        //    catch (Exception ex)
        //    {
        //        //  File.AppendAllText(@"Logs/errors.txt", $"{ex.Message}\n");
        //        fileLogger logger = new fileLogger();
        //        logger.Log(ex.Message);
        //    }
        //}

        //public void Update()
        //{

        //    try
        //    {
        //        int a = 10, b = 0;
        //        int c = a / b;
        //        // ado.net code / ef to insert customer to database
        //    }
        //    catch (Exception ex)
        //    {
        //        File.AppendAllText(@"Logs/errors.txt", $"{ex.Message}\n");
        //    }
        //}

        public abstract int GetTicketAmount();

        public void ShowsTiming()
        {
            Console.WriteLine("*** All TODAYS Show ***");
        }
        public abstract void printTicket();
        
    }
    public class SilverCustomer : Customer
    {
        public override int GetTicketAmount()
        {
            return 100;
        }

        public override void printTicket()
        {
           Console.WriteLine("Silver ticket printed");
        }
    }

    public class GoldCustomer : Customer
    {
        public override int GetTicketAmount()
        {
             return 200;
        }

        public override void printTicket()
        {
            Console.WriteLine("Gold Ticket Printed");
        }
    }




}

