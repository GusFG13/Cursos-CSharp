using System.Diagnostics;

namespace LP1.Aula4.Ex4
{
    internal class Aula4Ex4
    {
        //Faça um programa que receba o primeiro nome do usuário e mostre na tela a frase de boas vindas.
        //Ex: Nome do usuário = "Eduardo"
        //Frase exibida = "Seja bem vindo(a), Eduardo. Tenha um bom dia!"
        static void Main(string[] args)
        {
            string nome;
            do
            {
                Console.Clear();
                Console.WriteLine("Escreva seu nome: ");
                nome = Console.ReadLine();
                if (nome != "")
                {
                    Console.WriteLine($"Seja bem vindo(a), {nome}. Tenha um bom dia!");
                }
            } while (nome == "");
        }
    }
}