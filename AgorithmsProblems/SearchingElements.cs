using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgorithmsProblems
{
    public class SearchingElements
    {
        string key;
        public int BinarySearch(string[] array, int first_index, int last_index, string key)
        {
            while (last_index > first_index)
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
        public void SortingElements(string[] array)
        {
            Console.Write("Unsorted Elements:->");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine(" ");
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                string temp = array[i];

                // Insert array[j] at its correct position
                int j = i - 1;
                while (j >= 0 && temp.Length < array[j].Length)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            // DisplayArrayElemnts(array);
        }
        public void DisplayArrayElemnts(String[] str)
        {
            Console.Write("Sorted Elemnets is:-> ");
            foreach (var elements in str)
            {
                Console.Write(elements + " ");
            }
            Console.WriteLine(" ");
        }
        public void SortingElements(int[] array)
        {
            Console.Write("Unsorted Elements:->");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine(" ");
            int length = array.Length;
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
             
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
            
        }
        int count = 0;
        public void IsAnagram(string firstWord, string secondWord)
        {
            int first_Length = firstWord.Length;
            int second_Length = secondWord.Length;
            bool status = true;
            if (first_Length != second_Length)
            {
                status = false;
            }
            else
            {
                char[] first_array = firstWord.ToLower().ToCharArray();
                char[] second_array = secondWord.ToLower().ToCharArray();
                Array.Sort(first_array);
                Array.Sort(second_array);
                status = second_array.Equals(first_array);

                for (int i = 0; i < first_Length && first_Length == second_Length; i++)
                {
                    if (first_array[i] != second_array[i])
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine(firstWord + " " + "and" + " " + secondWord + " " + "  word is Anagram");
            }
            else
            {
                Console.WriteLine(firstWord + " " + "and" + " " + secondWord + " " + "word is not Anagram");
            }
        }

    }
}
