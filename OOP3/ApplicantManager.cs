using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicantManager
    {
        // Method injection (dependency injection)
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            // operations
            // ...
            creditManager.Calculate();
            loggerService.Log();
        }

        public void CreditPreview(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
