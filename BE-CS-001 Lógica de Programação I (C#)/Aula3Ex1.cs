using System.Drawing;
using System.Security.Cryptography;

namespace LP1.Aula3.Ex1
{
    internal class Aula3Ex1
    {
        static void Main(string[] args)
        {
            /*
            Escreva um algoritmo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B. A 
            seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o valor 
            que está em A passe para B e vice-versa.Ao final, escrever os valores que ficaram armazenados nas 
            variáveis.
            */
            
            int A = 10;
            int B = 20;
            int aux;

            aux = B;
            B = A;
            A = aux;

            Console.WriteLine($"O valor armazenado em A é {A} e em B, {B}");
            

        }
    }
}