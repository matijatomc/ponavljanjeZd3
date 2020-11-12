using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPonavljanjeZd3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] niz = new string[3];

            Console.WriteLine("Upišite prvi string:");
            niz[0] = Console.ReadLine();

            Console.WriteLine("Upišite drugi string:");
            niz[1] = Console.ReadLine();

            Console.WriteLine("Upišite treci string:");
            niz[2] = Console.ReadLine();

            Array.Sort(niz);
            Array.Reverse(niz);

            Console.WriteLine("Sortirani stringovi:");
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(niz[i]);
            }
            Console.ReadKey();
        }
    }
}
