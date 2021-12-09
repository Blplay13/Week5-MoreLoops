using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginNavigation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnust ja salasona
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasona on "admin1234"
            //siis programm konsoolis kuvab "Tere tulemast!"
            //muud juhul konsoolis kuvatakse "Vale kasutajatunnus voi salasona. Proovi uuesti."
            // kasutaja on kolm katset;

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasona:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!:");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus voi salasona. Proovi uuesti. Teil on veel {3 - i} katset on jaanud");
                }
            }
        }
    }
}
