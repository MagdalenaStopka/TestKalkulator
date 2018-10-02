using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstyKalkulator
{
    public class Program
    {
        int wynik;
        static void Main(string[] args)
        {
            Program p = new Program();
            int a = 0;
            int b = 0;
            
            double operacja;

            Console.WriteLine("Program: kalkulator ");
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbę:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Możliwe operacje: dodawanie: 1, odejmowanie: 2, mnożenie: 3, dzielenie: 4");
            Console.WriteLine("Wybierz operację:");
            
            operacja = double.Parse(Console.ReadLine());
            switch (operacja)
            {
                case 1:
                    p.Dodawanie(a, b);
                    break;


                case 2:
                    p.Odejmowanie(a, b);

                    break;

                case 3:
                    p.Mnozenie(a, b);

                    break;
                case 4:
                    p.Dzielenie(a, b);

                    break;
            }

            Console.ReadKey();
        }
        public int Dodawanie(int a, int b)
        {
            wynik = a + b;
            Console.WriteLine("Wybrano operację dodawania:" + wynik);
            return wynik;

            
        }
        public int Odejmowanie(int a, int b)
        {
             wynik = a - b;

            Console.WriteLine("Wybrano operację odejmowania:" + wynik);
            return wynik;
        }
        public int Mnozenie(int a, int b)
        {
            int wynik = a * b;

            Console.WriteLine("Wybrano operację mnożenia:" + wynik);
            return wynik;
        }

        public int Dzielenie(int a, int b)
        {
            int wynik = a / b;

            Console.WriteLine("Wybrano operację dzielenia:" + wynik);
            return wynik;
        }
    }
}
