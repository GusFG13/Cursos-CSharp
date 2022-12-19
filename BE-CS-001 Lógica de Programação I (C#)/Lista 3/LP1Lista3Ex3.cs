using System.Drawing;
using System;
using System.Text.RegularExpressions;

namespace LP1.Lista3.Ex3
{
    internal class LP1Lista3Ex3
    {
        /*
         * 3. Faça um programa que leia uma frase do usuário e use um dicionário 
         *    que apresente as letras e a frequência de aparição desta letra na frase.
         */
        static void Main(string[] args)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();
            string frase;
            char auxLetra;

            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();
            
            for (int i = 0; i < frase.Length; i++)
            {
                //Console.WriteLine(frase[i]);
                auxLetra = char.ToLower(frase[i]);
                if (Regex.IsMatch(auxLetra.ToString(), "[a-z]"))
                {
                    if (!dic.TryAdd(auxLetra, 1)) // tenta inserir no dicionário. Se conseguir insere nova chave, com valor 1. Caso item já exista, não consegue inserir e retorna false.
                    {
                        dic[auxLetra]++; // elemento já existia, incrementar a quantidade
                    }
                }
            }
            Console.WriteLine("A frase digitada apresenta as letras:");
            Console.WriteLine("Letra : Frequência");
            foreach ((char chave, int valor) in dic.OrderBy(obj => obj.Key))
            {
                Console.WriteLine($"{chave} : {valor}");
            }
        }
    }
}