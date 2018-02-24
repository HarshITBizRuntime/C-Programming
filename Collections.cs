using System;
using System.Collections.Generic;
using System.Collections;

namespace Programming
{
    class Collections
    {
        /* List */

        List<String> list = new List<String>();
        public  void AddItemInList()
        {
            Console.WriteLine("List added:->");
            list.Add("Hello");
            list.Add("Hello");
            list.Add("Hie");
            list.Add("How are you");
            int i = list.Count;
            this.PrintItemInList();
            Console.WriteLine("list count is " + i);
            this.PrintItemSortedInList();
            Console.WriteLine();
            this.RemoveItemInList();
            Console.WriteLine();
            this.IsertItemInSpecificListIndex();
            Console.WriteLine();
            this.PrintItemReverseInList();
        }
        public void PrintItemInList()
        {
            foreach (string  s in list)
                Console.WriteLine(s.ToString() + ",");
        }
        public void PrintItemSortedInList()
        {
            list.Sort();
            Console.WriteLine("After sorting :->");
            foreach (string s in list)
            Console.WriteLine(s.ToString() + ",");
        }
        public void PrintItemReverseInList()
        {
            list.Reverse();
            Console.WriteLine("After Reverse :->");
            foreach (string s in list)
            Console.WriteLine(s.ToString() + ",");
        }
        public void IsertItemInSpecificListIndex()
        {
            list.Insert(2,"abc");
            Console.WriteLine("After List added in specific position:->");
            foreach (string s in list)
            Console.WriteLine(s.ToString() + ",");
        }
        public void RemoveItemInList()
        {
            list.Remove("Hie");
            Console.WriteLine("After removing the list :->");
            foreach (string s in list)
            Console.WriteLine(s.ToString() + ",");
        }
        /* DICTONARY */
        public static void addItemInDictionary()
        {
            Dictionary<string, Object> dt = new Dictionary<string, object>();
            dt.Add("ename", "harsh");
            dt.Add("eid", 456);
            dt.Add("ecity", "chainnai");
            dt.Add("esal", 85412);
            foreach (string key in dt.Keys)
            {
                Console.WriteLine(key + ":->" + dt[key]);
            }
        }
        /* SORTED LIST */
        public static void addIteminSortedList()
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(1, "jay");
            list.Add(2, "Ajay");
            list.Add(3, "Ajay");
            list.Add(4, "Beejay");
            list.Add(5, "Digvijay");
            try
            {
                list.Add(6, "duplicate"); // in sortedlist not allow duplicate key
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            for (int i = 0; i < list.Count; i++)//Traverse using for
            {
                Console.WriteLine("Keys : " + list.Keys[i] + "\tValues : " + list.Values[i]);
            }
            if (list.ContainsValue("jay"))
            {
                Console.WriteLine("Items Found at Position : " + list.IndexOfValue("jay"));
            }
            foreach (KeyValuePair<int, string> k in list)//Traverse using foreach
            {
                Console.WriteLine("Key : {0} - Value : {1}", k.Key, k.Value);
            }
            //Get the length of SortedList
            int len = list.Count;
            Console.WriteLine("Length of list is {0}", len.ToString());
        }

        /* QUEUE */
        public static void addIteminQueue()
        {
            Queue<string> employee = new Queue<string>();
            employee.Enqueue("jay");
            employee.Enqueue("ajay");
            employee.Enqueue("viajy");
            employee.Enqueue("digviajy");
            employee.Enqueue("beejay");
            print(employee);
            Console.WriteLine();
            Console.WriteLine("delete FIFO" + employee.Dequeue());
            Console.WriteLine();
            print(employee);
            copyarrayintoQueue();
            print(employee);
            Console.ReadKey();
        }
        static void copyarrayintoQueue()
        {
            string[] company = { "wipro", "TCS", "Acenture", "Reliance" }; // Copy array in to Queue
            Queue<string> compny = new Queue<string>(company);
            Console.WriteLine("all employee Company name:-> ");
            print(compny);
            Console.WriteLine("count of company : - >" + compny.Count);
        }

        static void print(Queue<string> queue)
        {
            foreach (string str in queue)
            {
                Console.WriteLine(str.ToString());
            }
        }
        /* STACK */
        public static void AddItemInStack()
        {
            Stack<string> days = new Stack<string>();
            days.Push("sun");
            days.Push("Mon");
            days.Push("TUS");
            days.Push("WED");
            days.Push("THS");
            days.Push("FIR");
            days.Push("SAT");
            print(days);
            Console.WriteLine(" display top of the item:-> " + days.Peek());
            Console.WriteLine(" remove top of the element :-> " + days.Pop());
            Console.WriteLine("");
            print(days);
            Console.WriteLine(days.Contains("WED"));
            Console.WriteLine("");
            days.Clear();
            Console.WriteLine(" Q Clear");
            print(days);
            Console.ReadKey();
        }
        static void print(Stack<string> stack)
        {
            foreach (string s in stack)
            {
                Console.WriteLine(s.ToString());
            }
        }

        static void Main(string[] args)
        {
            /* LIST */
            Collections c = new Collections();
            c.AddItemInList();
            /* DICTONARY */
             addItemInDictionary();
            /* SORTED LIST */
             addIteminSortedList();
            /* QUEUE */
            addIteminQueue();
            /* STACK */
            AddItemInStack();
            Console.ReadKey();
        }
    }
}
