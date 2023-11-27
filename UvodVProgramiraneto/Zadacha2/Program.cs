using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislo za den ot sedmicata");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1 :Console.WriteLine("Ponedelnik");break;
                case 2: Console.WriteLine("Vtornik"); break;
                case 3: Console.WriteLine("Srqda"); break;
                case 4: Console.WriteLine("Chetvurtuk"); break;
                case 5: Console.WriteLine("Petuk"); break;
                case 6: Console.WriteLine("Subota"); break;
                case 7: Console.WriteLine("Nedelq"); break;
                    default: Console.WriteLine("Nevalidni vhodni danni");break;

            }
        }
    }
}
