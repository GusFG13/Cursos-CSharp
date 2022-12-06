namespace LP1.Lista2.Ex5
{
    internal class Lista2Ex5
    {
        /*
         * 5. Ímpares múltiplos 1 - Escreva um programa que soma todos os números ímpares 
         *    múltiplos de três situados na faixa de 1 a 1000.
         */
        static void Main(string[] args)
        {
            int soma = 0;
            #region Versao 1
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        soma += i;
            //    }
            //}
            #endregion
            #region Versao 2
            //for (int i = 3; i <= 1000; i = i + 3)
            //{
            //        soma += i;
            //}
            #endregion
            #region Versao 3
            int i = 3;
            while(i < 1000){
                soma += i;
                i = i + 3;
            }
            #endregion

            Console.WriteLine($"A soma dos números ímpares múltiplos de três entre 1 e 1000 é {soma}"); //166833
        }
    }
}