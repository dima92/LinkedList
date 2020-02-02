using LinkedList.Model;
using System;

namespace LinkedList
{
    class Program
    {
        private static void Main(string[] args)
        {
            var circularList = new CircularLinkedList<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            circularList.Delete(3);
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            var duplexList = new DuplexLinkedList<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            duplexList.Delete(3);
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var reverse = duplexList.Reverse();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            var list = new LinkedList<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendHead(7);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(4, 8);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}