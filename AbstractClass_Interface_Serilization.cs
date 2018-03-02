using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace log4jnetDemostration
{
    /* ABSTRACT Class*/

    /// <summary>
    ///  <c>AbstractParentDemo</c> this is abstract class
    /// </summary>
    /// <remarks>
    /// Abstract class ,Interfaces & serialization program using Log4net & XML Documentation Comments and unit testing 
    /// </remarks>

    public abstract class AbstractParentDemo
    {
        /// <summary>
        ///     this is double type nethod it is used to addition of two variable 
        /// </summary>
        /// <param name="x">it is used to hold the var value</param>
        /// <param name="y">it is used to hold the var value</param>
        /// <returns>
        ///     addition of x and y value 
        /// </returns>

        public double Addition(int x, int y)
        {
			// Console.WriteLine("Addition of " + x + " and " + y + " is :->" + (x + y));
            return x + y;
        }

        /// <summary>
        ///     this is double type Method it is used to substraction of two variable 
        /// </summary>
        /// <param name="x">it is used to hold the var value</param>
        /// <param name="y">it is used to hold the var value</param>
        /// <returns>
        ///     Substraction of x and y value 
        /// </returns>

        public double Subtraction(int x, int y)
        {
            Console.WriteLine("Subtraction of " + x + " and " + y + " is :->" + (x - y));
            return x - y;
        }
        
		/// <summary>
        ///     this is abstract double Method it is used to multiplication of two variable 
        /// </summary>
        /// <param name="x">it is used to hold the var value</param>
        /// <param name="y">it is used to hold the var value</param>
        /// <returns>
        ///     Multiplication value  of x and y value 
        /// </returns>

        public abstract double Multiplication(int x, int y); // no any implementation

        /// <summary>
        ///     this is abstract double method it is used to Division of two variable 
        /// </summary>
        /// <param name="x">it is used to hold the var value</param>
        /// <param name="y">it is used to hold the var value</param>
        /// <returns>
        ///     Division of x and y value 
        /// </returns>

        public abstract double Division(int x, int y);
    }
   
	/// <summary>
    /// <c> AbstractChildDemo </c> this Child class 
    /// <remarks > we have to compulsary implements parent class method </remarks>
    /// </summary>
    
	public class AbstractChildDemo : AbstractParentDemo // here we inherited Abstract class
    {
		/// <summary>
        ///     this is abstract double  Method it is used to multiplication of two variable 
        /// </summary>
        /// <param name="x">it is used to hold the var value</param>
        /// <param name="y">it is used to hold the var value</param>
        /// <returns>
        ///     Multiplication value  of x and y value 
        /// </returns>

        public override double Multiplication (int x, int y)
        {
            Console.WriteLine("Multiplication of " + x + " and " + y + " is :->" + (x * y));
            return x * y;
        }
        
        /// <summary>
        ///     this is abstract void method it is used to Division of two variable 
        /// </summary>
        /// <param name="x">it is used to hold the var value</param>
        /// <param name="y">it is used to hold the var value</param>
        /// <returns>
        ///     Division of x and y value 
        /// </returns>

        public override double  Division(int x, int y)
        {
            Console.WriteLine("Division of " + x + " and " + y + " is :->" + (x / y));
			return x / y;

        }       
    }

    /* Interface Class*/


    interface IEvenNumbers
    {
       /* Pure Abstract Method Signature  */

        void Two();
        void Four();
        void Six();
    }
    interface IOddNumbers
    {
        void One();
        void Three();
        void Five();
    }

    class InterfaceClassInmplementation : IEvenNumbers, IOddNumbers 
    {
        /// <summary>here we implements 2 Interface</summary>
		/// <remarks>Implementation of Abstract Method </remarks>

        public void One()
        {
            Console.WriteLine("This is No 1");
        }

        public void Two()
        {
            Console.WriteLine("This is No 2");
        }

        public void Three()
        {
            Console.WriteLine("This is No 3");
        }

        void IEvenNumbers.Four() // Here we can also access class name.method also
        {
            Console.WriteLine("This is No 4");
        }

        void IOddNumbers.Five()
        {
            Console.WriteLine("This is No 5");
        }

        void IEvenNumbers.Six()
        {
            Console.WriteLine("This is No 6");
        }
    }

    /* Serialization */

    /// <summary>
    /// <code>
    ///  public int n1 = 0;
    ///  public int n2 = 0;
    ///  public String str = "";
    /// </code>
    /// </summary>

    class MyObject
    {
        /// <summary>
        /// stroage for int n1,n2 and  string srt 
        /// </summary>

        public int n1 = 0;
        public int n2 = 0;
        public String str = "";
    }

    class AbstractClass_Interface_Serilization
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>

        static void Main(string[] args)
        {
            
 
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(AbstractClass_Interface_Serilization));
            log.Info("ABSTRACT Class");


            /* ABSTRACT Class*/

            ///<para>
            ///  here we are instainting the class name is <c>AbstractChildDemo</c>
            /// </para>

            AbstractChildDemo acl = new AbstractChildDemo();

            acl.Addition(10, 2);
            acl.Subtraction(10, 2);
            acl.Multiplication(10, 2);
            acl.Division(10, 2);

            log.Info("" + "");

            /* Interface Class*/

            /// <para> 
            /// here we can create references of the IEvenNumber and IOddNumbers interface
            /// </para>

            IEvenNumbers evenNumbers = null; 
            IOddNumbers oddNumbers = null;

            InterfaceClassInmplementation ici = new InterfaceClassInmplementation();

            /// <para> 
            /// reference is pointing to Object
            /// </para>

            oddNumbers = ici;
            evenNumbers = ici;

            Console.WriteLine("This is ODD");
            ici.One();
            ici.Three();
            oddNumbers.Five();

            log.Info("This is EVEN");
            ici.Two();
            evenNumbers.Four();
            evenNumbers.Six();

            /* Serialization */

            MyObject obj = new MyObject();

            obj.n1 = 13;
            obj.n2 = 2100;
            obj.str = "Serialized stream";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\Users\\Harshad\\source\\repos\\log4jnetDemostration\\log4jnetDemostration\\MyFile.txt", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                formatter.Serialize(stream, obj);
            }
            catch (SerializationException se)
            {
                log.Info("Failed to serialize. Reason: " + se.Message);
            }
            finally
            {
                stream.Close();
                log.Info("Serialization done SucessFull");
            }

            /* Deserialization */

            IFormatter formatter1 = new BinaryFormatter();
            FileStream stream1 = new FileStream("C:\\Users\\Harshad\\source\\repos\\log4jnetDemostration\\log4jnetDemostration\\MyFile.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

            try
            {
                MyObject obj1 = (MyObject)formatter1.Deserialize(stream1);
            }
            catch (SerializationException se)
            {
                log.Info("Failed to serialize. Reason: " + se.Message);
            }
            finally
            {
                Console.WriteLine("n1: {0}", obj.n1);
                Console.WriteLine("n2: {0}", obj.n2);
                Console.WriteLine("str: {0}", obj.str);

                stream.Close();

                log.Info("Deaserialization done SucessFull");
            }
            Console.ReadKey();
        }
    }
}
