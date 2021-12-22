using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int edad = 0;
                Console.WriteLine("Cual es su edad");
                edad = Int32.Parse(Console.ReadLine());
                switch (edad)
                {
                    case int n when (n > 0 && n < 18):
                        Console.WriteLine("Usted es menor de edad");
                        break;

                    case int n when (n <= 59 && n >= 18):
                        Console.WriteLine("Usted es mayor de edad");
                        break;

                    case int n when (n > 59):
                        Console.WriteLine("Usted es una persona de la tercera edad");
                        break;
                }
            }
                catch (Exception)
                 {
                        Console.WriteLine("Introduzca un numero no un caracter");
                 }
                         Console.ReadLine();

        }
    }
}
