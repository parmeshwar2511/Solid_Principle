using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class FileLoger 
    {
        public void Log(string message)
        {
            File.AppendAllText(@"Logs/Error.txt", $"{message}\n");

        }
    }
}
