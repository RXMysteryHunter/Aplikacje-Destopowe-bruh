using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Pętle:
1.Program sprawdzający czy podana liczba jest liczbą pierwszą (czyli taką, która dzieli się tylko przez 1 i przez siebie samą)
2.Program sprawdzający czy podany ciąg znaków jest palindromem (czyli takim, który czytany od tyłu jest taki sam, jak czytany od przodu, np. "kajak")
3.Program sprawdzający czy podane dwa słowa są anagramami (czyli takimi, które zawierają te same litery, ale w innym układzie, np. "klasa" i "salka")
4.Program sprawdzający czy podana liczba jest liczbą doskonałą (czyli taką, której suma dzielników (z wyłączeniem samej siebie) jest równa danej liczbie, np. 6 jest liczbą doskonałą, ponieważ 1 + 2 + 3 = 6).
*/


namespace LotOfTasks
{
    class zadPetla
    {
        public void zadPetla1()
        {
            Console.WriteLine("Podaj liczbe");
            string num1 = Console.ReadLine();
            int num = int.Parse(num1);

            int i = 1;

            while (i < num)
            {
                if (num % i == 0)
                {
                    Console.Write("Liczba nie jest liczba  pierwsza");
                    i++;
                }
                else
                {

                    Console.Write("Liczba jest liczba pierwszza");
                    i++;
                }

            }



        }

        public void zadPetla2()
        {
            Console.WriteLine("Podaj wyraz\n");
            string wyraz = Console.ReadLine();


            string wyrazWspak = "";
            for (int i = wyraz.Length - 1; i >= 0; i--)
                wyrazWspak = wyrazWspak + wyraz[i];

            Console.WriteLine(wyraz);
            Console.WriteLine("wyraz wspak " + wyrazWspak);

            if (wyraz == wyrazWspak)
                Console.Write("To jest palindrom\n");
            else
                Console.Write("To nie jest palindrom\n");
        }



    }
}
