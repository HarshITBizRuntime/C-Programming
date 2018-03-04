using System;
using System.Threading;
using System.Threading.Tasks;

namespace Programming
{
    /* Synchronization In C# */

    class SynchronizationDemo
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Async_AwaitDemo));
        
		/// <summary>
        /// Synchronization In C#
        /// </summary>
        
		public void PrintNumber()
        {
            lock(this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                   log.Info(i + ",");
                }
            }
        }
        /// <summary>
        ///  here creating a thread and running start method 
        /// </summary>
        
		public static void ThreadCreationandRun()
        {
            SynchronizationDemo sd = new SynchronizationDemo();
        
			Thread thread1 = new Thread(new ThreadStart(sd.PrintNumber));
            Thread thread2 = new Thread(new ThreadStart(sd.PrintNumber));
            
			thread1.Start();
            thread2.Start();
        }
    }
    class Async_AwaitDemo
    {
        /// <summary>
        ///  Demotration of Async_Await keyword
        /// </summary>
        
        /*  Async and Await using return type Void */

        public static void AsyncAwaitUsingVoid()
        {
            Async_AwaitDemo.Calculation(100 ,1);
            Thread.Sleep(2000);
            Console.WriteLine("Program Exiting");
        }
        public static async void Calculation(int n1, int n2)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Async_AwaitDemo));

            int sum = await Task.Run(() => GetSum(n1,n2)); // lamda
            log.Info("Value: {0}" +  sum);
        }

        private static int GetSum(int n1, int n2)
        {
            return n1 + n2;
        }

        /*  Async and Await using return type Task */

        public static async Task Demo3()
        {
           log4net.ILog log = log4net.LogManager.GetLogger(typeof(Async_AwaitDemo));
            
           await Demo4();
           
		   log.Info("Today is {DateTime.Now:D}");
           log.Info("The current time is {DateTime.Now.TimeOfDay:t}");
           log.Info("The current temperature is 76 degrees.");
        }

        public static async Task Demo4()
        {
           log4net.ILog log = log4net.LogManager.GetLogger(typeof(Async_AwaitDemo));
           await Task.Delay(5000);
           log.Info("\nSorry for the delay. . . .\n");
        }

        public static void AsyncAwaitUsingTask()
        {
           log4net.ILog log = log4net.LogManager.GetLogger(typeof(Async_AwaitDemo));
           log.Info(" Progrma Excetion Start AsyncAwaitUsingTask()  \n");
           Demo3().Wait();
        }

        /*  Async and Await using return type Task<T> Generics */
       
        public static async void Demo5()
        {
           log4net.ILog log = log4net.LogManager.GetLogger(typeof(Async_AwaitDemo));
           int value = await Demo6();
           log.Info("the output of method 2 is :-> " + value);
        }

        public static Task<int> Demo6() // here awaits returns Task<G> Generics
        {
            return Task.Run(() =>  
            {
                Thread.Sleep(5000); 
                return 1;
            });
        }

        public static void AsyncAwaitUsingTaskGenerics()
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Async_AwaitDemo));

            log.Info(" Progrma Excetion Start  AsyncAwaitUsingTaskGenerics() \n");
            Demo5();
            for (int i = 0; i < 5; i++)
            {
               log.Info("For Loop : ->" + i);
            }
        }
       
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();

            SynchronizationDemo.ThreadCreationandRun();// calling via class name 
            AsyncAwaitUsingVoid();
            AsyncAwaitUsingTask();
            AsyncAwaitUsingTaskGenerics();

            Console.ReadKey();
        }
    }
}
