using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2App
{
    class Program
    {
        



        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj a: " );
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Dodawanie oDodawanie = new Dodawanie();                       
            Console.WriteLine(oDodawanie.Dzialanie(a, b));
            int c = oDodawanie.Dzialanie(a, b);
            Console.ReadLine();


            Odejmowanie oOdejmowanie = new Odejmowanie(a, b);
            Console.WriteLine("Propercje A oraz B: {0} oraz {1}", oOdejmowanie.A, oOdejmowanie.B);
            Console.WriteLine("Odejmowanie A - B: {0}", (oOdejmowanie.A - oOdejmowanie.B));
            int d = oOdejmowanie.A - oOdejmowanie.B;
            Console.ReadLine();

            Mnozenie oMnozenie = new Mnozenie(c, d);
            Console.WriteLine("Mnożenie: {0}", (oMnozenie.A * oMnozenie.B));
            Console.ReadLine();
        }
    }
}
