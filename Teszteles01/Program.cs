using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszteles01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot:");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine(Negyzet(szam));
            Console.ReadLine();
        }

        public static int Negyzet(int szam)
        {
            return szam * szam;
        }
    }
}
