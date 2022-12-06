namespace LP1.Lista2.Ex6
{
    internal class Lista2Ex6
    {
        /*
         * 6. Ímpares múltiplos 2 - Altere o programa acima de forma que a faixa seja informada pelo
         *    usuário, e os números ímpares múltiplos de três sejam mostrados em ordem decrescente.
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

            for (int i = num2; i >= num1; i--)
            {
                if (i % 3 == 0)
                {
                    numSomados += i.ToString() + ";";
                    soma += i;
                }
            }


            Console.WriteLine($"A soma dos números ímpares múltiplos de três entre {num1} e {num2} é {soma}"); //166833
            Console.WriteLine("Os números ímpares múltiplos de três sejam em ordem decrescente são:");
            Console.WriteLine(numSomados.Remove(numSomados.Length - 1));
        }
    }
}