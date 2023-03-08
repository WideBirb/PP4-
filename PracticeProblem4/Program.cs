using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            List<int> random_List   = new List<int>();
            List<int> unique_List   = new List<int>();
            bool isDuplicate        = false;

            // Populate the random List with numbers
            while (random_List.Count < 100)
                random_List.Add(random.Next(0,100) + 1);

            // Check for unique numbers 
            for (int i = 0; i < random_List.Count; i++)
            {

                isDuplicate = false; // reset
                for (int j = 0; j < random_List.Count; j++)
                {
                    // Compares the number to the rest of the list && Avoids self checking
                    if ((random_List[i] == random_List[j]) && (i != j))
                    {
                        isDuplicate = true;
                        break;
                    }   
                }

                // Moves unique numbers to unique list
                if (isDuplicate == false)
                    unique_List.Add(random_List[i]);

            }

            // Displays the random list
            Console.Write("Random List");
            for (int i = 0; i < random_List.Count; i++)
            {
                // Formatting
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write(random_List[i] + "\t");
            }

            Console.WriteLine();

            // Displays the unique list
            Console.Write("Unique List");
            for (int i = 0; i < unique_List.Count; i++)
            {
                // Formatting
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write(unique_List[i] + "\t");
            }

        }
    }
}