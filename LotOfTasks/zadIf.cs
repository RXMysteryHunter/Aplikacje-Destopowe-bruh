using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Instrukcja If:
1.Program sprawdzający czy podana liczba jest parzysta czy nieparzysta
2. Program sprawdzający czy podana liczba jest dodatnia, ujemna czy równa zero
3. Program sprawdzający czy podany rok jest rokiem przestępnym
4. Program wyświetlający odpowiedni komunikat w zależności od podanej oceny (np. "bardzo dobry" dla oceny 5, "dobry" dla oceny 4 itd.)
5.Program sprawdzający czy podane hasło jest poprawne (np. jeśli hasło jest "abc123", program powinien wyświetlić "hasło poprawne", jeśli jest inne, powinien wyświetlić "hasło niepoprawne").
6.Program sprawdzający czy podana data jest poprawna (np. sprawdzając, czy dzień jest z zakresu od 1 do 31, miesiąc od 1 do 12 itd.)
7.Program wyświetlający odpowiedni komunikat w zależności od podanej temperatury (np. "ciepło" dla temperatury powyżej 20 stopni Celsjusza, "chłodno" dla temperatury poniżej 10 stopni Celsjusza itd.)
Pętle:
1.Program sprawdzający czy podana liczba jest liczbą pierwszą (czyli taką, która dzieli się tylko przez 1 i przez siebie samą)
2.Program sprawdzający czy podany ciąg znaków jest palindromem (czyli takim, który czytany od tyłu jest taki sam, jak czytany od przodu, np. "kajak")
3.Program sprawdzający czy podane dwa słowa są anagramami (czyli takimi, które zawierają te same litery, ale w innym układzie, np. "klasa" i "salka")
4.Program sprawdzający czy podana liczba jest liczbą doskonałą (czyli taką, której suma dzielników (z wyłączeniem samej siebie) jest równa danej liczbie, np. 6 jest liczbą doskonałą, ponieważ 1 + 2 + 3 = 6).
Pętla for:
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
Pętla do-while:
1.Program pytający użytkownika o hasło i wyświetlający komunikat "hasło poprawne" lub "hasło niepoprawne" dopóki użytkownik nie poda poprawnego hasła (np. "abc123").
2.Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.) dopóki suma tych kwadratów nie przekroczy 1000.
Trudniejsze zadania:
1.Program implementujący algorytm szyfrowania Cezara (proste szyfrowanie, w którym każdy znak w tekście jest zastępowany innym znakiem, przesuniętym o stałą liczbę pozycji w alfabecie).
2.Program obliczający największy wspólny dzielnik (NWD) dwóch liczb
3. Program obliczający najmniejszą wspólną wielokrotność (NWW) dwóch liczb.
4. Program wyciągający informacje z numeru PESEL
5. Napisz program, który pobiera od użytkownika ciąg znaków i wyświetla liczbę samogłosek i spółgłosek w tym ciągu.
Dla zaawansowanych:
1. Program implementujący algorytm generowania liczb pseudolosowych (np.algorytm Mersenne Twister).
2.Algorytm szyfrowania AtBash Cipher - algorytm szyfrujący, w którym każda litera jest zamieniana na literę z przeciwnej strony alfabetu (np. A na Z, B na Y itd.)
3.Algorytm szyfrowania Morse'a - algorytm szyfrujący, w którym każda litera w tekście jest zamieniana na ciąg znaków "+" i "-", zgodny z kodem Morse'a.
4. Napisz program, który pobiera od użytkownika dwie macierze kwadratowe o takim samym rozmiarze i wyświetla ich iloczyn.
5. Program który na wejściu przyjmie równanie a na wyjściu da równanie w odwrotnej notacji polskiej ONP. Np. na wejściu 2+3*4 na wyjścu da 234*+
6. Program, który na wejściu przyjmie rówanie w ONP a na wyjściu wyświetli wynik rówania.
7. Napisz grę kółko i krzyżyk.
*/

