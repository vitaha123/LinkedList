using System;
using LinkedList;
namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single linkedList
            Console.WriteLine("single");
            SingleLinkedList singleLinkedList = new SingleLinkedList();

            for (int i = 0; i < 10; i++)
            {
                singleLinkedList.InsertLast(i.ToString());
            }

            Console.WriteLine(singleLinkedList.ContainsString(3.ToString()).data);
            Console.WriteLine(singleLinkedList.ContainsString(100.ToString())?.data);
            
            singleLinkedList.DeleteNodebyKey(3.ToString());
            singleLinkedList.InsertAfter(singleLinkedList.ContainsString(5.ToString()),1000.ToString());
            singleLinkedList.InsertFront(2000.ToString());

            var strings = singleLinkedList.GetArrayValueStrings();
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"singleLinkedList.Length {singleLinkedList.Length}");
            
            
            // doubleLinkedList
            Console.WriteLine("double");
            DoubleLinkedList doubleLinked = new DoubleLinkedList();

            for (int i = 0; i < 10; i++)
            {
                doubleLinked.InsertLast(i.ToString());
            }

            Console.WriteLine(doubleLinked.ContainsString(3.ToString()).data);
            Console.WriteLine(doubleLinked.ContainsString(100.ToString())?.data);
            
            doubleLinked.DeleteNodebyKey(3.ToString());
            doubleLinked.InsertAfter(doubleLinked.ContainsString(5.ToString()),1000.ToString());
            doubleLinked.InsertFront(2000.ToString());
            

            var dstrings = doubleLinked.GetArrayValueStrings();
            foreach (var s in dstrings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"doubleLinked.Length {doubleLinked.Length}");
        }
    }
}