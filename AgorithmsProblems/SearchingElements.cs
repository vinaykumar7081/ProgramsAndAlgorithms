using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgorithmsProblems
{
    public class SearchingElements
    {
        public int BinarySearch(string[] array, int first_index, int last_index, string key)
        {
            while (last_index >= first_index)
            {
                int mid = first_index + (last_index - first_index) / 2;
                int res = key.CompareTo(array[mid]);

                // Check if key is present at mid
                if (res == 0)
                    return mid;

                // If key greater, ignore left half
                if (res > 0)
                {
                    first_index = mid + 1;
                }
                // If key is smaller, ignore right half
                if (res < 0)
                {
                    last_index = mid - 1;
                }
            }
            return -1;
        }
    }
}
