using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;

namespace Models.ChainOfResposibility
{
    public abstract class Logger
    {
        protected LogLevelEnum _level { get; set; }
        protected Logger next { get; set; }

        protected Logger(LogLevelEnum level)
        {
            _level = level;
        }
        //set the next logger 
        public void SetNextLogger(Logger next) 
        {
            //set the property to next
            this.next = next;
        }

        protected abstract void Write(string message);

        //handle request 
        public void LogMessage(LogLevelEnum logLevel , string message)
        {
            if (this._level <= logLevel)
            {
                Write(message);
            }
            if (next != null)
            {
                next.LogMessage(logLevel , message);
            }
        }


    }

    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevelEnum level) : base(level)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"[ConsoleLogger] {message}");
        }
    }

    public class FileLogger : Logger
    {
        public FileLogger(LogLevelEnum level) : base(level) { }

        protected override void Write(string message)
        {
            Console.WriteLine($"[FileLogger] Writing to log file: {message}");
        }
    }

    public class EmailLogger : Logger
    {
        public EmailLogger(LogLevelEnum level) : base(level)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"[EmailLogger] Sending email: {message}");
        }
    }
}
