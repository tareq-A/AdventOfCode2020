using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Base.Interface
{
    public interface ILogger
    {
        
        /// <summary>
        /// Display a Debug message
        /// </summary>
        /// <param name="text">Message</param>
        public void Debug(string text);

        /// <summary>
        /// Display a TRACE message
        /// </summary>
        /// <param name="text">Message</param>
        public void Trace(string text);

        /// <summary>
        /// Display an INFO message
        /// </summary>
        /// <param name="text">Message</param>
        public void Info(string text);

        /// <summary>
        /// Display a WARNING message
        /// </summary>
        /// <param name="text">Message</param>
        public void Warning(string text);

        /// <summary>
        /// Display an ERROR message
        /// </summary>
        /// <param name="text">Message</param>
        public void Error(string text);

        /// <summary>
        /// using the functaion to write message incoming to log file
        /// </summary>
        /// <param name="text"></param>
        public void LoggerWriter(string text,bool append);
    }
}
