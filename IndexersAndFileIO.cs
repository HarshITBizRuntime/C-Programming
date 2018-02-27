using System;
using System.IO;
using System.Text;

namespace Programming
{
    class Employee2
    {
        /* Indexers*/

        int Eno;
        double sal;
        string Ename, job, Dname, location;
        
		public Employee2(int Eno, double sal, string Ename, string job, string Dname, string location)
        {
            this.Eno = Eno;
            this.sal = sal;
            this.Ename = Ename;
            this.job = job;
            this.Dname = Dname;
            this.location = location;
        }
        public object this[string name]  // This is second to get data by using name
        {
            get
            {
                if (name == "Eno")
                    return Eno;
                else if (name == "sal")
                    return sal;
                else if (name == "Ename")
                    return Ename;
                else if (name == "job")
                    return job;
                else if (name == "Dname")
                    return Dname;
                else if (name == "location")
                    return location;
                return null;

            }
        }
        public object this[int index] // This is first to get data by using index
        {
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return sal;
                else if (index == 2)
                    return Ename;
                else if (index == 3)
                    return job;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return location;
                return null;

            }

            set
            {
                if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    sal = (double)value;
                else if (index == 2)
                    Ename = (string)value;
                else if (index == 3)
                    job = (string)value;
                else if (index == 4)
                    Dname = (string)value;
                else if (index == 5)
                    location = (string)value;
            }

        }

        /* File IO */
            
			/* 1 FileStream */
        public void CreateFIle()
        {
            FileStream fs = new FileStream("C:\\Users\\Harshad\\Desktop\\class\\FileHandeling\\fdata1.txt", FileMode.Create);
            fs.Close();
            Console.Write("File has been created and the Path is C:\\Users\\Harshad\\Desktop\\class\\FileHandeling ");
        }
        
		/* 2 FileStream & StreamReader */

        public void ReadaFIle()
        {
            string data = null;
            FileStream fsSource = new FileStream("C:\\Users\\Harshad\\Desktop\\class\\FileHandeling\\FileData.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fsSource))
            {
                data = sr.ReadToEnd();
            }
            Console.WriteLine(data);
            Console.ReadLine();
        }
        
		/* 3 StreamWriter */

        public void WriteaFIle()
        {
            string file = @"C:\\Users\\Harshad\\Desktop\\class\\FileHandeling\\FileData.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("Hello");
                writer.WriteLine("Hellow StreamWriter Class");
                writer.WriteLine("How are you!");
            }
            Console.WriteLine("Data Saved Successfully!");
        }
        
		/* 4 FileSystem */

        public void WriteDatausingFilesyStream()
        {
            FileStream fs = new FileStream("C:\\Users\\Harshad\\Desktop\\class\\FileHandeling\\FileData.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Hello File Handling!");
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();
            Console.WriteLine("Successfully saved file with data : Hello File Handling!");

        }
        
		/* 5 StringBuilder and StringWriter */

        public void StringWriterDemo1()
        {
            string text = "Hello. This is Line 1 \n Hello. This is Line 2 \nHello This is Line 3";       //Writing string into StringBuilder
            StringBuilder sb = new StringBuilder();
            StringWriter writer = new StringWriter(sb);        //Store Data on StringBuilder
            writer.WriteLine(text);
            writer.Flush();
            writer.Close();
            StringReader reader = new StringReader(sb.ToString());//Read Entry
            while (reader.Peek() > -1) //Check to End of File
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        
		/* 6 StringReader */

        public void StringReraderDemo1()
        {
            string text = @"You are reading this my article ";

            using (StringReader reader = new StringReader(text))
            {
                int count = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                    Console.WriteLine("Line {0}: {1}", count, line);
                }
            }
        }
        /* 7 TextWriter */

        public void TextWriteDemo1()
        {
            string file = @"C:\\Users\\Harshad\\Desktop\\class\\FileHandeling\\FileData.txt";
            using (TextWriter writer = File.CreateText(file))
            {
                writer.WriteLine("Hello TextWriter!");
                writer.WriteLine("File Handling Tutorial");
            }
            Console.WriteLine("Entry stored successfull!");
        }
      
		/* 9 TextReader */
       
		public void TextReadereDemo1()
        {
            string filepath = @"C:\\Users\\Harshad\\Desktop\\class\\FileHandeling\\FileData.txt";//Read One Line
            using (TextReader tr = File.OpenText(filepath))
            {
                Console.WriteLine(tr.ReadLine());
            }
            using (TextReader tr = File.OpenText(filepath))//Read 4 Characters
            {
                char[] ch = new char[4];
                tr.ReadBlock(ch, 0, 4);
                Console.WriteLine(ch);
            }
            using (TextReader tr = File.OpenText(filepath))//Read full file
            {
                Console.WriteLine(tr.ReadToEnd());
            }
        }
        
