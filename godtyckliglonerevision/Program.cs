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
        numberOfSalaries = ReadInt("Ange antalet löner: ");
        while (true)
        {
            if (numberOfSalaries > 1)
            {
                    ProcessSalaries(numberOfSalaries);
                    break;
            }
            else
            {
                Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                Console.WriteLine("Tryck valfri tangent för ny beräkning - Esc avslutar");
                if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                {
                    
                } 
            }
            break;
        }

        //Ange lön nummer int
        
        //Skriv ut medianlön

        //Medellön

        //Lönespridning


        //Skriv ut lönerna, tre per rad

        }/////////// Main slut


        //Två metoder:

        //ReadInt() = användaren matar in antal löner. Användaren matar in löner. 
            //Felmeddelande om färre än 2.
            //Felmeddelande om det inte är en int
            //Anropa ProcessSalaries() med antal löner som argument

        static int ReadInt (string prompt)
        {
            int input;
            Console.Write(prompt);
            input = int.Parse(Console.ReadLine());
            return input;
        }


        //ProcessSalaries() = läs in antalet löner. -> beräkna median, medel och lönespridning. -> skriv ut lönerna under. 

        static void ProcessSalaries(int numberOfSalaries)
        {
            int[] salaries = new int[numberOfSalaries];
            


            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = ReadInt("Ange lön nummer " + (i+1) + ": ");
            }
            Console.WriteLine("-----------------------");
            int salarySpread = salaries.Max() - salaries.Min();
            int[] salariesSorted = salaries;
            Array.Sort(salariesSorted);

            Console.WriteLine("Medellön: {0}", salaries.Average());
            Console.WriteLine("Max {0} Min {1} Sprid {2}: ", salaries.Max(), salaries.Min(), salarySpread);

            Console.WriteLine("-----------------------");

            for (int i = 0; i < salaries.Length; i++)   //Skriv ut lönerna med tre på varje rad. 
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                    Console.Write("{0} ", salaries[i]);
                }
                else
                {
                    Console.Write("{0} ", salaries[i]);
                }
                
            }
            Console.WriteLine();
        }

    }
}
