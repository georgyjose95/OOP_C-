using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCL
{
    public static class LoggingServices
    {
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach(var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }

        }
    }
}
