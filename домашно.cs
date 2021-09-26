using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            int dec = Convert.ToInt32(bin, 2);
            string xec = Console.ReadLine();
            int dec1 = Convert.ToInt32(xec, 16);
            int SUMA = dec1 + dec;
            Console.WriteLine(SUMA);
        }
    }
}
