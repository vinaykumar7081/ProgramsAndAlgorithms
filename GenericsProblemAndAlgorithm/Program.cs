using System;
using GenericsProblemAndAlgorithm;
public class Program

{
    const string FILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\GenericsProblemAndAlgorithm\Utility\Contents.txt";
    const string NUMBERFILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\GenericsProblemAndAlgorithm\Utility\integer.txt";
    public static void Main(String[] args)
    {
        Console.WriteLine(" ####### WELCOME IN THE PROGRAMS AND ALGORITHMS ####### ");
        LinkedLists<string> linkedLists = new LinkedLists<string>();
        PerformTheOperation performTheOperation = new PerformTheOperation();
        bool check = true;
        while (check)
        {
            Console.WriteLine("1. Addinng elements in the LinkedList \n 2. Performing The Operation in the LinkedList\n");
            Console.WriteLine("Enter the Above Optionb to the Excute the program");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string input_Strings = File.ReadAllText(FILE_PATH);
                    string[] arrays = input_Strings.Split(',');
                    performTheOperation.AddArraysElementsInList( arrays);
                    break;
                case 2:
                    Console.WriteLine("Enter the Word to insertion or Deletion performing the Operation in the LinkedList");
                    string input_string = Console.ReadLine();
                    performTheOperation.CheckingAndInsertingElementsInList(input_string);
                        break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}
          