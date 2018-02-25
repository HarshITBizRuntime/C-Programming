using System;

namespace Programming
{
    class loops
    {
        /* IF-Else Blocks */

        static void IfDemo1()
        {
            if (true) // boolean Condition only two value true & false
                Console.WriteLine(" if condition is true");
            else
                Console.WriteLine(" if condition is false");
       
            int i = 10;
            if (i == 10) // condition satisty
                Console.WriteLine("both are Equals");

            if (i != 20) // condition not-satisty
                Console.WriteLine("both are Not-Equals");

            Boolean b1 =true; // 
            Boolean b2 = false;

            if (b1 || b2) // here OR operator check only first any condition it is true then all the Condition true 
                Console.WriteLine("if ");
            else
                Console.WriteLine("else");

           Boolean b3 = true;
           Boolean b4 = false;

            if (b3 && b4)   // here and operator check only all the condition first is false then check for second condition
                Console.WriteLine("from if ");
            else
                Console.WriteLine("else");

            if (i++ == 11) // i = 10 line 20 
                Console.WriteLine("condition satisfy");
            else
                Console.WriteLine("condition not-satisfy");// this line will excute

            if (true)
            {
                Console.WriteLine(" outer if is execute ");
                if (true)
                    Console.WriteLine(" inner if is execute ");
                else
                    Console.WriteLine(" inner else is execute ");
            }
            else
                Console.WriteLine(" outer else is execute ");

            if (true)
                if (false)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false"); // nearest If else block is Excute
        }
        static void ErrorIfDemo2()
        {
            /* int i = 1;
             if (i = 2) // implicitly convert type 'int' to 'bool'	
                 Console.WriteLine("true");
             int j = 10; // implicitly convert type 'int' to 'bool'	//we cannot Declare between if and block
             else
                Console.WriteLine("false");

            else 
            {
                Console.WriteLine("we can not write single else block");
            }*/
        }

        /* Switch-Case Blocks */

        static void SwitchCaseDemo1()
        {
            int i = 10;
            switch (i)
            {
                default: // we can write defalut statement any where // 
                    Console.WriteLine("case is not match");// if no any match case then this statement is execute
                    break;
                case 1:
                    Console.WriteLine("case 1");
                     break;
         
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 11:
                    Console.WriteLine("case 11");
                    break;
            }
        }
        /* static void ErrorSwitchCaseDemo2()
         {
             int i = 10;
             switch (i)
             {
                 case 1:
                     Console.WriteLine("case 1");
                     break; // this statement is compulsary

                 case 10:
                     Console.WriteLine("case 10");
                     break; 
                 case 10: // no same case allow 
                     Console.WriteLine("case 10");
                     break;
                 case 11:
                     Console.WriteLine("case 11");
                     break;
                 default: // we can write defalut statement any where // 
                     Console.WriteLine("case is not match");// if no any match case then this statement is execute
                     break;
             }
         }*/

        static void ForDemo1()
        {
            for (int a = 1; a <= 5; a++)
			{
                Console.Write("ForDemo1()" + a + " ,");
			}
            int i;
            int j = 10;
 
			for (i = 0, Console.WriteLine("Start: {0}", i); i < j; i++, j--, Console.WriteLine("i={0}, j={1}", i, j))
            {
                // Body of the loop.
            }
        }
		/* Do-while */

        static void DoDemo1()
        {
            int x = 0;
            do
            {
                Console.WriteLine(x); // first execute and then check condition
                x++;
            } while (x < 5);
        }

		/* While */

        static void DoWhileDemo1()
        {
            int x = 0;
            while (x < 5) // first condition check and then execete
            {
                x++;
                Console.WriteLine(x);
            } 
        }

        static void Main(string[] args)
        {
            IfDemo1();
            Console.WriteLine("");
            ErrorIfDemo2();
            Console.WriteLine("");
            SwitchCaseDemo1();
            Console.WriteLine("");
          //ErrorSwitchCaseDemo2();
            ForDemo1();
            Console.WriteLine("");
            DoDemo1();
            Console.WriteLine("");
            DoWhileDemo1();
            Console.Read();
        }
    }
}