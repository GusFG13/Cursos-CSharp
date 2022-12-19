using System;

namespace LP1.Lista3.Ex1
{
    internal class LP1Lista3Ex1
    {
        /*
         * 1. Faça um programa que leia uma frase do usuário e use um dicionário que 
         *    apresente as palavras e a frequência de sua aparição na frase.
         */
        static void Main(string[] args)
        {
            string frase;
            string[] palavras;
            
            Dictionary<string, int> dicPalavras= new Dictionary<string, int>();
            Console.WriteLine("Digite sua frase:");
            frase = Console.ReadLine().ToLower();
            frase = frase.Replace(".", "").Replace("?", "").Replace(",", "").Replace(":", "").Replace(";", "").Replace("?", "").Replace("!", "");
            palavras = frase.Split(" ");
            foreach(string palavra in palavras)
            {
                if(dicPalavras.ContainsKey(palavra))
                {
                    dicPalavras[palavra]++;
                }
                else
                {
                    dicPalavras.Add(palavra, 1);
                }
            }

            Console.WriteLine("\nA frase sem pontuação:\n");
            Console.WriteLine(frase);
            Console.WriteLine("\nA frequência de cada palavra na frase é:");
            foreach((string chave, int freq) in dicPalavras)
            {
                Console.WriteLine($" - {chave}: {freq} vezes.");
            }
        }
    }
}