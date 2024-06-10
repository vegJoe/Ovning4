using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /*
         * Q&A
         * 1. Stacken tillåter bara programmet att läsa eller lägga till från toppen av call stacken, ungefär som en stapel med lådor.
         * Heapen tillåter programmet att spara och läsa data från på ett mer flexibelt sätt, mer som en korg full av saker. Det gör dock heapen långsammare än stacken.
         * Heapen kan också spara data längre medan stacken slänger allt när den är klar med det. Det gör att heapen behöver en garbage collector så att data som inte används
         * eller är accessbart längre inte ligger och tar upp minne i onödan.
         * 
         * 2. Reference Types ligger alltid på heapen, Value Types ligger i många fall på stacken men kan även ligga på heapen om dom är deklarerade i en klass eller som globala variabler.
         * Reference type är också tekniskt sett bara en pekare som generellt sett sparas på stacken, men pekar på minnesadress i heapen.
         * 
         * 3. Första har allokerade utrymmen på stacken, andra kopierar man referens till minne på heapen. När man då ändrar värdet på ena objektet så skrivs det till en delad
         * minnesplats och skrivs därmed över.
         */
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
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            bool running = true;
            string input;
            char nav;
            string value;

            while (running)
            {
                Console.Write("Input text with +, remove text with -:");
                input = Console.ReadLine()!;
                nav = input[0];
                value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                }

                Console.Write("Keep running y/n?: ");
                //running = (Console.Read() == 121) ? true : false;
                string question = Console.ReadLine()!;
                if (question == "y")
                    running = true;
                else
                    running = false;

                /*
                 * 2. theList ökar i storlek efter 4 entries
                 * 3. den ökar med det dubbla
                 * 4. den behöver en buffert
                 * 5. nej
                 * 6. när större datamängder ska lagras och man vet vart gränsen går.
                 */
                int i = theList.Capacity;
            }
     }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            bool running = true;
            Queue queue = new Queue();
            string input;
            int loop = 0;

            while (running)
            {
                Console.Write("Add person to que with \"add\", remove person with \"leave\":");
                input = Console.ReadLine()!;

                //int som ökar för att addera ett unikt värde så det är lättare att se vad som händer
                loop++;

                //switch case som kollar input och lägger till en person i kö-klassen eller tar bort den första som lades till
                switch(input)
                {
                    case "add":
                        queue.Enqueue("que" + loop.ToString()); 
                        break;
                    case "leave":
                        queue.Dequeue();
                        break;
                }

                Console.Write("Keep running y/n?: ");
                string question = Console.ReadLine()!;
                if (question == "y")
                    running = true;
                else
                    running = false;
            }
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
            bool running = true;
            Stack queue = new Stack();
            string input;
            int loop = 0;

            while (running)
            {
                Console.Write("Add person to que with \"add\", remove person with \"leave\":");
                input = Console.ReadLine()!;

                //int som ökar för att addera ett unikt värde så det är lättare att se vad som händer
                loop++;

                //switch case som kollar input och lägger till en person i kö-klassen eller tar bort den sista som lades till
                //1. Ej smart då första som hamnade i kön kommer så kvar i kön tills alla andra före har lämnat.
                //
                switch (input)
                {
                    case "add":
                        queue.Push("que" + loop.ToString());
                        break;
                    case "leave":
                        queue.Pop();
                         break;
                    case "reverse":
                        ReverseText(); 
                        break;
                }

                Console.Write("Keep running y/n?: ");
                string question = Console.ReadLine()!;
                if (question == "y")
                    running = true;
                else
                    running = false;
            }
        }

        private static void ReverseText()
        {
            Stack stack1 = new Stack();

            Console.Write("Input text: ");
            string readText = Console.ReadLine()!;

            //for loop som lägger till varje karaktär i strängen in i queue objektet
            for(int i = 0; i < readText.Length;  i++)
            {
                stack1.Push(readText[i]);
            }
            //int variable deklarerad utanför for loopen då storleken på queue1 successivt minskar i takt med att man läser ut
            int loop = stack1.Count;
            //skriver ut texten i omvänd ordning
            for (int i = 0; i < loop; i++)
            {
                Console.Write(stack1.Pop());
            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            //1. Stacken känns som den mest rimliga att använda då man automatiskt får en reverse order när man kopierar elementen

            Stack stack1 = new Stack();
            StringBuilder strTst = new StringBuilder();
            bool same;


            Console.Write("Input string of parenthesis to determin if it's mirrored: ");
            string readText = Console.ReadLine()!;

            //for loop som lägger till 50% av de tidigaste inmatade paranteserna från sträng till stack obj
            for (int i = 0; i < (readText.Length / 2); i++)
            {
                stack1.Push(readText[i]);
            }

            int loop = stack1.Count;
            //skriver ut det som ligger på stack objektet i omvänd ordning till en ny sträng
            for (int i = 0; i < loop; i++)
            {
                strTst.Append(stack1.Pop());
            }

            //Kopierar in andra halvan av inläst text
            string compare = readText.Substring((readText.Length / 2), (readText.Length / 2));

            //int varibel används för att se hur många gånger if satsen slog in, om den i slutändan var samma som hälften av totala inmatade karaktärerna
            //så var det rätt uppsättning paranteser
            int test = 0;


            //loop som går igenom och jämför karaktärerna i strängarna, om dom har motsatt parantes så ökar int test med ett.
            for(int i = 0; i < compare.Length; i++)
            {
                if (strTst[i].ToString() == "["  && compare[i] == ']'
                    || strTst[i].ToString() == "{" && compare[i] == '}'
                    || strTst[i].ToString() == "(" && compare[i] == ')')
                {
                    test++;
                }
            }
            same = (test == compare.Length) ? true : false;

            Console.Write($"Result was {same}");

        }
    }
}

