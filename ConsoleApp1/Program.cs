using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float edad = 0.0f;
                Console.WriteLine("Escribe tu edad: ");
                edad = float.Parse(Console.ReadLine());
                if (edad < 18 && edad > 0)
                {
                    Console.WriteLine("Usted es menor de edad");
                }
                else if (edad >= 18 && edad <= 59)
                {
                    Console.WriteLine("Usted es mayor de edad");

                }
                else if (edad > 59)
                    Console.WriteLine("Usted es una persona de la 3ra edad");
            }
            catch (Exception)
            {
                Console.WriteLine("Introduzca un numero no un caracter");
            }
            Console.ReadLine();  
        }
    }
}      

        
    
    

