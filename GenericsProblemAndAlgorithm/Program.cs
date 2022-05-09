using System;
using GenericsProblemAndAlgorithm;
public class Program

{
    const string FILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\GenericsProblemAndAlgorithm\Utility\Contents.txt";
    const string NUMBERFILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\GenericsProblemAndAlgorithm\Utility\integer.txt";
    public static void Main(String[] args)
    {
        Console.WriteLine(" ####### WELCOME IN THE PROGRAMS AND ALGORITHMS ####### ");
        GenericsProblemAndAlgorithm.LinkedListOperation<string> operation = new GenericsProblemAndAlgorithm.LinkedListOperation<string>();
        LinkedLists<string> linkedLists = new LinkedLists<string>();
        LinkedList<string> lists = new LinkedList<string>();
        LinkedList<string> input_Lists = new LinkedList<string>();
        bool check = true;
        while (check)
        {
            Console.WriteLine("Display List Elements 1\n Additino elements in the list2\n Removing the present Elements in  the List 3\n Adding new elements in  the list 4\n Adding integer elements in the list 5\n");
            Console.WriteLine("Enter the Above Optionb to the Excute the program");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string input_String = File.ReadAllText(FILE_PATH);
                    string[] array = input_String.Split(',');
                    foreach (string s in array)
                    {
                        lists.AddLast(s);
                    }
                    operation.AddingElements(lists);
                    break;
                case 2:
                    operation.Display();
                    break;
                case 3:
                    Console.WriteLine("Enter the Word to Search in the List");
                    string input_string = Console.ReadLine();
                    operation.Check_Removing_PresentElements(input_string);
                        break;
                case 4:
                    Console.WriteLine("Enter the Word to Search in the List");
                    string input_strings = Console.ReadLine();
                    operation.Check_Added_NewElement(input_strings);
                    break;
                case 5:
                    string integer_String = File.ReadAllText(NUMBERFILE_PATH);
                    string[] integer_Array = integer_String.Split(',');
                   
                    foreach (string s in integer_Array)
                    {
                        linkedLists.AddNode(s);
                    }
                    linkedLists.DisplaySortedList();
                    break;
                case 6:
                    linkedLists.SortOrderList();
                    break;
                case 8:
                    Console.WriteLine("Enter the Number to Search in the List");
                    string input = Console.ReadLine();
                    int node = linkedLists.Search("input");
                    
                        if (node == 0)
                        {
                            linkedLists.Append(input);
                        }
                    
                    break;
                case 7:
                   int length=linkedLists.Size();
                    Console.WriteLine("Size of the List is:->"+length);
                    break;
                case 9:
                    Console.WriteLine("Enter the Number to Search in the List");
                    string input_Data = Console.ReadLine();
                    int search = linkedLists.Search(input_Data);
                    linkedLists.Size();
                    linkedLists.DisplaySortedList();
                    linkedLists.DeleteNodeAtPerticularPosition(search);
                    linkedLists.Size();
                    linkedLists.DisplaySortedList();
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}
          