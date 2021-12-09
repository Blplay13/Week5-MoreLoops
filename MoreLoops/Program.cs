using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnust ja salasona
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasona on "admin1234"
            //siis programm konsoolis kuvab "Tere tulemast!"
            //muud juhul konsoolis kuvatakse "Vale kasutajatunnus voi salasona. Proovi uuesti."

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasona:");
            string userPassword = Console.ReadLine();

            //AND(&&)voi OR

            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234"--> false
            //"admin" AND "admin2345" -- >false
            //"adminn" AND "admin987" --> false

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajtunnus voi salasona. Proovi uuesti.");
            }

        }
    }
}
