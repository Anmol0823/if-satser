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
            //Övning 1
            Console.WriteLine("Ange mönsterdjup på däck:");
            double djup = double.Parse(Console.ReadLine());

            if (djup < 1.6)
                Console.WriteLine("Olagliga däck!");
            else if (djup > 1.6)

                Console.WriteLine("Lagliga Däck!");

            //Övning2
            Console.WriteLine("Ange ålder så ska du få en färg på namnbricka:");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 13)
                Console.WriteLine("Vit");

            else if (ålder < 19 && ålder > 12) 
                Console.WriteLine("Grön"); 

            else if (ålder< 25 && ålder> 18)
                Console.WriteLine("Röd");

            else if (ålder< 99 && ålder> 25)
                Console.WriteLine("Blå"); 

            else if (ålder > 99)
                Console.WriteLine("Utomjording");

            //Övning 3
            Console.WriteLine("Mata in det första av två tal");
            decimal tal1 = (decimal)(double.Parse(Console.ReadLine()));

            Console.WriteLine("Mata in ett andra tal");
            decimal tal2 = (decimal)(double.Parse(Console.ReadLine()));

            if (tal1 < tal2)
                Console.WriteLine("Tal 2 var störst");

            else if (tal1 > tal2)
                Console.WriteLine("Tal 1 var störst");

            else
                Console.WriteLine("Talen var lika stora");

            //Övning 4
            Console.WriteLine("Mata in ett tal:");
            string inmatat = Console.ReadLine();

            int a = int.Parse(inmatat);

            if (a % 7 == 0)
                Console.WriteLine("går att dela på 7 svar: " + a % 7);
           
            else 
                Console.WriteLine("går inte att dela med 7 rest: " + a % 7);
           





        }
    }
}
    