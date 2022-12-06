namespace LP1.Lista2.Ex7
{
    internal class Lista2Ex7
    {
        /*
         * 7. Inserção de caractere 1 - Implementar um programa que insere hífens entre as letras de uma
         *    cadeia de caracteres, como em f-a-b-u-l-o-s-o.
         */
        static void Main(string[] args)
        {
            //string palavra = "fabuloso";
            Console.WriteLine("Digite uma cadeia de caracteres:");
            string palavra = Console.ReadLine();
            string strAux = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                strAux += (palavra[i] + "-");
            }
            strAux = strAux.Remove(strAux.Length - 1);
            Console.WriteLine(strAux);
        }
    }
}