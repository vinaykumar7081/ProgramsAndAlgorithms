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
        List<int> list=new List<int>();
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
        int pcount = 0;
        public void IsPrime(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    pcount++;
                    Console.WriteLine("Number is Prime" + i);
                    list.Add(i);
                }
                else
                {
                    Console.WriteLine("Number is not Prime" + i);
                }
            }
            Console.WriteLine("Number of prime Number between startNumber to endNumber:->" + pcount);
        }
        public void IsPalindrome()
        {
            int rem=0, temp=0, sum=0, count=0;
            foreach (int element in list)
            {
                temp = element;
                while (temp != 0)
                {
                    rem = temp % 10;
                    sum = sum * 10 + rem;
                    temp = temp / 10;
                }
                if (sum == element)
                {
                    count++;
                    Console.WriteLine("Number is Palindrome "+sum + " " + count);
                }
                else 
                {
                    Console.WriteLine("Number is not palindrome " + sum + " " + count);
                }
                Console.WriteLine(element + " ");
            }
        }
        public void NumberIsAnagram()
        {
            int length = list.Count;
            Console.WriteLine(length + " Lentght of the List");
            for (int i = 0; i < length; i++)
            {
                int rem = 0, temp = 0, sum = 0, count = 0;
                    temp=list[i];
                    while (temp != 0)
                    {
                        rem = temp % 10;
                        sum = sum * 10 + rem;
                        temp = temp / 10;
                    }
                for (int j = 0; j < length; j++)
                {
                    if (list[j] == sum)
                    {
                        Console.WriteLine("Number is Anagram"+sum);
                    }
                    //else
                    //{
                    //    Console.WriteLine("Number is not Anagram");
                    //}
                }
            }
        }
        public int SearchingNumber(int taken_Number)
        {
            int square_Number =(int) Math.Pow(2, taken_Number);
            if (square_Number % 2 != 0)
            { 
            int mid=square_Number+1 / 2;
                while (mid == taken_Number)
                {
                    Console.WriteLine(" Taken Number is:->" + mid);
                    return mid;
                }
                if (mid > 0)
                { 
                
                }
            }
            else
            {
                int mid = square_Number / 2;
                while (mid == taken_Number)
                {
                    Console.WriteLine(" Taken Number is:->" + mid);
                    return mid;
                }
                if (mid > 0)
                {

                }
            }
            return -1;
        }
    }
}
