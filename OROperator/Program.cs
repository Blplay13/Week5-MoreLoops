using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnust ja salasona
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasona on "admin1234"
            //siis programm konsoolis kuvab "Tere tulemast!"
            //muud juhul konsoolis kuvatakse "Vale kasutajatunnus voi salasona. Proovi uuesti."

            //AND(&&) || (pipes)

            //true || true --> true
            // false || true --> true
            // true || false --> true
            // false || false --> false

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasona:");
            string userpassword = Console.ReadLine();

            if(userName != "admin" || userpassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            //"admin1" !="admin" || "admin1234" != "admin1234" --> true || false --> true
            //"admin" !="admin" || "admin123" != "admin1234" --> false || true -->true
            //"admin1" !="admin" || "admin123" != "admin1234" --> || false-->false



          
        }
    }
}
