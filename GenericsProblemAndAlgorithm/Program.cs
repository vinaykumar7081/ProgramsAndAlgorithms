using System;
using GenericsProblemAndAlgorithm;
public class Program

{
    const string FILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\GenericsProblemAndAlgorithm\Utility\Contents.txt";
    public static void Main(String[] args)
    {
        Console.WriteLine(" ####### WELCOME IN THE PROGRAMS AND ALGORITHMS ####### ");
        GenericsProblemAndAlgorithm.LinkedListOperation<string> operation = new GenericsProblemAndAlgorithm.LinkedListOperation<string>();
        LinkedList<string> lists = new LinkedList<string>();
        bool check = true;
        while (check)
        {
            Console.WriteLine("Display List Elements 1\n");
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
                case 0:
                    check = false;
                    break;
            }
        }
    }
}
          