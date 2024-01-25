using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList ar = new SortedList();

            ar.Add(111, "Chicken");
            ar.Add(222, "Master");
            ar.Add(333, "Egg");

            Console.WriteLine("the first value of the Sorted List is " + ar[111].ToString());
            Console.WriteLine("the second value of the Sorted List is " + ar[222].ToString());
            Console.WriteLine("the third value of the Sorted List is " + ar[333].ToString());

            Console.WriteLine("The COUNT of the Sorted List is " + ar.Count);
            ar.Clear();
            Console.WriteLine("after a CLEAR: The COUNT of the Sorted List is " + ar.Count);

            ar.Add(111, "Chicken");
            ar.Add(222, "Master");
            ar.Add(333, "Egg");

            Console.WriteLine("after ADDING BACK VALUES: The COUNT of the Sorted List is " + ar.Count);

            Console.WriteLine("The Sorted List CONTAINS KEY 222? " + ar.ContainsKey(222));

            Console.WriteLine("The Sorted List CONTAINS VALUE Egg? " + ar.ContainsValue("Egg"));

            Console.WriteLine("The INDEX OF KEY 111 is? " + ar.IndexOfKey(111));

            Console.WriteLine("The INDEX OF VALUE 333 is? " + ar.IndexOfValue("Egg"));
            ar.Remove(111);
            Console.WriteLine("AFTER A REMOVE111 : The COUNT of the Sorted List is " + ar.Count);
            ar.RemoveAt(1);
            Console.WriteLine("AFTER A REMOVEAT index 1: The COUNT of the Sorted List is " + ar.Count);
            Console.Read();
        }
    }
}