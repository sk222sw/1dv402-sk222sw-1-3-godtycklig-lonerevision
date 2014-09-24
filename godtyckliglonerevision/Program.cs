using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace godtyckliglonerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarerar variabler
            //Array med antal löner
            int numberOfSalaries = 0;

            //Antal löner att mata in: 
            do  //Main-while: För att avsluta eller göra om
            {
                numberOfSalaries = ReadInt("Ange antalet löner: ");
                Console.WriteLine();
                if (numberOfSalaries > 1)
                {
                    ProcessSalaries(numberOfSalaries);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine();

                    Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;

                Console.WriteLine();
                Console.WriteLine("Tryck valfri tangent för ny beräkning - Esc avslutar");

                Console.ResetColor();
                Console.WriteLine();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape); // main-while slut

        }/////////// Main slut

        //Används för att läsa in användardata
        static int ReadInt(string prompt)
        {
            string userInput = null;
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    userInput = Console.ReadLine();
                    return int.Parse(userInput);

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("FEL! '{0}' kan inte tolkas som ett heltal. ", userInput);
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }

        }///////// ReadInt slut

        //ProcessSalaries() = läs in antalet löner. -> beräkna median, medel och lönespridning. -> skriv ut lönerna under. 
        static void ProcessSalaries(int numberOfSalaries)
        {
            int[] salaries = new int[numberOfSalaries];

            for (int salaryCounter = 0; salaryCounter < salaries.Length; salaryCounter++)
            {
                salaries[salaryCounter] = ReadInt("Ange lön nummer " + (salaryCounter + 1) + ": ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");

            //Medianlön:             
            int[] salariesSorted = new int[numberOfSalaries];

            //salariesSorted = salaries;
            Array.Copy(salaries, salariesSorted, salaries.Length);

            Array.Sort(salariesSorted);

            if (salariesSorted.Length % 2 == 1)
            {
                int length;
                length = salariesSorted.Length / 2;
                Console.WriteLine("Medianlön:     {0, 10:c0}", salariesSorted[length]);
            }
            else
            {
                int length1;
                int length2;

                length1 = salariesSorted.Length / 2;
                length2 = salariesSorted.Length / 2 - 1;

                int median = 0;
                median = (salariesSorted[length1] + salariesSorted[length2]) / 2;

                Console.WriteLine("Medianlön:     {0, 10:c0}", median);
            }

            //Average:
            Console.WriteLine("Medellön:      {0, 10:c0}", salaries.Average());

            //Spread:
            int salarySpread = salaries.Max() - salaries.Min();
            Console.WriteLine("Lönespridning: {0, 10:c0}", salarySpread);
            Console.WriteLine("-------------------------------");

            //Skriv ut lönerna med tre på varje rad:
            for (int salaryPrint = 0; salaryPrint < salaries.Length; salaryPrint++)
            {
                if (salaryPrint % 3 == 0)
                {
                    Console.WriteLine();
                    Console.Write("  {0, 6} ", salaries[salaryPrint]);
                }
                else
                {
                    Console.Write("  {0, 6} ", salaries[salaryPrint]);
                }
            }
            Console.WriteLine();
        }  //////////ProcessSalaries slut

    }
}
