using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Singlieton_Design_Pattern
{
     public  class DatabaseConnection
    {
        private int _counter;

        //public  DatabaseConnection()
        //{
        //    _counter = 0;
        //}

        private static DatabaseConnection _connection = null;
        private static object _obj = new object();
        private DatabaseConnection()
        {
            _counter = 0;
        }
        public static DatabaseConnection GetInstance
        {
            get
            {
                if (_connection == null)  // to improve performance
                {
                    lock (_obj)  // multithreading application
                    {
                        if (_connection == null)
                        {
                            _connection = new DatabaseConnection();
                        }

                        return _connection;
                    }
                }
                return _connection;
            }
        }
            
        public int GetNumber()
        { 
            return _counter++;
        }
    }
}
