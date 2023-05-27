using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos
            ushort b = 256;  //1byte
            int num1 = 50;  // 4bytes
            int num2 = 25, num3;
            long larga = 565555;
            float flotante = 33.3f;
            double doble = 14.25555555556988d;
            decimal deci = 158.366666m;
            int i=0;
            string frase = "Hoy es Viernes";
            string nombre = string.Empty;
            char caracter = 'A';
            Boolean bolean = true;

            var variable = 30;
            variable = 20;

            dynamic dinamico = "texto";
            dinamico = 25;
            dinamico = true;
            dinamico = 256.322m;


            Console.WriteLine("La suma de numeros: " + (num1 + num2));
            Console.WriteLine("La multiplicacion de numeros: " + num1 * num2);
            Console.WriteLine("La division de numeros: " + num1 / num2);
            Console.WriteLine("La resta de numeros: " + (num1 - num2));

            Console.WriteLine("El residuo es: " + (28%5));

            //Acumuladores
            float total=0; float salario=0;
            total = total + salario;
            total += salario;
               

            //Contadores
            i = i + 1;
            i = i - 1;

            i++;
            ++i;
            --i;
            i--;
            i += 2;  i = i + 2;

            i*=3; // i = i * 3
            i /= 20; // i = i/20

            num1 = 5;
            num2 = 5;
            num3 = 50;
            // Condiciones
            Console.WriteLine(".......IF.......");
            if (num1 > num2)
            {
                Console.WriteLine("Num1 es mayor");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Num2 es mayor");
            }
            else Console.WriteLine("Los numeros son iguales");

            if ((num1 < num2) || (num2 > num1))  // OR
            {

            }
            if ((num1 == num2) && (num2 > num3))  // AND
            {

            }

            // CICLOS
            Console.WriteLine(".......for.......");
            for (int j = 0; j<=10; j+=5)
            {
                Console.WriteLine(j);
            }

            int x = 10;
            Console.WriteLine(".......while.......");
            while (x>0)
            {
                Console.WriteLine(x);
                x--;
            }
            Console.WriteLine(".......do while.......");
            char Opcion = 's';
            do
            {
                Console.WriteLine("1- Sumar");
                Console.WriteLine("2- Restar");
                Console.WriteLine("3- Dividir");
                Console.WriteLine("4- Multiplicar");
                Console.WriteLine("Desea continuar..(s/n)");
                Opcion = char.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case '1': Console.WriteLine("La suma de numeros: " + (num1 + num2));
                            break;
                    case '2':
                        Console.WriteLine("La suma de numeros: " + (num1 - num2));
                        break;
                    default: Console.WriteLine("Opcion incorrecta"); break;

                }

            } while (!Opcion.Equals('n'));

            Console.ReadLine();

          


    }
    }

}

