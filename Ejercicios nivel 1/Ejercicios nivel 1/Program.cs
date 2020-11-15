using System;

namespace Ejercicios_nivel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qué ejercicio querés ejecutar?");
            int opcion = Convert.ToInt32(Console.ReadLine());
            
            EjecutarEjericioElegido(opcion);

            Console.ReadLine();
        }




        private static void EjecutarEjericioElegido(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    ImprimirNombreEnConsola();
                    break;
                case 2:
                    ImprimirNombreYApellido();
                    break;
                case 4:
                    double numero1 = NuevoValorDecimal();
                    double numero2 = NuevoValorDecimal();
                    Console.WriteLine("El resultado es " + (numero1 + numero2));
                    break;

                case 5:
                    double suma = SumaNumeros();
                    double numero3 = NuevoValorDecimal();
                    double multiplicacion = suma * numero3;

                    Console.WriteLine($"El resultado es {multiplicacion}");
                    break;
                case 6:
                    //codigo
                    break;
                case 7:
                    //codigo
                    break;
                default:
                    Console.WriteLine("No conozco ese ejercicio");
                    break;
            }

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

        private static double SumaNumeros()
        {
            double numero1 = NuevoValorDecimal();
            double numero2 = NuevoValorDecimal();
            double suma = numero1 + numero2;
            return suma;
        }

        private static double NuevoValorDecimal()
        {
            Console.WriteLine("Ingresa un valor (con decimales)");
            return double.Parse(Console.ReadLine());
        }

        private static int NuevoValorEntero()
        {
            Console.WriteLine("Ingresa un valor entero");
            return int.Parse(Console.ReadLine());
        }

        private static void ImprimirNombreYApellido()
        {
            Console.WriteLine("Ingrese su Nombre y Apellido");

            String nombreApellido = Console.ReadLine();

            Console.WriteLine($"Hola, {nombreApellido}");
        }

        private static void ImprimirNombreEnConsola()
        {
            Console.WriteLine("Ingrese su Nombre");

            String nombre = Console.ReadLine();

            Console.WriteLine($"Hola, {nombre}");
        }
    }
}
