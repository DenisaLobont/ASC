using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            uint n; //natural

            Console.WriteLine(" Introduceti un numar natural n, pentru a afla in cat timp tranzistoarele vor deveni  de n-ori mai puterice fata de zilele noastre:");
            while (true)
            {
                Console.Write("Introduceti un numar natural:");
                input =Console.ReadLine();
                //folosim TryParse pentru a consulta daca input-ul este un numar natural, sau nu.
                if (uint.TryParse(input, out n))
                {
                    double ani; // real
                    ani = 1.5 * Math.Log(n, 2); 
                    Console.WriteLine("Tranzistoarele vor fi mai rapide de " + n + " ori in " + ani + " ani");
                    Console.WriteLine("Tranzistoarele vor fi mai rapide de {0} ori in {1} ani",n,ani);
                    break;
                }
                else
                {
                    Console.WriteLine("Introduceti un numar natural!\n");
                    //se va repeta pana cand utilizatorul introduce un numar natural.
                }
            }
        }
    }
}
