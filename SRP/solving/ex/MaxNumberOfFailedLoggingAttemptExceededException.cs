using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.solving.ex
{

    public class MaxNumberOfFailedLoggingAttemptExceededException : Exception
    {
        public MaxNumberOfFailedLoggingAttemptExceededException(string message) : base(message)
        {            
        }
    }

}
