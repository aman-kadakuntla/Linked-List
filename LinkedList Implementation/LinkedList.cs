using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Implementation
{
    internal class LinkedList
    {
        private Node head = null;
        public void Add(int val)
        {
            Node newNode = new Node();
            newNode.val = val;
            newNode.link = null;
            if (head == null)
            {
                head = new Node();
                head.link = newNode;
            }
            else
            {
                Node n = head;
                while (n.link != null)
                {
                    n = n.link;
                }
                n.link = newNode;
            }
        }
        public void Search(int val)
        {
            Node n = head.link;
            bool isPresent = false;
            while(n!=null)
            {
                if(n.val==val)
                {
                    isPresent = true;
                    break;
                }
                n = n.link;
            }
            if (isPresent)
                Console.WriteLine("found " + val);
            else
                Console.WriteLine(val + " not found");
        }
        public void Remove(int val)
        {
            Node previousLink = head;
            Node currenNode = previousLink.link;
            bool isPresent = false;
            while(currenNode!=null)
            {
                if(currenNode.val==val)
                {
                    Node n=currenNode.link;
                    previousLink.link =n;
                    isPresent = true;
                    break;
                }
                previousLink = currenNode;
                currenNode = currenNode.link;
            }
            if (!isPresent)
                Console.WriteLine(val + " not found");
        }
        public void Display()
        {
            Node n = head.link;
            while (n != null)
            {
                Console.Write(n.val + " ");
                n = n.link;
            }
            Console.WriteLine();
        }
        public void Add(int val,int index)
        {
            Node previousNode = head;
            Node currentNode = previousNode.link;
            int count = 0;
            while (currentNode != null)
            {
                if (count==index)
                {
                    Node n = new Node();
                    n.val = val;
                    n.link = currentNode;
                    previousNode.link = n;
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.link;
                count++;
            }
        }
    }
}
