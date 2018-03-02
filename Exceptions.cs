using System;
namespace Programming
{
   
    class Exceptions
    {
        private static int y;
        private static int x;

        public static void ExceptionData0()
        {
            Console.Write("Enter the 1st number:->");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd number:->");
            y = int.Parse(Console.ReadLine());
        }

        public static void ExceptionData01()
        {
            if (y % 2 > 0)
            {
                // for displying better user msg we as using ApplicationException // that are not Handel by CLR // only on user will create instance 

                // throw new ApplicationException("divisor must be divided by even number");	// this is way define your own exception 

                throw new DivideByZero(); // this is the way to call own user applicationException Class
            }
        }

        public static void ExceptionData1() 
        {
            ExceptionData0();
            ExceptionData01();
            int z = x / y; //
            Console.WriteLine(" Answer is :->" + z);
        }

        public static void ExceptionData2()
        {
            ExceptionData0();
            try
            {
                // in this block we can write any abnormal condition of code

                int z = x / y; // 10/5 = 2
                Console.WriteLine(z);
            }                               // if any exception accor in try block then controll direcly go matched catch-block

            catch (DivideByZeroException dz)  // 10/ 0 = this  catch will exccute
            {
                //here whatver msg we have to dispaly by by our User
                Console.WriteLine(dz.Message);
            }
            
            // here we can not write any statement

            catch (FormatException fx) // // 10/ y = this  catch will exccute
            {
                //Console.WriteLine(fx.Message); // system display msg
                Console.WriteLine("input must be numeric"); //  user defing to msg
            }
            
            // here we can not write any statement

            catch (Exception ex) // if no any suitable catch is excute then Exception is taking care onbehaf of every exception
            {
                Console.WriteLine(ex.Message);
            }

            // here we can not write any statement

            finally 
            {
                Console.WriteLine(" fianlly will executed");//if control enter in try and finally will excute , no matter flow is normal or Abnomal
            }
        }
        
        static void Main(string[] args)
        {
            ExceptionData1();           
            ExceptionData2();           
    
			Console.ReadKey();
        }
    }
    
	/* This is the way to create own user applicationException Class*/

    class DivideByZero : ApplicationException  
    {
        public override string Message => " Attempted to divided bu odd number";
    }
}
