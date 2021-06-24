using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Base.Interface
{
    /// <summary>
    /// ILogger Interface Helping you to define the bugs and select where when and how bugs come 
    /// you can fund the .Log file in CurrentDirectory
    /// </summary>
    public interface ILogger
    {
        
        /// <summary>
        /// Display a Debug message
        /// </summary>
        /// <param name="text">Message</param>
        public Task Debug(string text);

        /// <summary>
        /// Display a TRACE message
        /// </summary>
        /// <param name="text">Message</param>
        public Task Trace(string text);

        /// <summary>
        /// Display an INFO message
        /// </summary>
        /// <param name="text">Message</param>
        public Task Info(string text);

        /// <summary>
        /// Display a WARNING message
        /// </summary>
        /// <param name="text">Message</param>
        public Task Warning(string text);

        /// <summary>
        /// Display an ERROR message
        /// </summary>
        /// <param name="text">Message</param>
        public Task Error(string text);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task Initialization();

        /// <summary>
        /// using the functaion to write message incoming to log file
        /// </summary>
        /// <param name="text"></param>
        /// /// <param name="append"></param>
        public Task LoggerWriter(string text,bool append);
    }
}
