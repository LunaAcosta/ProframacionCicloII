using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaViernes3007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mi Nombre Es: Kevin Alexander Luna Acosta.");
            Console.ReadKey();

            //operadores 

            string nombre = "Kevin ";
            string saludo = "Bienvenido ";

            int a = 20;
            int b = 30;


            //  Console.WriteLine(saludo  + nombre );

            /* if (a < b) // operador de comparacion 
             {
                 Console.WriteLine(" a es menor que b ");

             }
             else if (a > b)
             {
                 Console.WriteLine("a es mayor que b");
             }
             else
             {
                 Console.WriteLine("a y b son iguales");



             }*/

            // IF ANIDADOS
            if (a != b) // operador de comparacion, diferente de 
            {
                if (a < b)
                {
                    Console.WriteLine("a es menor b ");
                }
                else if (a > b)
                {
                    Console.WriteLine("a es mayor a b");

                }
            }
            else
                Console.WriteLine("a es agual a b");

            //operador ternario 
            // la forma abreviada de if else 

            var resultado = a > b ? "a es mayor a b" : "a es menor a b";
            Console.WriteLine("Resultado con operador terminario : {0}", resultado);







            Console.ReadKey();
        }

    }
}
