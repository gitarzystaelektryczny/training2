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
            Console.ReadLine();
        }
    }
}
