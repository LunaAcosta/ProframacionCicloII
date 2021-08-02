using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTeorica
{
    class Oscar
    {
    }
}
 float peso, altura, IMC;

Console.WriteLine("Ingrese su peso:KG");
peso = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su altura:CM");
altura = float.Parse(Console.ReadLine());

IMC = peso / (altura / 100) * (altura / 100);

if (IMC < 15)

    Console.WriteLine("Delgadez muy severa");
else if (IMC < 15.9)

    Console.WriteLine("Delgadez severa");
else if (IMC < 18.4)
    Console.WriteLine("Delgadez");
else if (IMC < 24.9)
    Console.WriteLine("Peso saludable");
else if (IMC < 29.9)
    Console.WriteLine("Sobrepeso");
else if (IMC < 34.9)
    Console.WriteLine("Obesidad");
else if (IMC < 39.9)
    Console.WriteLine("Obesidad grado 2");
else
    Console.WriteLine("Obesidad grado 3");


Console.ReadKey();