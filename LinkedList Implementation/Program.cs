using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            LinkedList linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Display();
            linkedList.Search(4);
            linkedList.Search(10);
            linkedList.Remove(4);
            linkedList.Display();
            linkedList.Remove(10);
            linkedList.Add(6);
            linkedList.Display();
            linkedList.Remove(1);
            linkedList.Display();
            linkedList.Add(8, 2);
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
