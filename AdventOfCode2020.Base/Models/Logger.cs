using AdventOfCode2020.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Models
{
    /// <summary>
    /// Logger Class inhirt from inferface ILogger To using to Display many type of exeptions
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// the Enum Determiine the nature of each of log
        /// </summary>
        #region LogType Enum
        public enum LogType {
            ///<summary>Log Debug</summary>
            DEBUG = 0,
            ///<summary>Log Trace</summary>
            TRACE = 1,
            ///<summary>Log Inforamtions</summary>
            INFO = 2,
            ///<summary>Log Warning</summary>
            WARNING = 3,
            ///<summary>Log Error</summary>
            ERROR = 4 };
        #endregion
        #region Private Area
        //lOG_FILE_NAME for select the File Name we coming to Select the name by which Assembly Running 
        private protected string lOG_FILE_NAME = "";

        //lOG_DATE_TIME_FORMA for select the DataPattren
        private protected string lOG_DATE_TIME_FORMA = "yyyy-MM-dd HH:mm:ss.fff";

        //lOG_FILE_TYPE for select the Type of File
        private const string lOG_FILE_TYPE = ".LOG";

        //LOG_TO_WRITE we using in switch it well hold DateTime And Log Type 
        string LOG_TO_WRITE ="";
        #endregion Private Area

        /// <summary>
        /// log when Debuging 
        /// </summary>
        /// <param name="text"></param>
        public async Task Debug(string text)
        {
             await WriteLogByType(LogType.DEBUG, text);
        }
        /// <summary>
        /// log when Error 
        /// </summary>
        /// <param name="text"></param>
        public async Task Error(string text)
        {
            await WriteLogByType(LogType.ERROR, text);
        }
        /// <summary>
        /// log when Inforamtions 
        /// </summary>
        /// <param name="text"></param>
        public async Task Info(string text)
        {
            await WriteLogByType(LogType.INFO, text);
        }
        /// <summary>
        /// log when BugTracker 
        /// </summary>
        /// <param name="text"></param>
        public async Task Trace(string text)
        {
            await WriteLogByType(LogType.TRACE, text);
        }
        /// <summary>
        /// log when Display warning 
        /// </summary>
        /// <param name="text"></param>
        public async Task Warning(string text)
        {
            await WriteLogByType(LogType.WARNING, text);
        }

        /// <summary>
        /// using the functaion to write message incoming to log file
        /// </summary>
        /// <param name="text"></param>
        /// <param name="Invoke"></param>
        public async Task LoggerWriter(string text,bool Invoke=false)
        {
            await Task.Run(() =>
            {
                try
                {
                    if (string.IsNullOrEmpty(text)) return; 

                    using System.IO.StreamWriter OsW = new System.IO.StreamWriter(lOG_FILE_NAME, Invoke, System.Text.Encoding.UTF8);
                    OsW.WriteLine(text);
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            });
            
        }

        /// <summary>
        /// Initialization AsyncTask Call in Constractor to init and fill all fild och prop  
        /// </summary>
        /// <returns></returns>
        public async Task Initialization()
        {
            //Given Name to log File as the Assemly as Running now + the Type of log
            lOG_FILE_NAME = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + $"{lOG_FILE_TYPE}";
            // First Line in Log File We be Header  
            string LOG_HEADER = lOG_FILE_NAME + "Initializaed";

            //Check If the log File Exists if Not Creata
            if (!System.IO.File.Exists(lOG_FILE_NAME))
            {
               await LoggerWriter(System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " " + LOG_HEADER);
            }
        }

        /// <summary>
        /// Default Constractor 
        /// </summary>
        public Logger()
        {
           Task.WaitAll(Initialization());  
        }

        /// <summary>
        /// Functaion to Take all log info and analyze it
        /// </summary>
        /// <param name="level"> select wich type or level the Log</param>
        /// <param name="text"> massage to writeing in log file </param>
        public async Task WriteLogByType(LogType level, string text)
        {
            //Switch To select What the log type and what Name && When happend
            LOG_TO_WRITE = level switch
            {
                LogType.DEBUG => System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---DEBUG---  ",
                LogType.TRACE => System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---TRACE---   ",
                LogType.INFO => System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---INFO---    ",
                LogType.WARNING => System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---WARNING--- ",
                LogType.ERROR => System.DateTime.Now.ToString(lOG_DATE_TIME_FORMA) + " ---ERROR---   ",
                _ => "",
            };
            await  LoggerWriter($"{LOG_TO_WRITE}\n{text}",true);
        }
    }
}