namespace LotOfTasks
{
    internal class zadIf
    {
        public void zadIf1()
        {
            Console.WriteLine("Podaj liczbe: ");
            string num1 = Console.ReadLine();
            int number = int.Parse(num1);

            if (number % 2 == 0)
            {
                Console.WriteLine("liczba: " + number + " jest parzysta");
            }
            else
                Console.WriteLine("liczba: " + number + " nie jest parzysta");
        }
        public void zadIf2()
        {
            Console.WriteLine("Podaj liczbe: ");
            string num1 = Console.ReadLine();
            int number = int.Parse(num1);

            if (number < 0)
                Console.WriteLine("podana liczba jest ujemna");
            else if (number == 0)
                Console.WriteLine("podana liczba jest równa zero");
            else
                Console.WriteLine("podana liczba jest dodatnia");
        }
        public void zadIf3()
        {
            Console.WriteLine("Podaj rok: ");
            string num1 = Console.ReadLine();
            int year = int.Parse(num1);

            if (year % 4 == 0)
            {
                Console.WriteLine("rok: " + year + " jest rokiem przestępnym");
            }
            else
                Console.WriteLine("rok: " + year + " nie jest rokiem przestępnym");
        }
        public void zadIf4()
        {
            Console.WriteLine("Podaj ocenę od 1-6: ");
            string num1 = Console.ReadLine();
            int mark = int.Parse(num1);

            if (mark == 6)
            {
                Console.WriteLine(" wzorowa");
            }
            if (mark == 5)
            {
                Console.WriteLine(" bardzo dobra");
            }
            if (mark == 4)
            {
                Console.WriteLine(" dobra");
            }
            if (mark == 3)
            {
                Console.WriteLine(" dostateczna");
            }
            if (mark == 2)
            {
                Console.WriteLine(" dopuszcająca");
            }
            if (mark == 1)
            {
                Console.WriteLine(" niedostateczna");
            }
            if (mark > 6)
            {
                Console.WriteLine(" z poza przedziału");
            }
            else if (mark < 1)
            {
                Console.WriteLine(" z poza przedziału");
            }
        }
        public void zadIf5()
        {
            Console.WriteLine("Podaj hasło: ");
            string password = Console.ReadLine();


            if (password == "abc123")
            {
                Console.Write(" Podane hasło jest prewidłowe");
            }
            else
            {
                Console.Write(" Podane hasło nie jest prawidłowe");
            }
        }

        public void zadIf6()
        {
            Console.WriteLine("Podaj date (dd.mm.yyyy)");
            string data = Console.ReadLine();

            DateTime thisDay = DateTime.Today;


            if (data == thisDay.ToString("dd.MM.yyyy"))
            {
                Console.Write("Podana data jest poprawna");
            }
            else
            {
                Console.Write("Zǎoshang hǎo zhōngguó xiànzài wǒ yǒu BING CHILLING 🥶🍦 wǒ hěn xǐhuān BING CHILLING 🥶🍦 dànshì sùdù yǔ jīqíng 9 bǐ BING CHILLING 🥶🍦 sùdù yǔ jīqíng sùdù yǔ jīqíng 9 wǒ zuì xǐhuān suǒyǐ…xiànzài shì yīnyuè shíjiān zhǔnbèi 1 2 3 liǎng gè lǐbài yǐhòu sùdù yǔ jīqíng 9 ×3 bùyào wàngjì bùyào cu òguò jìdé qù diànyǐngyuàn kàn sùdù yǔ jīqíng 9 yīn wéi fēicháng hǎo diànyǐng dòngzuò fēicháng hǎo chàbùduō yīyàng BING CHILLING 🥶🍦zàijiàn 🥶🍦");
            }
        }

        public void zadIf7()
        {
            Console.WriteLine("Podaj temperature byku");
            string temp = Console.ReadLine();
            int temp2 = int.Parse(temp);

            if (temp2 > 20)
            {
                Console.Write("GIGA GORNONCO");
            }
            else
            {
                Console.Write("ALE MROZI BYNIU");
            }
        }

    }
}