		/* 10 DirectoryInfo*/
        
		public void DirectoryInfoDemo()
        {
            string path = @"C:\\Users\\Harshad\\Desktop\\class\\FileHandeling";
            DirectoryInfo dir = new DirectoryInfo(path);
            try
            {
                if (dir.Exists)
                {
                    Console.WriteLine("{0} Directory is already exists", path);
                    Console.WriteLine("Directory Name : " + dir.Name);
                    Console.WriteLine("Path : " + dir.FullName);
                    Console.WriteLine("Directory is created on : " + dir.CreationTime);
                    Console.WriteLine("Directory is Last Acescessed on " + dir.LastAccessTime);
                }
                
				else
                {
                    dir.Create();
                    Console.WriteLine(path + "Directory is created successfully");
                }

                Console.WriteLine("If you want to delete this directory press small y. Press any key to exit.");   //Delete this directory
                
				try
                {
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'y')
                    {
                        if (dir.Exists)
                        {
                            dir.Delete();
                            Console.WriteLine(path + "Directory Deleted");
                        }
                        else
                        {
                            Console.WriteLine(path + "Directory Not Exists");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Press Enter to Exit");
                }
            }
            catch (DirectoryNotFoundException d)
            {
                Console.WriteLine("Exception raised : " + d.Message);
            }

        }
        
		/* 11 FileyInfo*/

        public void FileInfoDemo()
         {
            string path = @"C:\\Users\\Harshad\\Desktop\\class\\FileHandeling\\FileData.txt";
            FileInfo file = new FileInfo(path);//Create File
            using (StreamWriter sw = file.CreateText())
            {
                sw.WriteLine("Hello FileInfo");
            }

            Console.WriteLine("File Create on : " + file.CreationTime);
            Console.WriteLine("Directory Name : " + file.DirectoryName);
            Console.WriteLine("Full Name of File : " + file.FullName);
            Console.WriteLine("File is Last Accessed on : " + file.LastAccessTime);

            Console.WriteLine("Press small y for delete this file");//Deleting File
            try
            {
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'y')
                {
                    if (file.Exists)
                    {
                        file.Delete();
                        Console.WriteLine(path + " Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("File doesn't exist");
                    }
                }                
            }
            catch
            {
                Console.WriteLine("Press Enter to Exit");
            }

         }
    }
    class IndexersAndFileIO
    {
        static void Main(string[] args)
        {
            /* Indexers*/

            Employee2 employee2 = new Employee2(12, 2633, "jay", "manager", "abc", "btm");
            Console.WriteLine("EmployeeNo:->" + employee2[0]);
            Console.WriteLine("Employee sal:->" + employee2[1]);
            Console.WriteLine("Employee ename:->" + employee2[2]);
            Console.WriteLine("Employee job:->" + employee2[3]);
            Console.WriteLine("Employee dname:->" + employee2[4]);
            Console.WriteLine("Employee localtion:->" + employee2[5]);
            Console.WriteLine();

            employee2[0] = 12345; // reintilize the indexres values
            employee2[2] = "ajay"; 

            Console.WriteLine("after setting the indexer values");

            Console.WriteLine("EmployeeNo:->" + employee2[0]);
            Console.WriteLine("Employee sal:->" + employee2[1]);
            Console.WriteLine("Employee ename:->" + employee2[2]);
            Console.WriteLine("Employee job:->" + employee2[3]);
            Console.WriteLine("Employee dname:->" + employee2[4]);
            Console.WriteLine("Employee localtion:->" + employee2[5]);

            employee2[0] = 56123;
            employee2[2] = "vijay";

            Console.WriteLine("after setting the indexer values using name");
            Console.WriteLine("EmployeeNo:->" + employee2["Eno"]);
            Console.WriteLine("Employee sal:->" + employee2["sal"]);
            Console.WriteLine("Employee ename:->" + employee2["Ename"]);
            Console.WriteLine("Employee job:->" + employee2["job"]);
            Console.WriteLine("Employee dname:->" + employee2["Dname"]);
            Console.WriteLine("Employee localtion:->" + employee2["location"]);

            /* File IO */

            employee2.CreateFIle();
            employee2.ReadaFIle();
            employee2.WriteaFIle();
            employee2.WriteDatausingFilesyStream();
            employee2.StringWriterDemo1();
            employee2.StringReraderDemo1();
            employee2.TextWriteDemo1();
            employee2.TextReadereDemo1();
            employee2.DirectoryInfoDemo();
            employee2.FileInfoDemo();

            Console.ReadKey();
        }
    }
}
