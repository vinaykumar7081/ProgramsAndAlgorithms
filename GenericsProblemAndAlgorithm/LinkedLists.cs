using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblemAndAlgorithm
{
   
    internal class LinkedLists<T> where T : IComparable
    {
        public Node<T> head = null;
        public void AddNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.Write(newNode.data + " " + "inserted into Linked List ");
            }
            Console.WriteLine();
            //DisplaySortedList();
        }
        public void SortOrderList()
        {
            Node<T> current = head, index = null;
            T temp;
            if (head == null)
            {
                return;
            }

            while (current != null)
            {
                index = current.next;
                while (index != null)
                {
                    if (current.data.CompareTo(index.data) > 0)
                    {
                        temp = current.data;
                        current.data = index.data;
                        index.data = temp;
                    }
                    index = index.next;
                }
                current = current.next;
            }
            DisplaySortedList();
        }
        public void DisplaySortedList()
        {
            Node<T> temp = head;
            if (head == null)
            {
                Console.WriteLine("There is no element int he linked List");
            }
            while (temp != null)
            {
                Console.Write(temp.data + "  ");
                temp = temp.next;
            }
            Console.WriteLine(" ");
        }
        public int Search(T addedData)
        {
            Node<T> node = this.head;
            int count=0;
            while (node != null)
            {
                if (node.data.Equals(addedData))
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            Console.WriteLine(node.data + " " + "Appended into Linked List ");
        }
        public int Size()
        {
            Node<T> temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public void DeleteNodeAtPerticularPosition(int position)
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            Node<T> temp = head;
            if (position == 0)
            {
                head = temp.next;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node<T> next = temp.next.next;
            temp.next = next;
            DisplaySortedList();
        }
        
    }
    
}
