using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTeorica
{
    class TiposDatos
    {

        static void Main(string[] args)
        {
            /* Console.WriteLine("Esta es la clase Variable");
             Console.ReadKey();*/

            // VARIABLES 
            // tipos de datos 
            byte num1 = 255;

            // sbyte solo admite numeros negativos 

            sbyte num2 = -127;

            // int admite tantos numeros negativos como positivos 

            int num3 = 22;
            int num4 = -20;

            // uintt , solamente admite nmeros positivos 

            uint num5 = 45;

            //log permite procesar millones de datos, 8 bytes 

            long num6 = -134;
            long num7 = 344;

            // ulong solo admite datos postivos 

            ulong num8 = 9930330;

            // procesamientos de decimales 
            // float, se debe especificar con  un f, 4 bytes

            float num9 = 100.9f;

            // duoble tiene mas alcance en 8 bytes 
            double num10 = 100.9d;

            // decimal, 16 bytes 

            decimal num11 = 17772.9m;

            // guardar cadena de caracter  char  un caracter 
            char caracter ='A'; // Se encierra en comillas simples

            //para texto se utliza string o cadena 

            string texto = "Programacion computacional";

            // variables de tipo implicito var

            
            Console.WriteLine("Cual es su nombre: ");
            var nombre = Console.ReadLine();
            
            var cantidad= 100.50d;


            Console.WriteLine("El tipo de dato para la variable nombre es {0}", nombre.GetType());

            Console.WriteLine("El tipo de dato para la variable cantidad es {0}", cantidad.GetType());

            Console.ReadKey(); 








                                







 








        }
    }
}
