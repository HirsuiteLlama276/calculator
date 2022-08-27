using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stworzenie obiektu w którym będziemy wykonywać działania
            var dzialania = new Calculator<float>();
            // Przywitanie się aplikacji
            Console.WriteLine("Witaj w Kalkulatorze!");
            // Zapisanie zmiennych z którymi będziemy działać
            Console.WriteLine("Podaj pierwszą liczbę ");
            var first = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę ");
            var second = float.Parse(Console.ReadLine());
            // Wypisanie możliwych działań i wczytanie działania wybranego
            Console.WriteLine("Możliwe działania: + - * / ");
            var operation = Console.ReadLine();

            // Wykonanie wskazanego działania na obiekcie
            switch (operation)
            {
                case "+":
                    {
                        dzialania.Add(first, second);
                    }
                    break;
                case "-":
                    {
                         dzialania.Substract(first, second);
                    }
                    break;
                case "*":
                    {
                         dzialania.Multiply(first, second);
                    }
                    break;
                case "/":
                    {
                        dzialania.Divide(first, second);
                    }
                    break;


            }
            
        }
    }
}
