using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;

/*
Podstawy programowania:
1. Program obliczający średnią arytmetyczną dwóch liczb.
2. Program obliczający pole prostokąta.
3. Program obliczający objętość stożka.
4. Program obliczający pole koła.
5. Program obliczający wartość wyrażenia a^2 + b^2
6. Program obliczający pole trójkąta o podstawie b i wysokości h
7. Program obliczający objętość kuli o promieniu r
8. Program obliczający pole trapezu o podstawach a i b oraz wysokości h
9. Program obliczający średnią ważoną trzech liczb z podanymi odpowiednimi wagami w1, w2 i w3.
*/

namespace LotOfTasks
{
    internal class Exercise
    {
        public void Exercise1()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            string num1 = Console.ReadLine();
            float number = float.Parse(num1);

            Console.WriteLine("Podaj drugą liczbę: ");
            string num2 = Console.ReadLine();
            float number2 = float.Parse(num2);

            float suma = number2 + number;
            float srednia = suma / 2;

            Console.WriteLine(srednia);
        }
        public void Exercise2()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            string num1 = Console.ReadLine();
            float side = float.Parse(num1);

            Console.WriteLine("Podaj drugą liczbę: ");
            string num2 = Console.ReadLine();
            float side2 = float.Parse(num2);

            float field = 2 * side + 2 * side2;
            Console.WriteLine(field);
        }
        public void Exercise3()
        {
            double pi = Math.PI;
            double field;
            double volume;

            Console.WriteLine("Podaj promień: ");
            string num1 = Console.ReadLine();
            double radius = double.Parse(num1);

            Console.WriteLine("Podaj wysokość: ");
            string num2 = Console.ReadLine();
            double heigh = double.Parse(num2);

            field = (pi * (radius * radius)) / 3;

            volume = field * heigh;
            Console.WriteLine("Objętość: " + volume);
        }
        public void Exercise4()
        {

            Console.WriteLine("Podaj promień: ");
            string rad = Console.ReadLine();
            double radius = double.Parse(rad);

            double area;
            double pi = Math.PI;

            area = (pi * (radius * radius));

            Console.WriteLine("pole: " + area);
        }
        public void Exercise5()
        {
            // a^2 + b^2
            Console.WriteLine("Podaj pierwszą liczbe: ");
            string num1 = Console.ReadLine();
            double firstNumber = double.Parse(num1);

            Console.WriteLine("Podaj drugą liczbe: ");
            string num2 = Console.ReadLine();
            double secondNumber = double.Parse(num2);

            double wynik = secondNumber * secondNumber + firstNumber * firstNumber;
            Console.WriteLine(wynik + "a^2 + b^2");
        }
        public void Exercise6()
        {
            Console.WriteLine("Podaj podstawe: ");
            string basE = Console.ReadLine();
            double b = double.Parse(basE);

            Console.WriteLine("Podaj wysokość: ");
            string heigh = Console.ReadLine();
            double h = double.Parse(heigh);

            double area = b * (h / 2);
            Console.WriteLine("pole trójkąta: " + area);
        }
        public void Exercise7()
        {
            Console.WriteLine("Podaj promień: ");
            string radius = Console.ReadLine();
            int r = int.Parse(radius);
            double pi = Math.PI;
            double V;

            V = ((r * r * r) * pi * (4 / 3));

            Console.WriteLine("Objetość kuli : " + V + " V = 4/3 πr³");
        }
        public void Exercise8()
        {
            Console.WriteLine("Podaj bok a: ");
            string num1 = Console.ReadLine();
            int sideA = int.Parse(num1);

            Console.WriteLine("Podaj wysokość: ");
            string num = Console.ReadLine();
            int h = int.Parse(num);

            Console.WriteLine("Podaj bok b: ");
            string num2 = Console.ReadLine();
            int sideB = int.Parse(num2);

            int area = ((sideA+sideB) * h)/2;

            Console.WriteLine("pole trapezu: " + area);
        }
        public void Exercise9() 
        {
            Console.WriteLine("Podaj pierwsza ocene: ");
            string num1 = Console.ReadLine();
            float grade1 = int.Parse(num1);

            Console.WriteLine("Podaj pierwsza wage: ");
            string wei1 = Console.ReadLine();
            float weight1 = int.Parse(wei1);

            Console.WriteLine("Podaj drugą ocene: ");
            string num2 = Console.ReadLine();
            float grade2 = int.Parse(num2);

            Console.WriteLine("Podaj pierwsza wage: ");
            string wei2 = Console.ReadLine();
            float weight2 = int.Parse(wei2);

            Console.WriteLine("Podaj trzecią ocene: ");
            string num3 = Console.ReadLine();
            float grade3 = int.Parse(num3);

            Console.WriteLine("Podaj trzecią wage: ");
            string wei3 = Console.ReadLine();
            float weight3 = int.Parse(wei3);

            float weightResults = weight2 + weight1 + weight3;
            float gradeResults = grade1 + grade2 + grade3;
            float aritmetic = (weight1 * grade1 + weight2 * grade2 + weight3* grade3) / weightResults;

            Console.WriteLine("srednia : " + aritmetic);
        }
    }
}
