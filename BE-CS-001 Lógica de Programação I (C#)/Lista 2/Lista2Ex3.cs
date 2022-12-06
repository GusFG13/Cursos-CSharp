namespace LP1.Lista2.Ex3
{
    internal class Lista2Ex3
    {
        /*
         * 3. Maior e menor - Alterar o programa anterior para que mostre também 
         *    o menor número lido.
         */
        static void Main(string[] args)
        {
            int num;
            int maior = Int32.MinValue;
            int menor = Int32.MaxValue;
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
                    if (num < menor && num != 0)
                    {
                        menor = num;
                    }
                }
            } while (!ehNum || num != 0);
            Console.WriteLine($"O maior número lido foi: {maior}");
            Console.WriteLine($"O menor número lido foi: {menor}");
        }
    }
}