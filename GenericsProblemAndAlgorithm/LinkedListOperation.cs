using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GenericsProblemAndAlgorithm
{
    public class LinkedListOperation<T>
    {
        LinkedList<T> lists = new LinkedList<T>();
        public Node<T> head = null;
        public void AddingElements(LinkedList<T> list)
        {
            foreach (T item in list)
            {
                lists.AddLast(item);
            }
            Display();
        }
        public void Check_Removing_PresentElements(T value)
        {
            foreach (T item in lists)
            {
                if (item.Equals(value))
                {
                    lists.Remove(value);
                    Console.Write(item + " ");
                }
            }
            Display();
        }
        public void Check_Added_NewElement(T value)
        {
            bool status = true;
            foreach (T item in lists)
            {
                if (item.Equals(value))
                {
                    status = false;
                    
                }
                else
                {
                    lists.AddLast(value);
                    Console.Write(item + " ");
                }
            }
          //  Display();
        }
        public void Display()
        {
            foreach (T item in lists)
            { 
            Console.WriteLine(item.ToString());
            }
        }
    }
}
