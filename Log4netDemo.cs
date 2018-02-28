using System;
using System.Threading;

namespace log4jnetDemostration
{
    ///<summary>
	///    this is demo of Log4net and  XML Documentation Comments in C# 
    /// </summary>   
    class Log4netDemo
    {
        ///<summary>
        ///     <log4net> Log4Net it port it popular Log4J fw.
        ///               Log4net is a tool to help the programmer output log statements to a variety of output targets
        ///     </log4net>
        /// </summary>
        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Log4netDemo));
            try
            {
                string str = String.Empty;
                string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        ///  <level>
        ///     log4net levels:
        ///             All – Log everything 
        ///             Debug
        ///             Info
        ///             Warn
        ///             Error  
        ///             Fatal 
        ///             Off – Don’t log anything
        /// </level>
        /// </summary>
        public static void ImplementedLoggin()
        {
            var secs = 5;
            log.Fatal("start log fatal");
            Console.WriteLine("start log fatal");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            log.Error("start log Error");
            Console.WriteLine("start log Error");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            log.Warn("start log Warn");
            Console.WriteLine("start log Warn");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            log.Info("start log info");
            Console.WriteLine("start log Info");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            log.Debug("start log Debug");
            Console.WriteLine("start log Debug");
            Thread.Sleep(TimeSpan.FromSeconds(secs));

            Console.WriteLine("press any key to close the application");

            Console.ReadKey();
        }
        /// <summary>
        /// <remarks> 
        ///         Do Not Send Your Logs to a Database Table with the AdoAppender
        ///         Do Not Send Emails on Every Exception
        ///         You Can Make Your Own Custom log4net Appenders
        /// </remarks>
        /// </summary>

        static void Main(string[] args)
        {
           Testing();
           ImplementedLoggin();
           Console.ReadKey();
        }

    }
}
