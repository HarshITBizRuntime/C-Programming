using System;
using System.Collections.Generic;

namespace Programming
{
    class Collections
    {
            List<String> list = new List<String>();
        public  void AddItemInList()
        {
            Console.WriteLine("List added:->");
            list.Add("Hello");
            list.Add("Hie");
            list.Add("How are you");
            
            this.PrintItemInList();
            Console.WriteLine();
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
        static void Main(string[] args)
        {
            Collections c = new Collections();
            c.AddItemInList();
            Console.ReadKey();
        }
    }
}
