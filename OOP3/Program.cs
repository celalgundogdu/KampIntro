using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // classlar ve interfaceler kendilerini implemente 
            // eden classların referanslarını tutabilir
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicantManager applicantManager = new ApplicantManager();
            applicantManager.Apply(homeCreditManager, databaseLoggerService);

            
            List<ICreditManager> credits = new List<ICreditManager>();
            credits.Add(consumerCreditManager);
            credits.Add(vehicleCreditManager);

            applicantManager.CreditPreview(credits);


            Console.Read();
        }
    }
}
