using System.Security.Cryptography;

namespace LP1.Aula4.ListaDatasEx3
{
    internal class Program
    {
        /*
         * Faça um programa que retorne o dia da semana atual.
         */
        static void Main(string[] args)
        {
            DateTime hoje = DateTime.Today;
            Console.WriteLine($"Hoje é {hoje.ToString("dddd")}.");
        }
    }
}