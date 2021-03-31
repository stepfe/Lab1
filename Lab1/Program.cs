using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            list.pushBack(new Node(0));
            list.pushBack(new Node(1));
            list.pushBack(new Node(2));
            list.print();
            list.reverse();
            list.print();
            list.reverse();
            list.print();
        }
    }
}
