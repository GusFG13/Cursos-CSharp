namespace LP1.Lista2.Ex1
{
    internal class Lista2Ex1
    {
        /*
         * 1. Caracteres progressivos 1 - Escrever um programa que produza a saída abaixo na tela, para N
         *    linhas e usando um caractere lido do teclado (no exemplo, *). Após mostrar uma vez, o programa
         *    repete o processo, só parando quando N for zero.
         *    *
         *    **
         *    ***
         *    ****
         *    (...)
         */
        static void Main(string[] args)
        {
            int num;
            bool ehNum;
            bool ehCaract = false;
            string entrada;
            char caract = ' ';
            do
            {
                Console.Write("Digite um número inteiro: ");
                ehNum = int.TryParse(Console.ReadLine(), out num);
                if (ehNum && num > 0)
                {
                    do
                    {
                        Console.Write("Digite um caractere: ");
                        entrada = Console.ReadLine();
                        if (entrada.Length == 1)
                        {
                            ehCaract = char.TryParse(entrada, out caract);
                        }
                    } while (!ehCaract);
                    ehCaract = false;
                    for (int i = 1; i <= num; i++)
                    {
                        Console.WriteLine(new string(caract, i));
                    }
                }

    
            } while (!ehNum || num > 0);
            
        }
    }
}