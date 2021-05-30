using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Logging
{
    public interface ILog
    {
        void Error(string message);
    }
}
