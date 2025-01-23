
using System.IO;


namespace SRP_Solid
{
    // low level module
    public  class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"Logs/errors.txt", $"{message}\n");
            console.WriteLine("Message logger to database");
        }
    }
}
