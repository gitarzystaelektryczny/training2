using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Logic
    {
        Random rand = new Random();
        public string Wynik { get; set; }

        public void Losuj()
        {
            
            int[] tab = new int[6];
            Wynik = null;
            int a;

            for (int i = 0; i < 6; i++)
            {
                //wydaje mi się, że zakres musi być o jedną liczbę większą ;)
                a = rand.Next(1, 7); 

                //też nie wiedziałem, że jest taka metoda Contains();
                if (!tab.Contains(a))
                { tab[i] = a;                    
                  Wynik += (tab[i] + " ");
                }
                else
                {
                    //sprytny patent z dekrementacją - sam na to nie wpadłem
                    i--;                   
                }                                            
            }
        }
    }
    
}
