using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

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

            int len = list.Count;
            Console.WriteLine("Length of list is {0}", len.ToString());//Get the length of SortedList
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
            string[] company = { "wipro", "TCS", "Acenture", "Reliance" }; // Copy array [] in to Queue
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
        /* HashTable  */

        public static void addHashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("ename", "harsh");
            ht.Add("eid", 456);
            ht.Add("ecity", "chainnai");
            ht.Add("esal", 85412);
            Console.WriteLine();
            foreach (Object key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }
        }
        /* ArrayList */

        public static void AddArrayList()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("initially the array list capacity is:");
            Console.WriteLine(al.Capacity);
            al.Add(60);
            al.Add(40);
            al.Add(50);
            Console.Write("after inserting elements the arraylist capacity is:->");
            Console.WriteLine(al.Capacity);
            al.Add(null);
            al.Add("hi");
            al.Add(50);
            al.Add(20);
            Console.WriteLine(al.Capacity);
            Console.Write("the arraylist elements are:->");
            foreach (Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            al.Insert(3, 55);
            al.Insert(5, 45);
            al.Insert(6, 55);
            Console.Write("after inserting new element the arraylist elements are:->");
            foreach (Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            al.Remove(50); // remove particular element
            al.RemoveAt(3); // remove particular index of element
            al.RemoveRange(3, 5); // at specific numbers of element 
            Console.Write("after removing the arraylist elements are:->");
            foreach (Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.Write("finally the arraylist capacity is:->");
            Console.WriteLine(al.Capacity);
            al.Sort(); // sort the array list elements

            Console.Write("after sorting arraylist elements are:->");
            for (int i = 0; i < al.Count; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("the array list elements count is:" + al.Count);
            al.Clear();
            Console.WriteLine("to clear the array list:" + al.Count);
        }

        /* IEnumerable & IEnumerator Interface*/

        List<int> yers = null;
        public  void addIEnumerable()
        {
           yers = new List<int>();
            yers.Add(1995);
            yers.Add(1996);
            yers.Add(1997);
            yers.Add(1998);
            yers.Add(1999);
            yers.Add(2000);
            yers.Add(2001);
            yers.Add(2002);
            yers.Add(2003);

            IEnumerable<int> ienum = (IEnumerable<int>)yers;
            Console.Write("using IEnumerable:->");
            foreach (int itreate in ienum)
            {
                Console.Write(itreate + "   ");
            }
        }
        public  void  addIEnumerator()
        {
            Console.WriteLine();
            IEnumerator<int> ienumerator = yers.GetEnumerator();
            Console.Write("using IEnumerator:->");
            while (ienumerator.MoveNext())
            {
                Console.Write(ienumerator.Current.ToString() + "   ");
            }
        }
        
        /*IComparable & IComparer Interfaces*/

        class Employee1
        {
            public int eid { get; set; }
            public string ename { get; set; }
            public string job { get; set; }
            public double sal { get; set; }
        }

        public class Student : IComparable<Student>
        {
            public int sid { get; set; }
            public string name { get; set; }
            public int classess { get; set; }
            public float marks { get; set; }

            public int CompareTo(Student other)
            {
                if (this.sid > other.sid)
                    return 1;
                else if (this.sid < other.sid)
                    return -1;
                else
                    return 0;
            }
        }
        class CompareStudent : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                if (x.marks > y.marks)
                    return 1;
                else if (x.marks > y.marks)
                    return -1;
                else
                    return 0;
            }
        }

        /*ICollection & IList Interfaces*/

        public static void addItemInIList()
        {
            // property of IList(isFixedSize,IsReadOnly,IsReadOnly)By-using ArrayList
            ArrayList arrayList = new ArrayList();
            bool isFixedSize = arrayList.IsFixedSize; // false, because  // is not fixed size list
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            bool readOnly = arrayList.IsReadOnly; // false, because default array // list is not readonly.
            Console.WriteLine(readOnly);
            ArrayList readOnlyList = ArrayList.ReadOnly(arrayList); // create readonly list from existing list
            Console.WriteLine(readOnlyList);
            bool isNewListReadOnly = readOnlyList.IsReadOnly; // true. now user can't // modify this list
            Console.WriteLine(isNewListReadOnly);

            // mehod of IList using arrayList

            int itemsCount = arrayList.Count; // 3
            Console.WriteLine(itemsCount);
            arrayList.Clear();
            itemsCount = arrayList.Count; // 0
            Console.WriteLine(itemsCount);

            // property of IList(isFixedSize,IsReadOnly,contains) By using Hashtable

            Hashtable hashList = new Hashtable();
            hashList.Add(1, "I1");
            hashList.Add(2, "I2");
            hashList.Add(3, "I3");

            bool result = hashList.IsFixedSize; // false            // mehod of IList using arrayList
            Console.WriteLine(result);
            result = hashList.IsReadOnly; // false            // mehod of IList using arrayList
            Console.WriteLine(result);

            // Keys 

            /* usage of ICollection*/

            ICollection keys = hashList.Keys;

            string[] strKeys = new string[keys.Count];

            int index = 0;
            foreach (int key in keys)
            {
               strKeys[index++] = key.ToString();
            }

            string keysList = string.Join(", ", strKeys); // 3, 2, 1
            Console.WriteLine(keysList);

            ICollection values = hashList.Values;

            string[] strValues = new string[values.Count];
            index = 0;
            foreach (string value in values)
            {
              strValues[index++] = value;
            }

            string valueList = string.Join(", ", strValues); //I1,I2,I3
            Console.WriteLine(valueList);

            result = hashList.Contains(1); // true
            Console.WriteLine(result);
            /* usagae of  IDictionaryEnumerator */
            IDictionaryEnumerator dicEnum = hashList.GetEnumerator();

            string items = string.Empty;
            while (dicEnum.MoveNext())
            {
                items += string.Format("\n", dicEnum.Key, dicEnum.Value);
            }
            Console.WriteLine(items);

            itemsCount = hashList.Count;
            Console.WriteLine(" Count Before Delete:->"+ itemsCount);
            hashList.Remove(2); // remove item which has 2 key
            itemsCount = hashList.Count;
            Console.WriteLine(" Count after Delete:->" + itemsCount);
        }
        /* system.collections.concurrent */
        static ConcurrentDictionary<int, string> cd = new ConcurrentDictionary<int, string>();
        static void test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                cd.TryAdd(i, "test1 is added " + i);
            }
        }
        static void test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                cd.TryAdd(i, "test2 is added " + i);
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
            
			/* hash-table */
            
			addHashTable();
           
			/* ArrayList*/
            
			AddArrayList(); 
            
            /* IEnumerable & IEnumerator Interface*/
            
           c.addIEnumerable();
           c.addIEnumerator();
            
            /*IComparable & IComparer Interfaces*/

            Student s1 = new Student { sid = 103, name = "jay", classess = 10, marks = 552.00f };
            Student s2 = new Student { sid = 100, name = "ajay", classess = 11, marks = 500.00f };
            Student s3 = new Student { sid = 102, name = "vijay", classess = 12, marks = 362.00f };

            List<Student> Students = new List<Student>() { s1, s2, s3 };

            CompareStudent cs = new CompareStudent();
            Students.Sort(cs);
            foreach (Student S in Students)
            {
                Console.WriteLine(S.sid + " \t" + S.name + " \t" + S.classess + " \t" + S.marks + " \t");
            }

            List<Employee1> employees1 = new List<Employee1>();
            employees1.Add(new Employee1 { eid = 105, ename = "jay", job = "manager", sal = 12000 });
            employees1.Add(new Employee1 { eid = 104, ename = "ajay", job = "HR", sal = 15000 });
            foreach (Employee1 E in employees1)
            {
                Console.WriteLine(E.eid + " \t" + E.ename + " \t" + E.job + " \t" + E.sal + " \t");
            }

            /*ICollection & IList Interfaces*/

            addItemInIList();

            /* system.collections.concurrent */

            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);
            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
    }
}
