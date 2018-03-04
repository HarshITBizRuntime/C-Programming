using System;

namespace Programming
{
    /* Delegates */

    class TestDelegte
    {
        /* MultiCast Deleate */

        /// <summary>
        /// log4net configuration
        /// </summary>

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Delegate_Eventes));

        public void Add(int a, int b) // Creating and define Delegates with parameters and no return type.
        {
            log.Info("value of s:->" + (a + b));
        }

        public void sub(int a, int b)
        {
            log.Info("value of s:->" + (a - b));
        }

        public void mul(int a, int b)
        {
            log.Info("value of s:->" + (a * b));
        }

        public void div(int a, int b)
        {
            log.Info("value of s:->" + (a / b));
        }

        public string  Display1(string str)
        {
           log.Info(" value of s is:->" + str);
            return str;
        }

         /* Events */

        public delegate void DgOddNumber(); //Declared Delegate     

        public event DgOddNumber EvtOddnumber; //Declared Events is called Publisher

        public event DgOddNumber EvtEvennumber; //Declared Events is called Publisher

        public void Add()
        {
            int result = 5 + 5;

            log.Info(result.ToString());

            if ((result % 2 != 0) && (EvtOddnumber != null)) //Check if result is odd number then raise event

                EvtOddnumber(); //Raised Event

            else

                EvtEvennumber();
        }
    }
	class EventDemo
    {
        public delegate string MyDel(string str); // Define Delegate 
    
		public MyDel MyEvent; // Declare Event with Delegate

        public EventDemo() // Constructor
        {
            this.MyEvent += new MyDel(this.WelcomeClient);
        }
        
		public string WelcomeClient(string username)
        {
            return "Welcome " + username;
        }
    }
    /// <summary>
        /// <code>
            ///  public delegate void AnonymousFunDemo(); // Anonymous mehod Demostration ();  
            ///  public delegate void mydelegate2(int a, int b); // creating and define Delegates with parameters and return type
            ///  public delegate string mydelegate3(string s); // creating and define Delegates with parameters and return type
        /// </code>
    /// </summary>

    public delegate void AnonymousFunDemo(); // Anonymous mehod Demostration ();  

    public delegate void mydelegate2(int a, int b); // creating and define Delegates with parameters and return type

    public delegate string  mydelegate3(string s); // creating and define Delegates with parameters and return type

    class Delegate_Eventes
    {
        /* Single Cast Deleate */
        
        /// <summary>
        ///     using lamda Expression
        /// </summary>
        /// <param name="str">  it is used to store the string value</param>

        public static void Display(string str) => Console.WriteLine(" value of s is:->" + str); // Define using Lamda Expression

        /* Creating and define Delegates with parameters and no return type. */

        /// <summary>
        /// /creating and define  the delegate
        /// </summary>
        /// <param name="a"> store the string value</param>

        delegate void MyDelegate(string a);

        /// <summary>
        /// Delegates calls this method when event raised. 
        /// </summary>

        static void EventMessage1()         
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Delegate_Eventes));

            log.Info("Event Executed : This is Odd Number");
        }

        /// <summary
        /// Delegates calls this method when event raised.  
        /// </summary>

        static void EventMessage2()        
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Delegate_Eventes));
            log.Info("Event Executed : This is Eevn Number");
        }

        static void Main(string[] args)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Delegate_Eventes));
            log4net.Config.BasicConfigurator.Configure();

            /* Delegates */

			MyDelegate md = new MyDelegate(Display); //instanstiated delegate

			/* Calling Static Functions */

			md("hie"); // invoking the delehgate by 1st way

			//md.Invoke("hie");// invoking the delehgate 2nd way

			/* Anonymous Method () or Function ()  */

            AnonymousFunDemo amsfundemo = delegate ()
            {
                log.Info("this is Anonymous Method ");
            };
           amsfundemo(); // Define using Anonymous Demo

            /*  Delegates with parameters and return type (line 58)*/

            TestDelegte td = new TestDelegte();

            mydelegate2 md2 = new mydelegate2(td.Add); // instanstiated delegate

            md2 += td.sub;  // method called by Delegated
            md2 += td.mul;
            md2 += td.div;

            md2 (4, 2); // invoking the delehgate

            /*  Delegates with parameters and return type */

            mydelegate3 md3 = new mydelegate3(td.Display1); // instanstiated delegate
            string mds = md3.Invoke("Hello");
            log.Info(mds);

            /* Events */

            td.EvtOddnumber += new TestDelegte.DgOddNumber(EventMessage1);            //Event gets binded with delegates
            td.EvtEvennumber += new TestDelegte.DgOddNumber(EventMessage2);            //Event gets binded with delegates
         
			td.Add(); 

		    EventDemo ed = new EventDemo();
            string res = ed.MyEvent("to Home sweet Home");
            Console.WriteLine(res);

        Console.ReadKey();

        }
    }
}
