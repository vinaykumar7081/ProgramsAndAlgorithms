using System;
using GenericsProblemAndAlgorithm;
public class Program

{
    const string STACKFILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\GenericsProblemAndAlgorithm\Utility\stackElements'.txt";
    public static void Main(String[] args)
    {
        Console.WriteLine(" ####### WELCOME IN THE PROGRAMS AND ALGORITHMS ####### ");
        LinkedList<string> linkedLists = new LinkedList<string>();
        StackOpration<string> stack = new StackOpration<string>();
        bool check = true;
        while (check)
        {
            Console.WriteLine(" Adding Elements in Stack 1\n Displaying Stack Elements 2\n Checking for the Parenthesys 3\n ComparingParenthesysy 4\n");
        
            Console.WriteLine("Enter the Above Optionb to the Excute the program");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string expression = File.ReadAllText(STACKFILE_PATH);
                    string[] Expression_Array = expression.Split(',');
                    foreach (string s in Expression_Array)
                    { 
                    stack.Push(s);
                    }
                    break;
                case 2:
                    stack.Display();
                    break;
                case 3:
                    stack.BalancedParenthesys();
                    break;

                case 4:
                    stack.ComparingParenthesys();
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}
          