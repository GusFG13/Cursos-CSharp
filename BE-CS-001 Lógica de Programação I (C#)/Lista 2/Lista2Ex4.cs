using System;

namespace LP1.Lista2.Ex4
{
    internal class Lista2Ex4
    {
        /*
         * 4. Soma de pares - Implemente um programa que calcula a soma dos números pares
         *    compreendidos entre dois números lidos.
         */
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int aux;
            int soma = 0;
            bool ehNum;
            string numSomados = "";

            do
            {
                Console.Write("Digite um número inteiro: ");
                ehNum = int.TryParse(Console.ReadLine(), out num1);
            } while (!ehNum);
            do
            {
                Console.Write("Digite outro número inteiro: ");
                ehNum = int.TryParse(Console.ReadLine(), out num2);
            } while (!ehNum);
            if (num2 < num1)
            {//garante que num1 é <= num 2
                aux = num2;
                num2 = num1;
                num1 = aux;
            }

            aux = (num1 % 2 == 0) ? num1 : num1 + 1;
            while (aux <= num2)
            {
                soma += aux;
                numSomados += aux.ToString() +";";
                aux += 2;
            }
            Console.WriteLine($"A soma dor números pares entre {num1} e {num2} é {soma}");
            Console.WriteLine($"Os números somados foram: {numSomados.Remove(numSomados.Length - 1)}");
        }
    }
}