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
        public Src.Services.FileService FS{ get; set; }


        public LoggingService(string path = "")
        {
            path = string.IsNullOrEmpty(path) ? $@"%TEMP%\{DateTime.Now:d}_logging.log" : path;
            FS = new FileService(path);
            
        }

        public void LogError(Exception ex)
        {
            FS.AppendFile(String.Format("{0} : {1} : {2}", "Error", DateTime.Now.ToString(), ex.ToString()));
        }

        public void LogWarning(string message)
        {
            FS.AppendFile(String.Format("{0} : {1} : {2}", "Warning", DateTime.Now.ToString(), message));
        }

        public void LogInfo(string message)
        {
            FS.AppendFile(String.Format("{0} : {1} : {2}", "Info", DateTime.Now.ToString(), message));
        }

        
    }
}
