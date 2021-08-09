using System;

namespace Ejercicio7_cuboNumeroReal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("El Resultado es :"+ NumeroCubo(3.2f));
            Console.WriteLine("El Resultado es :" + NumeroCubo(5f));
        }
        public static float NumeroCubo(float Numero)
        {
            return Numero * Numero * Numero;

        }
    }
}
