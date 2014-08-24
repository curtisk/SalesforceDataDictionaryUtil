using System;
using System.IO;

namespace SalesforceDataDictionaryUtil.Classes
{
    class Log
    {
        public void WriteToErrorLog(string s)
        {
            //drops log file in directory that exe is running from
            StreamWriter writer = new System.IO.StreamWriter("log.txt", true); 
            writer.Write("*****LogEntry: " + DateTime.Now + "|" + s + Environment.NewLine); 
            writer.Close(); 
            writer.Dispose(); 
        }
    }
}
