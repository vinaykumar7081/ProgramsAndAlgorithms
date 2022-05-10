using System;
using GenericsProblemAndAlgorithm;
public class Program

{
    const string STACKFILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\GenericsProblemAndAlgorithm\Utility\stackElements'.txt";
    const string QUEUEFILE_PATH = @"D:\AlgorithmProblems\ProgramsAndAlgorithms\GenericsProblemAndAlgorithm\Utility\Persons.txt";
    public static void Main(String[] args)
    {
        Console.WriteLine(" ####### WELCOME IN THE PROGRAMS AND ALGORITHMS ####### ");
        LinkedList<string> linkedLists = new LinkedList<string>();
        StackOpration<string> stack = new StackOpration<string>();
        GenericsProblemAndAlgorithm.Queue<string> queue = new GenericsProblemAndAlgorithm.Queue<string>();
        bool check = true;
        while (check)
        {
            Console.WriteLine(" Adding Elements in Stack 1\n Displaying Stack Elements 2\n Checking for the Parenthesys 3\n ComparingParenthesysy 4\n Displaying Queue Elements 5\n Debited Amount 6\n Credite Amount in Account 7\n");
        
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
                case 5:
                    string person_Queue = File.ReadAllText(QUEUEFILE_PATH);
                    string[] person_Array = person_Queue.Split(',');
                    foreach (string s in person_Array)
                    { 
                    queue.Enqueue(s);
                    }
                    break;
                case 6:
                    decimal total_Cash = 500000;
                    decimal minAmount = 1000;
                    decimal maxAmount = 35000;
                    queue.DepositeCashCounter(total_Cash, minAmount, maxAmount);
                    break;
                case 7:
                    decimal total_Cashes = 500000;
                    decimal credite_minAmount = 1000;
                    decimal credite_maxAmount = 50000;
                    queue.CrediteCashCounter(total_Cashes, credite_minAmount, credite_maxAmount);
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}
          