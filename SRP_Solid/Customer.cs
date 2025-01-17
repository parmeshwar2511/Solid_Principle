using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Solid
{
   public abstract class Customer
   {
        // public string CustomerType { get; set; }
        //  public void Insert()
        // {

        //      try
        //      {
        //          int a = 10; int b = 0;
        //          int c = a / b ;

        //          // ado.net code / ef to Insert Customer To Database
        //      }
        //      catch (Exception ex)
        //      {
        //          //File.AppendAllText(@"Logs/errors.txt", $"{ex.Message}\n");

        //          FileLogger Logger = new FileLogger();
        //          Logger.Log(ex.Message);
        //      }
        //}


        //  public void Update()
        //  {

        //      try
        //      {
        //          int a = 10; int b = 0;
        //          int c = a / b;

        //          // ado.net code / ef to Insert Customer To Database
        //      }
        //      catch (Exception ex)
        //      {
        //          File.AppendAllText(@"Logs/errors.txt", $"{ex.Message}\n");
        //      }
        //  }


       // public abstract int GetTicketAmount();

        public void ShowsTimings()
        {
            Console.WriteLine("*** All Todays Show ***");
        }

        //public abstract void PrintTicket();
        
    }

    public  interface ICustomer
    {

         int GetTicketAmount();
         void PrintTicket();
    }
    public interface ICustomerV1 : ICustomer
    {
        void FreeFood();
    }

    public class SilverCustomer : Customer, ICustomer
    
    {
        public  int GetTicketAmount()
        {
            return 100;
        }

        public void PrintTicket()
        {
            Console.WriteLine("Silver Ticket Printed ..");
        }
    }
    public class GoldCustomer : Customer, ICustomer
    {
        public  int GetTicketAmount()
        {
            return 200;
        }

        public  void PrintTicket()
        {
            Console.WriteLine("Gold Ticket Printed ..");
        }
    }

    public class platinumCustomer : Customer, ICustomer
    {
        public  int GetTicketAmount()
        {
            return 500;
        }

        public  void PrintTicket()
        {
            Console.WriteLine("Platinum Ticket Printed");
        }
    }

    public class Enquiry : Customer
    {
        //public override int GetTicketAmount()
        //{
        //    throw new NotImplementedException();
        //}

        //public override void PrintTicket()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class VIPCustomer : Customer, ICustomerV1
    {
        public void FreeFood()
        {
           Console.WriteLine("Free Food Delivered At Seat");
        }

        public int GetTicketAmount()
        {
            return 1000;
        }

        public void PrintTicket()
        {
            Console.WriteLine("VIP Customer Ticket Printed...");
        }
    }
}
