using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();
        static private List<string> logLines = new List<string>();
        static public void LogActivity(string activity)
        {
            string logLine = DateTime.Now + "[INFO] "
                + LoginValidation.username + ";"
                + LoginValidation.currentUserRole + ";"
                + activity + "\r\n";
            if (File.Exists("log.txt") == true)
            {
                File.AppendAllText("log.txt", logLine);
            }
            currentSessionActivities.Add(logLine);            
        }

        static public void LogVisualization()
        {
            StreamReader sr = new StreamReader("log.txt");
            while (sr.Peek() >= 0)
            {
                logLines.Add(sr.ReadLine());
            }
            sr.Close();
        }

        static public IEnumerable<string> GetLogVisualization()
        {
            return logLines;
        }

        static public IEnumerable<string> GetCurrentLogVisualization(string filter)
        {
            List<string> filteredActivities = (from activity in currentSessionActivities
                                               where activity.Contains(filter)
                                               select activity).ToList();
            return filteredActivities;
        }

        static public void LoginErrorLog(string errMessage)
        {
            string errorLogPattern = DateTime.Now + "[ERROR] " + "Login unsuccessful in " + errMessage + "\n";
            if (File.Exists("errorsLog.txt") == true)
            {
                File.AppendAllText("errorsLog.txt", errorLogPattern);
                return;
            }

            FileStream fs = File.Create("errorsLog.txt");
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(errMessage);
            sw.Close();
            fs.Close();
        }

        static public void LogCounter()
        {
            int counter = 0;
            StreamReader sr = new StreamReader("log.txt");

            while(sr.Peek() >= 0)
            {
                Console.WriteLine(sr.ReadLine());
                counter++;
            }
            sr.Close();

            Console.WriteLine("Logs number is: " + counter);
        }

        static public void showOldestLog()
        {
            StreamReader sr = new StreamReader("log.txt");
            string oldestLog = sr.ReadLine();
            sr.Close();

            Console.WriteLine("The oldest log is: " + oldestLog);
        }
    }
}