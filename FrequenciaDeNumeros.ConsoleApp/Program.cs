using System;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 8, 10, 8, 8, 260, 260, 270, 1, 2, 4, 4, 4, 10, 10, 9 };

            for (int leitura = 0; leitura < numeros.Length; leitura++) Console.Write(numeros[leitura] + " ");
            Console.WriteLine(" ");

            Array.Sort(numeros);//ordena o array numeros

            int i = 0;
            int j = 0;

            while (i < numeros.Length)
            {
                int numero = numeros[i];
                int cont = 0;

                while (numeros[i] == numeros[j])
                {
                    cont++;
                    j++;

                    if (j == numeros.Length)// verificar se é o ultimo elemento e parar
                    {
                        break;
                    }
                }

                string vezOuVezes = (cont > 1) ? " vezes" : " vez";//verificar se é maior do que 1 para mostrar na tela
                Console.WriteLine("\r\n" + numero + " apareceu " + cont + vezOuVezes);
                i = j;
            }
            Console.ReadLine();
        }
    }
}