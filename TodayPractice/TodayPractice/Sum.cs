using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayPractice
{
    public class Sum
    {
        NLog nlog = new NLog();
        public void DoSum(int a, int b)
        {
          if(a==0 || b==0)
            {
                nlog.LogError("A and b valus 0");
            }
            else
            {
                int c = a + b;
                nlog.logDebug("The program Execute");
                nlog.InfoLog("the value added");
            }
        }
    }
}
