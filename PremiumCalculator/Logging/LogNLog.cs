using NLog;

namespace PremiumCalculator.Logging
{
    public class LogNLog :ILog
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public void Error(string message)
        {
            logger.Error(message);
        }
    }
}
