using System;
using System.Linq;

namespace ListaExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            string vogais = "aeiouAEIOU";
            int contador = 0;
            Console.WriteLine("Escreva quantas letras quiser: ");
            string n = Console.ReadLine();

            for(int i = 0; i < n.Length; i++)
            {
                if(vogais.Contains(n[i]))
                {
                    contador++;
                }
            }
            Console.WriteLine($"Temos {n.Length} letras e {contador} vogais.");
        }
    }
}
