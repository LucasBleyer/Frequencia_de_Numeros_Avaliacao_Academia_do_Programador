using System;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            int valor2 = 8;
            int valor3 = 10;
            int valor4 = 8;
            int valor5 = 260;
            int valor6 = 4;
            int valor7 = 10;
            int valor8 = 10;

            int cont = 1;

            if (valor1 == valor2 || valor1 == valor3 || valor1 == valor4 || valor1 == valor5 || valor1 == valor6 || valor1 == valor7 || valor1 == valor8)
            {
                cont++;
            }

            Console.WriteLine(valor1 + " aparece " + cont + " vezes");

        }
    }
}
