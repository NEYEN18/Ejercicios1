using System;

namespace Ejercicios_Nivel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reto #1
            decimal num1, num2;

            Console.WriteLine("Introduzca un numero");

            num1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca otro numero");

            num2 = decimal.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"el primer numero ({num1}) es mayor que el segundo ({num2})");

            }
            else if (num1 < num2)
            {
                Console.WriteLine($"el segundo numero ({num2}) es mayor que el segundo numero ({num1})");
            }
            else 
            { 
                  Console.WriteLine("Los numeros son iguales");             
            }

        }
    }
}
