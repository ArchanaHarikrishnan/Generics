using System;
using System.Collections.Generic;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> Linkedlist = new LinkedList<int>();
            //Adding elements in first
            Linkedlist.AddFirst(20);
            Linkedlist.AddFirst(100);
            //Adding elements last
            Linkedlist.AddLast(50);
            Linkedlist.AddLast(60);


            Console.WriteLine();
            //To find element in list
            LinkedListNode<int> ListNode = Linkedlist.Find(100);
            Linkedlist.AddBefore(ListNode, 40);
            Linkedlist.AddAfter(ListNode, 75);
            Linkedlist.AddAfter(ListNode, 65);

            foreach (int i in Linkedlist)
            {
                Console.WriteLine("List of numbers is:" + i);
            }

            if (Linkedlist.Contains(100))
            {
                Console.WriteLine($"{100} is present");
            }
            else
            {
                Console.WriteLine($"{100} is not present");
            
            //To find the count of the elements present in the list
            var count = Linkedlist.Count;
            Console.WriteLine("Count of numbers:" + count);

            //To fetch the middle element in the list
            int middle = count / 2;
            if (count % 2 != 0)
            {
                Console.WriteLine(Linkedlist.ElementAt(middle));
            }
            else {
                for (int i = count / 2 - 1; i <= count / 2; i++)
                {
                    Console.WriteLine("MiddleElement" + Linkedlist.ElementAt(i));
                }
            }
        //Reversing the elements in the list
            var reverseofnumber = Linkedlist.Reverse();
            Console.WriteLine("Reversed ");
            foreach (int i in reverseofnumber)
            {
                
                Console.Write( i+" " );
            }
        }
    }
}
