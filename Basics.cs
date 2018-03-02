using System;

namespace Programming
{
    class Basics
    {
        static void WriteDemo()
        {
            Console.Write("write()");
            Console.Write("Write(whatver content we are print here it will comes in-same line");
        }
        static void WriteLineDemo()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(" Value of a is " + a);
            Console.WriteLine("WriteLine()"); //Write() and WriteLine() both function put it as Blank 
            Console.WriteLine(" Value of a is " + b);
        }
        static void ReadLineDemo()
        {
            Double a, b, c;
            Console.Write("enter the one number:->");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the second number:->");
            b = Convert.ToDouble(Console.ReadLine());
            c = a + b;
            Console.WriteLine(" sum of the a & b:->" + c);
            Console.Read();
        }
        static void PrintVriableDemo()
        {
            int x= 10; // if you are not intilize the variable then CLR gives Error CS0165  Use of unassigned local variable 'x'  ;
            Console.WriteLine("the value of X is :->" + x);
            Boolean flag; // we not Declare same name variable i.e x here 
            Console.WriteLine(flag = true);
        }
        static void ReIntilizePrintVriableDemo()
        {
            int x;  // here we can take any datatype like (i.e char,byte,int ,float,double, longand boolean also)
            x = 10;// intiliziation
            Console.WriteLine("the value of X is :->" + x);
            x = 20; // reintilization
            Console.WriteLine("after Reintilize the X value :->" + x); 
        }
       /* static void ErrorVriableDemo()// first Declaration and then Intilization then Reitilization
        {
            double j;
            Console.WriteLine(j);
            int x;
            int y = x;// we can not Declare like this 

            Console.WriteLine(i); //Error	CS0841	Cannot use local variable 'i' before it is declared	
            double i =10.1 ;
        }*/

        static void Main(string[] args)
        {
            WriteDemo();
            Console.WriteLine("");
            WriteLineDemo();
            Console.WriteLine("");
            ReadLineDemo();
            Console.WriteLine("");
            PrintVriableDemo();
            Console.WriteLine("");
            ReIntilizePrintVriableDemo();
            Console.WriteLine("");
          //ErrorVriableDemo();
            Console.Read();
        }
    }
}
