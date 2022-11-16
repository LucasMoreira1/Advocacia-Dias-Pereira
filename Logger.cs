using System.Configuration;
using System.IO;
using System;

namespace Advocacia_Dias_Pereira
{
    
    public static class Logger
    {
        

        public static void WriteLog(string path, string message, string nomeLogin)
        {
            //string logPath = ConfigurationManager.AppSettings["logPath"];
            
            
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now} | {nomeLogin} | {message}");
            }
        }
        
    }
}
