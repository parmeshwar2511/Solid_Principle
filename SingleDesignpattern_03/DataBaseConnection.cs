using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignpattern_03
{
    public  class DataBaseConnection
    {

        private int _counter;


        //public DataBaseConnection()
        //{
        //    _counter = 0;
        //}

        private static DataBaseConnection _connection = null;
        private static object _obj = new object();   
        private DataBaseConnection()
        { 
          _counter = 0;

        }

        public static DataBaseConnection GetInstance
        {
            get
            
            {
                if(_connection == null)
                {
                    lock (_obj)
                    {
                        if (_connection == null)
                        {
                            _connection = new DataBaseConnection();
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
