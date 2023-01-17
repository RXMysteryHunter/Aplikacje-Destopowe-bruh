using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.Program wyświetlający na ekranie kolejne liczby naturalne od 1 do 10
2.Program obliczający sumę liczb od 1 do 100
3. Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.)
4.Program wyświetlający na ekranie silnie z liczb od 1 do 10 (np. 1!, 2!, 3!, 4! itd.)
5.Program wyświetlający na ekranie tabliczkę mnożenia od 1 do 9 (np. 1x1=1, 1x2=2, 1x3=3 itd.).
6.Program wyświetlający na ekranie wszystkie liczby podzielne przez 3 z zakresu od 1 do 100
7.Program obliczający sumę kwadratów liczb od 1 do 10
8. Program wyświetlający na ekranie ciąg Fibonacciego do 20 elementu (ciąg Fibonacciego to ciąg gdzie każdy element jest sumą dwóch poprzednich, np. 0, 1, 1, 2, 3, 5, 8, 13 itd.)
9.Program wyświetlający na ekranie kolejne potęgi 2 od 2^0 do 2^10 (np. 2^0, 2^1, 2^2 itd.)
10.Program wyświetlający na ekranie kolejne elementy ciągu a_n = a_{n-1} +a_{ n - 2}, gdzie a_0 = 1, a_1 = 1(ciąg ten zaczyna się od 1, 1, 2, 3, 5, 8, 13 itd.).
*/



namespace LotOfTasks
{
    class zadFor
    {
        public void zadFor1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);

            }

        }

        public void zadFor2()
        {
            int suma = 0;

            for (int i = 0; i <= 100; i++)
            {
                suma += i;

            }
            Console.WriteLine(suma);
        }

        public void zadFor3()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i * i);
            }

        }

        public void zadFor4()
        {
            int silnia = 1;

            for (int i = 1; i <= 10; i++)
            {
                silnia *= i;
                Console.WriteLine(silnia);
            }

        }

       /* public void zadFor5()
        {
            int i;
            int j;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i);
                for (int i = 1; i < 10; i++)
                {
                    Console.Write(i);
                    for (j = 1; j = 10; j++)
                    {
                        Console.WriteLine(i * j);
                    }
                }

            }

        }
       */

        public void zadFor6()
        {

            for (int i = 0; i <= 10; i++)
            {
                

            }

        }

    }
}
