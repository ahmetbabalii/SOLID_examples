using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.solving.ex
{
    public class CustomerLockedException : Exception
    {
        public CustomerLockedException(string message) : base(message)
        {

        }
    }
}
