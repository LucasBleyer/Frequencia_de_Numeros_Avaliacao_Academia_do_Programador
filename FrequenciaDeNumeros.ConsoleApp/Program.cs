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
            
            if (valor2 == valor1 || valor2 == valor3 || valor2 == valor4 || valor2 == valor5 || valor2 == valor6 || valor2 == valor7 || valor2 == valor8)
            {
                cont++;
            }
            
            if (valor3 == valor1 || valor3 == valor2 || valor3 == valor4 || valor3 == valor5 || valor3 == valor6 || valor3 == valor7 || valor3 == valor8)
            {
                cont++;
            }
            
            if (valor4 == valor2 || valor4 == valor3 || valor4 == valor1 || valor4 == valor5 || valor4 == valor6 || valor4 == valor7 || valor4 == valor8)
            {
                cont++;
            }
            
            if (valor5 == valor2 || valor5 == valor3 || valor5 == valor4 || valor5 == valor1 || valor5 == valor6 || valor5 == valor7 || valor5 == valor8)
            {
                cont++;
            }
            
            if (valor6 == valor2 || valor6 == valor3 || valor6 == valor4 || valor6 == valor5 || valor6 == valor1 || valor6 == valor7 || valor6 == valor8)
            {
                cont++;
            }
            
            if (valor7 == valor2 || valor7 == valor3 || valor7 == valor4 || valor7 == valor5 || valor7 == valor6 || valor7 == valor1 || valor7 == valor8)
            {
                cont++;
            }
            
            if (valor8 == valor2 || valor8 == valor3 || valor8 == valor4 || valor8  == valor5 || valor8 == valor6 || valor8 == valor7 || valor8 == valor1)
            {
                cont++;
            }
            Console.WriteLine(valor1 + " aparece " + cont + " vezes");
            Console.WriteLine(valor2 + " aparece " + cont + " vezes");
            Console.WriteLine(valor3 + " aparece " + cont + " vezes");
            Console.WriteLine(valor4 + " aparece " + cont + " vezes");
            Console.WriteLine(valor5 + " aparece " + cont + " vezes");
            Console.WriteLine(valor6 + " aparece " + cont + " vezes");
            Console.WriteLine(valor7 + " aparece " + cont + " vezes");
            Console.WriteLine(valor + " aparece " + cont + " vezes");
        }
    }
}
