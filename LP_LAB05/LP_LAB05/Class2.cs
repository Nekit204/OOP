using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LP_LAB05
{
    class Log
    {
        int count = 0;
      
        public void WriteInFileLogger(Exception ex)
        {
            try
            {
                count++;
                if (count == 1)
                {
                    FileStream fs = new FileStream("log.txt", FileMode.Create);
                    string fulltext = string.Format("[{0:dd.mm.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n", DateTime.Now, ex.StackTrace, ex.TargetSite.Name, ex.Message);
                    StreamWriter w = new StreamWriter(fs, Encoding.Default);
                    w.Write("________________________________________________________________________\n");
                    w.Write(fulltext + "\n");
                    w.Write("________________________________________________________________________\n");
                    w.Close();
                }
                else
                {
                    FileStream fs = new FileStream("log.txt", FileMode.Append);
                    string fulltext = string.Format("[{0:dd.mm.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n", DateTime.Now, ex.StackTrace, ex.TargetSite.Name, ex.Message);
                    StreamWriter w = new StreamWriter(fs, Encoding.Default);
                    w.Write("________________________________________________________________________\n");
                    w.Write(fulltext + "\n");
                    w.Write("________________________________________________________________________\n");
                    w.Close();
                }
            }
            catch
            {

            }
        }
        public void WriteInConsoleLogger(Exception ex)
        {
            try
            {
                
                string fulltext = string.Format("[{0:dd.mm.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n", DateTime.Now, ex.TargetSite.DeclaringType, ex.TargetSite.Name, ex.Message);
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine(fulltext);
               Console.WriteLine("________________________________________________________________________");
            }
            catch
            {

            }
        }
    }
}
