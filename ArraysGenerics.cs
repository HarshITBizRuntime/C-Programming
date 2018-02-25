using System;

namespace Programming
{
    class ArraysGenerics
    {
        static void CreateOneDimArray()
        {
            int[] A = new int[5];  //Declare single dimensional array and accept 5 integer values from the user. 
           
			for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the array Element:->");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
      
			PrintArray(A);
            
			Array.Sort(A); //Then sort the input in ascending order and display output
            
			PrintArray(A);
        }
        static void PrintArray(int [] A)
        {
             Console.WriteLine("Elements of array");
            foreach(int i in A)
            {
                Console.Write(i + ",");
            }
        }
        int[,] A = new int[3, 3];  //Declare two dimensional array and accept 3 * 3 integer values from the user. 
        int[,] B = new int[3, 3];
        public void CreateTwoDimArray()
        {
            int i, j;
            for (i = 0; i <3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Enter the 2D array Element:->");
                    A[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
			this.Copy2DArray();
            
			Console.WriteLine("");
            
			this.PrintTwoDimArry();
        }
        public void Copy2DArray()
        {
            this.PrintTwoDimArry();
            
			Console.WriteLine("");
            Console.WriteLine("copy A array to B Array");
            
			for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B[i, j] = A[i, j];
                }
            }
        }
        public void PrintTwoDimArry()
        {
            Console.WriteLine("print 2D Array");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(this.B[i, j]);
                }
            }
        }
			/*  Generics */ 
        static void CommonFunciton<G>(G s)
        {
            Console.WriteLine("the Value of S is :->" + s);
        }

        class G3<G1, G2>
        {
            G1 test1;
            G2 test2;

           public G3(G1 test1, G2 test2)
            {
                Console.WriteLine(this.test1 = test1);
                Console.WriteLine(this.test2 = test2);
            }
            public void display(G1 s1, G2 s2)
            {
                Console.WriteLine("the value s is:-> " + s1+ "," +  s2);
            }
        }
        static void Main(string[] args)
        {
			CreateOneDimArray();
			
			ArraysGenerics ag = new ArraysGenerics();
			
			ag.CreateTwoDimArray();     
			
			CommonFunciton<int>(100);//   when the datatype is change  that time we are performing Generics at functional level
			CommonFunciton<Double>(1.000);
			CommonFunciton<Boolean>(true);
			CommonFunciton<string>("100");
			CommonFunciton<char>('B');
			
			G3<int, int> g1 = new G3<int, int>();// when the number of argument is changing that time we are performing same as class Level
			G3<string, string> g2 = new G3<string, string>();
			G3<double, double> g3 = new G3<double, double>();

			g1.display(20,10);
			g2.display("Hello","hie");
			g3.display(20.45, 125.12);

            G3<string, string> g2 = new G3<string, string>("abc","test");
            G3<double, double> g3 = new G3<double, double>(1.0,2.0);
           
			Console.ReadKey();
        }
    }
}
