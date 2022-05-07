using System;
using AgorithmsProblems;
public class Program
{
    const string FILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\AgorithmsProblems\Utility\Content.txt";
    public static void Main(String[] args)
    {
        Console.WriteLine(" ####### WELCOME IN THE PROGRAMS AND ALGORITHMS ####### ");
        SearchingElements search = new SearchingElements();
        string input_String = File.ReadAllText(FILE_PATH);
       
        bool check = true;
        while (check)
        {
            Console.WriteLine(" Binary Search 1\n Insertion Sort 2\n Bubble Sort 3\n Checking for Ananagram 4\n For Counting PrimeNumber 5\n");
            Console.WriteLine("Enter the Above Optionb to the Excute the program");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string[] array = input_String.Split(',');
                    int length = array.Length;
                    Console.WriteLine("Enter the word to Search");
                    string key = Console.ReadLine();
                    int result = search.BinarySearch(array, 0, length - 1, key);
                    if (result == -1)
                    {
                        Console.WriteLine(key + " word is present in the file");
                    }
                    else
                    {
                        Console.WriteLine(key + " Word is  not present ");
                    }
                    break;
                    case 2:
                    string[] input_Array = input_String.Split(',');
                    search.SortingElements(input_Array);
                    search.DisplayArrayElemnts(input_Array);
                    break;
                case 3:
                    string[] strins_array = input_String.Split(',');
                    search.SortingElements(strins_array);
                    search.DisplayArrayElemnts(strins_array);
                    break;
                case 4:
                    string first_word = "heart";
                    string second_word = "earth";
                    search.IsAnagram(first_word, second_word);
                    break;
                case 5:
                    Console.WriteLine("Enter the Range of the Number:->");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    search.IsPrime(firstNumber, secondNumber);
            

                   break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}