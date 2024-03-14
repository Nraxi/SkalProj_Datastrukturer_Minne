namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        static List<string> items = new List<string>();
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void PrintList()
        {

            Console.WriteLine($"List count: {items.Count}");
            Console.WriteLine($"List capacity: {items.Capacity}\n");

        }
        static void ExamineList()
        {
            while (true)
            {
                Console.WriteLine("Use + to add, - to remove, or 0 to exit.");
                string input = Console.ReadLine()!;

                if (!string.IsNullOrEmpty(input))
                {
                    char nav = input[0];
                    string value = input.Substring(1).Trim();

                    switch (nav)
                    {
                        case '+':
                            if (!string.IsNullOrEmpty(value))
                            {
                                items.Add(value);
                                Console.WriteLine($"Added {value} to the list.");
                                PrintList();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please provide a valid item name.");
                            }
                            break;
                        case '-':
                            if (!string.IsNullOrEmpty(value))
                            {
                                if (items.Remove(value))
                                {
                                    Console.WriteLine($"Removed {value} from the list.");
                                    PrintList();
                                }
                                else
                                {
                                    Console.WriteLine($"{value} was not found in the list.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please provide a valid item name.");
                            }
                            break;
                        case '0':
                            return;
                        default:
                            Console.WriteLine("Invalid input. Please use only '+' or '-' to add or remove items.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please provide a valid input.");
                }
            }
        
        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch statement with cases '+' and '-'
         * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
         * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
         * In both cases, look at the count and capacity of the list
         * As a default case, tell them to use only + or -
         * Below you can see some inspirational code to begin working.
        */

        //List<string> theList = new List<string>();
        //string input = Console.ReadLine();
        //char nav = input[0];
        //string value = input.substring(1);

        //switch(nav){...}


    }

        /// <summary>
        /// Examines the datastructure Queue

        //2. kapaciteten ökar när värdet överskrider arrays/listans total storlek.
        //(när den är full ). 

        //3. dubbelt så mycket.

        //4. för att det skall bli mer effektiv och snabbare.
        //Slippa eittera kopiare delen allt för ofta för det tar engergi / tid.


        //5. Nej listan kommer behålla sin kapacitet som den har blivit satt till.

        //6. När det är en fixed mängd. Alternativt att man vill att det skall gå fortare. Då en array tar mindre minne. 
        // TISDAG EM ska denna in. 
        /// </summary>
        static void ExamineQueue()
        {

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

