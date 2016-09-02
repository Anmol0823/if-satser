using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖVNING 1
            Console.WriteLine("Ange mönsterdjup på däck:");
            double djup = double.Parse(Console.ReadLine());

            if (djup < 1.6)
                Console.WriteLine("Olagliga däck!");
            else if (djup > 1.6)
            
                Console.WriteLine("Lagliga Däck!");

            //Övning2


        }
    }
}
    