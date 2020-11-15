using System;

namespace Ejercicios_nivel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio #1
            /*Console.WriteLine("Ingrese su Nombre");

            String nombre = Console.ReadLine();

            Console.WriteLine($"Hola, {nombre}");*/

            /*Ejercicio #2
            Console.WriteLine("Ingrese su Nombre y Apellido");

            String nombreApellido = Console.ReadLine();

            Console.WriteLine($"Hola, {nombreApellido}");*/

            //Ejercicio #4
            /*Console.WriteLine("Ingrese el primer numeros (con decimales)");

            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero (con decimales)");

            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es " + (numero1 + numero2));*/

            //Ejercicio #5
            /*Console.WriteLine("Ingrese el primer numeros (con decimales)");

            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero (con decimales)");

            double numero2 = double.Parse(Console.ReadLine());

            double suma = numero1 + numero2;

            Console.WriteLine("Ingrese el tercer numero (con decimales)");

            double numero3 = double.Parse(Console.ReadLine());

            double multiplicacion = suma * numero3;

            Console.WriteLine($"El resultado es {multiplicacion}");*/

            //Ejercicio #6
            /*int Xrebanadas, Yrebanadas, Zrebanadas;

            Console.WriteLine("Cuantas rebanadas de pizza hay en la fiesta");

            Xrebanadas = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuantas rebanadas se comieron?");

            Yrebanadas = int.Parse(Console.ReadLine());

            Zrebanadas = Xrebanadas - Yrebanadas;

            Console.WriteLine($"Quedan {Zrebanadas} rebanadas de pizza");*/

            //Ejercicio #7
            /*Console.WriteLine("Por favor introduzca su Nombre");

            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor introduzca su Edad");

            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nombre} el año pasado tenias {edad - 1} años y el año que entra vas a tener {edad + 1}");*/

            //Ejercicio #8
            /*double total, propina, impuestos, totalFinal, cuentaPersonas;

            int personas;
            
            Console.WriteLine("Indique el monto total a pagar");
            
            total = double.Parse(Console.ReadLine());

            Console.WriteLine("¿entre cuantas personas se dividira la cuenta?");

            personas = int.Parse(Console.ReadLine());

            impuestos = ((total * 20) / 100);

            propina = ((total * 10) / 100);

            totalFinal = total + impuestos + propina;

            cuentaPersonas = (totalFinal / personas);

            Console.WriteLine($"El total a pagar es de ${totalFinal} ");

            Console.WriteLine("El porcentaje de Impuestos y Propina incluidos es del 20% y 10%");

            Console.WriteLine($"El total a pagar por cada persona es de ${cuentaPersonas}" +
                ". Muchas gracias vuelva prontos.");*/

            //Ejercicio #9        
            /*int dias, horas;
            
            double minutos, segundos;

            dias = int.Parse(Console.ReadLine());

            horas = dias * 24;

            minutos = horas * 60;

            segundos = minutos * 60;

            Console.WriteLine("");
            
            Console.WriteLine($"{dias} dias equivalen a {horas} horas o {minutos} minutos o a {segundos}");*/

            //Ejercicio #10
            /*Console.WriteLine("Indicar a continuacion la cantidad de millas a convertir");

            decimal millas = Decimal.Parse(Console.ReadLine());

            decimal equivalenciakilometro = 1.609344M;

            decimal kilometros = millas * equivalenciakilometro;

            Console.WriteLine($"{millas} millas equivalen a {kilometros} kilometros");*/

            //Ejercicio #11
            /*decimal mil, cien, entran;
            
            Console.WriteLine("Introduzca un numero mayor a 1000");

            mil = decimal.Parse(Console.ReadLine());

            while (mil <= 1000)
            {
                Console.WriteLine("El numero introducido debe ser mayor a 1000. Intentelo nuevamente");

                mil = decimal.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("Introduzca un numero menor a 100");

            cien = decimal.Parse(Console.ReadLine());

           while (cien >= 100)
            {
                Console.WriteLine("El numero introducido debe ser menor a 100. Intentelo nuevamente");

                cien = decimal.Parse(Console.ReadLine());
            }
           
            entran = mil / cien;
            
            Console.WriteLine($"el numero {cien} entra {entran} veces en el numero {mil}");*/

        }
    }
}
