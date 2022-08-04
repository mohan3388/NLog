using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayPractice
{
    public class NLog
    {
      public static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void logDebug(string message)
        {
            logger.Debug(message);
        }
        public void LogError(string message)
        {
            logger.Error(message);
        }
        public void InfoLog(string message)
        {
            logger.Info(message);
        }
    }
    }
