using System;
using AgorithmsProblems;
public class Program
{
    const string FILE_PATH = @"D:\AlgorithmProblemsStatement\ProgramAndAlgorithms\AlgorithmsAndProblems\Utility\Contant.txt";
    public static void Main(String[] args)
    {
        Console.WriteLine(" ####### WELCOME IN THE PROGRAMS AND ALGORITHMS ####### ");

        bool check = true;
        while (check)
        {
            Console.WriteLine(" Binary Search 1\n");
            Console.WriteLine("Enter the Above Optionb to the Excute the program");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SearchingElements search = new SearchingElements();
                    string input_String = File.ReadAllText(FILE_PATH);
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
                case 0:
                    check = false;
                    break;
            }
        }
    }
}