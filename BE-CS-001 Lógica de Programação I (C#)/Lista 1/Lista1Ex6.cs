namespace LP1.Lista1.Ex6
{
    internal class Lista1Ex6
    {
        /*
         * Multiplicação rápida - Um algoritmo para multiplicação rápida por 11 de números 
         * de 2 dígitos funciona assim: para multiplicar 81 x 11, some os dígitos do número 
         * (8 + 1 = 9) e insira o resultado entre os dígitos (891). Se a soma der maior que 9, 
         * incremente o dígito da esquerda: 56 x 11 = 616. Faça um programa que efetue 
         * multiplicações por 11 usando este algoritmo.
         */
        static void Main(string[] args)
        {
            string strNum;
            bool numInvalido = true;
            short digito1;
            short digito2;
            short auxSoma;
            string resultado;
            do
            {
                Console.Write("Entre um número inteiro com 2 dígitos: ");
                strNum = Console.ReadLine();
                if (strNum.Length == 2)
                {
                    numInvalido = !int.TryParse(strNum, out _);
                }
            } while (numInvalido);
            digito1 = short.Parse(strNum.First().ToString());
            digito2 = short.Parse(strNum.Last().ToString());

            auxSoma = (short)(digito1 + digito2);

            if (auxSoma <= 9)
            {
                //resultado = digito1.ToString() + auxSoma.ToString() + digito2.ToString();
                resultado = $"{digito1}{auxSoma}{digito2}";
            }
            else
            {
                //resultado = (digito1 + 1).ToString() + (auxSoma - 10).ToString() + digito2.ToString();
                resultado = $"{digito1 + 1}{auxSoma - 10}{digito2}";
            }
            Console.WriteLine($"O resultado de 11 x {strNum} é {resultado}");



            /***************************************************************************************************/
            //Versão que imprime todas a multipicações por 11 de 10 a 99
            /*
            string strNum;
            bool numInvalido = true;
            short digito1;
            short digito2;
            short auxSoma;
            string resultado;
            for (int i = 10; i<100; i++)
            {
                strNum = i.ToString();
                digito1 = short.Parse(strNum.First().ToString());
                digito2 = short.Parse(strNum.Last().ToString());

                auxSoma = (short)(digito1 + digito2);

                if (auxSoma <= 9)
                {
                    resultado = $"{digito1}{auxSoma}{digito2}";
                    //resultado = digito1.ToString() + auxSoma.ToString() + digito2.ToString();
                }
                else
                {
                    resultado = $"{digito1+1}{auxSoma-10}{digito2}";
                    //resultado = (digito1 + 1).ToString() + (auxSoma - 10).ToString() + digito2.ToString();
                }

                Console.WriteLine($"O resultado de 11 x {strNum} é {resultado}");
            }
            */

        }
    }
}