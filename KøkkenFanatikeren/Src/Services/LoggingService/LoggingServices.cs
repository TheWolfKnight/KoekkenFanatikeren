using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Services
{
    public class LoggingService
    {
        public void LogError(Exception ex)
        {
            Console.WriteLine(String.Format("{0} : {1} : {2}", "Fejl", DateTime.Now.ToString(), ex.ToString()));
        }

        public void LogWarning(string message)
        {
            Console.WriteLine(String.Format("{0} : {1} : {2}", "Warning", DateTime.Now.ToString(), message));

        }

        public void LogInfo(string message)
        {
            Console.WriteLine(String.Format("{0} : {1} : {2}", "Fejl", DateTime.Now.ToString(), message));
        }

        
    }
}
