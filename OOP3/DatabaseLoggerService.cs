using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            // operations
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
