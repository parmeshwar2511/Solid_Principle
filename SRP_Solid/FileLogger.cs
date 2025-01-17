using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Solid
{
    public  class FileLogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"Logs/errors.txt", $"{message}\n");
        }
    }
}
