using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblemAndAlgorithm
{
    public class SortedList<T>
    {
        LinkedList<T> add = new LinkedList<T>();
        public void AddingIntegerElements(LinkedList<T> list)
        {
            foreach (T item in list)
            {
                add.Append(item);
            }
            //Display();
        }
        public void Display()
        {
            foreach (T item in add)
            { 
            Console.Write(item);
            }
            Console.WriteLine(" ");
        }
    }
}
