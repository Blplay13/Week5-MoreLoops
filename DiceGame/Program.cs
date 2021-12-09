using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //manugs osaleb kaks mangijat - arvuti (CPU) ja kasutaja (user)
            //molemad mangijad viskavad taringut;
            //programm kontrollib, kumb mangija viskas rohkem
            //mangija, kes viskab rohkem, on voitja
            //*taringuid visatakse 3 korda
            //programm kuulutab voitja

            Random rnd = new Random();

            int cpuScoreSUM = 0;
            int userScoreSUM = 0;

            int i = 0;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Vajutage klahvi, et taringut veeretada:");
                Console.ReadLine();

                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                cpuScoreSUM = cpuScoreSUM + cpuRandom;
                userScoreSUM = userScoreSUM + userRandom;
            }

            Console.WriteLine($"Arvuti skoor on: {cpuScoreSUM}");
            Console.WriteLine($"Kasutaja skoor on: {userScoreSUM}");

            if(cpuScoreSUM < userScoreSUM)
            {
                Console.WriteLine("Kasutaja on voitnud. Palju onne!");

            }

            else if(cpuScoreSUM > userScoreSUM)
            {
                Console.WriteLine("Arvuti voitis mangu.");
            }
            else
            {
                Console.WriteLine("Mang on mangitud viiki!");
            }


            

        }
    }
}
