namespace LP1.Lista3.Ex2
{
    internal class LP1Lista3Ex2
    {
        /*
         * 2. Faça um programa que leia 10 números do usuário e os coloque corretamente no dicionário D abaixo.
         *           D = new Dictionary<int[], int[]> 
         *    onde a chave serão os números pares e o valor serão os ímpares.
         */

        //Exemplos de saídas:
        //Entrada: 1 2 3 4 5 6 7 8 9 10
        //  D[{2,4,6,8,10}] = {1,3,5,7,9}
        //Entrada: 1 1 1 1 1 1 1 1 1 1
        //  Não há números pares
        //Entrada: 2 2 2 2 2 2 2 2 2 2
        //  Não há números ímpares
        //Entrada: 1 1 1 1 1 2 1 1 2 1
        //  D[{2,2}] = {1,1,1,1,1,1,1,1}
        //Entrada: 2 1 2 1 2 2 2 2 2 2
        //  D[{2,2,2,2,2,2,2,2}] = {1,1}
        //Entrada: 2 2 2 1 2 2 2 2 2 2
        //  D[{2,2,2,2,2,2,2,2,2}] = {1}
        //Entrada: 1 1 1 1 1 2 1 1 1 1
        //  D[{2}] = {1,1,1,1,1,1,1,1,1}
        static void Main(string[] args)
        {
            Dictionary<int[], int[]> D = new Dictionary<int[], int[]>();
            int[] numeros = new int[10];
            int pares = 0;
            int impares = 0;
            bool numValido;

            Console.WriteLine("Digite 10 números inteiros: ");
            for(int i = 0 ; i < 10; i++)
            {
                do
                {
                    Console.Write($"{i + 1}o. número: ");
                    numValido = int.TryParse(Console.ReadLine(), out numeros[i]);
                    if (numValido)
                    {
                        if (numeros[i] % 2 == 0)
                        {
                            pares++;
                        }
                        else
                        {
                            impares++;
                        }
                    }
                    
                }while(!numValido);
            }

            if (pares == 0)
            {
                Console.WriteLine("Não há números pares");
            }
            else if (impares == 0)
            {
                Console.WriteLine("Não há números ímpares");
            }
            else
            {
                int[] arrPares = new int[pares];
                int[] arrImpares = new int[impares];
                int posPares = 0;
                int posImpares = 0;
                foreach (int num in numeros)
                {
                    //separa número pares e ímpares nos respectivos vetores
                    if (num % 2 == 0)
                    {
                        arrPares[posPares] = num;
                        posPares++;
                    }
                    else
                    {
                        arrImpares[posImpares] = num;
                        posImpares++;
                    }
                    //Console.WriteLine(num);
                }
                D.Add(arrPares, arrImpares);
                //D[arrPares] = arrImpares;
            
                Console.Write($"D[{{{string.Join(',', arrPares)}}}]");
                Console.WriteLine($" = {{{string.Join(',', D[arrPares])}}}");
            }
            
        }
    }
}