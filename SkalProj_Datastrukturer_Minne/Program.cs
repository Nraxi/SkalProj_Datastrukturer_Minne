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
                        Console.WriteLine("Exiting program...");

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
        /// 1. Stacken är som att du lägger tallrickar på varandra, det e alltid enkelt att nå den översta men aldrig den understa. 
        // 1. Medans Heapen är som en sopptunna där du slänger ner allt i, men den har bra med utrymmer men de e svårt o hitta saker. 
        // 2. Referenstyper är som att du har en lapp som perkar på vart saken är, medans en Value typ, är en egen bit med sitt eget värde. 
        // 2 det som skiljer dem åt är hur de används och vart de lagras i minnet. 
        // 3. Iomed att i det första så retunerar man värdet av en variabel och i den andra så retuneras ett värde av ett object. och man referear på ett object och inte på en variabel. samt att ordningen är annorlunda. 
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
            const int maxQueueSize = 5;
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("Current Queue:");
                PrintQueue(queue);

                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a person to the queue");
                Console.WriteLine("2. Process the first person in the queue");
                Console.WriteLine("3. Exit");

                Console.Write("\nEnter your choice: ");
                string input = Console.ReadLine()!;
                int choice;
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            if (queue.Count >= maxQueueSize)
                            {
                                Console.WriteLine("Queue is full. The first person will be removed.");
                                queue.Dequeue();
                            }
                            Console.Write("Enter person's name to add to the queue: ");
                            string person = Console.ReadLine()!;
                            queue.Enqueue(person);
                            break;
                        case 2:
                            if (queue.Count > 0)
                            {
                                string removedPerson = queue.Dequeue();
                                Console.WriteLine($"Processed: {removedPerson}");
                            }
                            else
                            {
                                Console.WriteLine("Queue is empty.");
                            }
                            break;
                        case 3:
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.Clear();
                }
            }

           
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            static void PrintQueue(Queue<string> queue)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Queue is empty.");
                }
                else
                {
                    foreach (var person in queue)
                    {
                        Console.WriteLine(person);
                    }
                }

            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            const int maxStackSize = 4;
            Stack<string> stack = new Stack<string>();
            string reversedString = "";
            while (true)
            {
                Console.WriteLine("Current Stack:");
                PrintStack(stack);
               

                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a person to the stack");
                Console.WriteLine("2. Process the last person in the stack");
                Console.WriteLine("3. Rev strings");
                Console.WriteLine("4. Exit");



                Console.Write("\nEnter your choice: ");

                string input = Console.ReadLine()!;
                int choice;
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            if (stack.Count >= maxStackSize)
                            {
                                Console.WriteLine("Stack is full. The last person will be removed.");
                                stack.Pop();
                            }
                            Console.Write("Enter person's name to add to the stack: ");
                            string person = Console.ReadLine()!;
                            stack.Push(person);
                            break;

                        case 2:
                            if (stack.Count > 0)
                            {
                                stack.Pop();
                            }
                            else
                            {
                                Console.WriteLine("Stack is empty.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter a string to reverse, then press enter:");
                            string inputString = Console.ReadLine()!;
                            reversedString = ReverseText(inputString);


                            break;
                            
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine("Result of Reversed string: " + reversedString);
                }
            }
        }

        static void PrintStack(Stack<string> stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                foreach (var person in stack)
                {
                    Console.WriteLine(person);
                }
            }
        }
    
        static string ReverseText(string input)
        {
            string[] words = input.Split();
            List<string> reversedWords = new List<string>();

            foreach (string word in words)
            {
                Stack<char> stack = new Stack<char>(word.ToCharArray());
                string reversedWord = "";

                while (stack.Count > 0)
                {
                    reversedWord += stack.Pop();
                }

                reversedWords.Add(reversedWord);
            }

            string reversedString = string.Join(" ", reversedWords);
            return reversedString;
        }

        /// <summary>
        /// 1. För att du hela tiden tar bort den sista användaren, med andra ord varför ha ett sånt kö system, då skulle alltid den sista få betala medans den som kom först alltid får vänta till sist om man inte aktivt säger nu ska vi ta bort den personen. 
        /// Så med andra ord tids effiktivetet. och minnes kapacitet. 
        /// 2.Detta är min tolkning på den. 
        /// </summary>
     /*
     * Loop this method until the user inputs something to exit to main menue.
     * Create a switch with cases to push or pop items
     * Make sure to look at the stack after pushing and and poping to see how it behaves
    */
        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }
        // 1. Jag skulle använda mig utav en stack. Då den kan hantera paranteserna bättre. 
        

    }
}

