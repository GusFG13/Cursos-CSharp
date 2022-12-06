namespace LP1.Lista2.Ex2
{
    internal class Lista2Ex2
    {
        /*
         * 2. Maior - Escrever um programa que lê números inteiros até que o número lido seja zero, 
         *    quando então é mostrado o maior número lido.
         */
        static void Main(string[] args)
        {
            int num;
            int maior = 0;
            bool ehNum;

            do
            {
                Console.Write("Digite um número inteiro: ");
                ehNum = int.TryParse(Console.ReadLine(), out num);
                if (ehNum)
                {
                    if (num > maior)
                    {
                        maior = num;
                    }
                }
            } while (!ehNum || num > 0);
            Console.WriteLine($"O maior número lido foi: {maior}");
        }
    }
}