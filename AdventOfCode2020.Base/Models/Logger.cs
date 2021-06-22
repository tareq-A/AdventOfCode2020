using AdventOfCode2020.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Base.Models
{

    public class Logger : ILogger
    {
        /// <summary>
        /// the Enum Determiine the nature of each of log
        /// </summary>
        public enum LogType { DEBUG, TRACE, INFO, WARNING, ERROR };

        #region Private Area
        //lOG_FILE_NAME for select the File Name we coming to Select the name by which Assembly Running 
        private readonly string lOG_FILE_NAME = "";

        //lOG_DATE_TIME_FORMA for select the DataPattren
        private readonly string lOG_DATE_TIME_FORMA = "yyyy-MM-dd HH:mm:ss.fff";

        //lOG_FILE_TYPE for select the Type of File
        private const string lOG_FILE_TYPE = ".LOG";

        //LOG_TO_WRITE we using in switch it well hold DateTime And Log Type 
        string LOG_TO_WRITE ="";
        #endregion Private Area

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public void Debug(string text)
        {
            WriteLogByType(LogType.DEBUG, text);
        }

        public void Error(string text)
        {
            WriteLogByType(LogType.ERROR, text);
        }

        public void Info(string text)
        {
            WriteLogByType(LogType.INFO, text);
        }

        public void Trace(string text)
        {
            WriteLogByType(LogType.TRACE, text);
        }

        public void Warning(string text)
        {
            WriteLogByType(LogType.WARNING, text);
        }

        /// <summary>
        /// using the functaion to write message incoming to log file
        /// </summary>
        /// <param name="text"></param>
        /// <param name="Invoke"></param>
        public void LoggerWriter(string text,bool Invoke=false)
        {
            try
            {
                if (string.IsNullOrEmpty(text))
                {
                    return;
                }
                using (System.IO.StreamWriter OsW = new System.IO.StreamWriter(lOG_FILE_NAME, Invoke, System.Text.Encoding.UTF8))
                {
                    OsW.WriteLine(text);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Default Constractor 
        /// </summary>
        public Logger()
        {
            //Given Name to log File as the Assemly as Running now + the Type of log
            lOG_FILE_NAME = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + $"{lOG_FILE_TYPE}";

            // First Line in Log File We be Header  
            string LOG_HEADER = lOG_FILE_NAME + "Initializaed";

            //Check If the log File Exists if Not Creata
            if (!System.IO.File.Exists(lOG_FILE_NAME))
            {
                LoggerWriter(System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " " + LOG_HEADER);
            }
        }

        /// <summary>
        /// Functaion to Take all log info and analyze it
        /// </summary>
        /// <param name="level"> using to select wich type or level the Log</param>
        /// <param name="text">using to push the massage to writeing in log file </param>
        private void WriteLogByType(LogType level, string text)
        {
            //Switch To select What the log type and what Name && When happend
            switch (level)
            {
                case LogType.DEBUG:
                    LOG_TO_WRITE = System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---DEBUG---  ";
                    break;
                case LogType.TRACE:
                    LOG_TO_WRITE = System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---TRACE---   ";
                    break;
                case LogType.INFO:
                    LOG_TO_WRITE = System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---INFO---    ";
                    break;
                case LogType.WARNING:
                    LOG_TO_WRITE = System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---WARNING--- ";
                    break;
                case LogType.ERROR:
                    LOG_TO_WRITE = System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---ERROR---   ";
                    break;
                default:
                    LOG_TO_WRITE = "";
                    break;
            }
        }
    }
}
