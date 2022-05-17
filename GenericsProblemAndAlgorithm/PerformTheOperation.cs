using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblemAndAlgorithm
{
    public class PerformTheOperation
    {
        LinkedLists<string> list=new LinkedLists<string>();
        public void AddArraysElementsInList(string[] arrays)
        {
            foreach (var value in arrays)
            {
                list.AddNode(value);
            }
        }
        public void CheckingAndInsertingElementsInList(string element)
        {
            int length=list.Size();
            while (length > 0)
            {
                int index = list.Search(element);
                if (index == 0)
                {
                    list.Append(element);
                }
                else
                {
                    list.DeleteNodeAtPerticularPosition(index);
                }
                length--;
            }
             list.DisplaySortedList();
        }

    }
}
