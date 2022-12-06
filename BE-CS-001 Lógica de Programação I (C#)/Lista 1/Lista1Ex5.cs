namespace LP1.Lista1.Ex5
{
    internal class Lista1Ex5
    {
        /*
         * A LBV fez um sorteio cujos bilhetes continham números de 6 dígitos. 
         * O sorteio foi baseado nos dois primeiros prêmios da loteria federal, 
         * sendo o número sorteado formado pelos três últimos dígitos do primeiro 
         * e do segundo prêmio. Por exemplo, se o primeiro prêmio fosse 34.582 
         * e o segundo 54.098, o número da LBV seria 582.098. 
         * Escreva um programa que lê os dois prêmios e retorna o número sorteado.
         */
        static void Main(string[] args)
        {
            string primeiroPremio;
            string segundoPremio;
            bool numInvalido = true;
            bool ehNumero;
            do
            {
                Console.Write("Entre o número do primeiro prêmio da loteria federal: ");
                primeiroPremio = Console.ReadLine();
                if (primeiroPremio.Length >= 5)
                {
                    primeiroPremio = primeiroPremio.Replace(".", "");
                    ehNumero = int.TryParse(primeiroPremio, out _);
                    if (ehNumero){
                        numInvalido = false;
                    }
                }
            } while (numInvalido);
            numInvalido = true;
            do
            {
                Console.Write("Entre o número do segundo prêmio da loteria federal: ");
                segundoPremio = Console.ReadLine();
                if (segundoPremio.Length >= 5)
                {
                    segundoPremio = segundoPremio.Replace(".", "");
                    ehNumero = int.TryParse(segundoPremio.Substring(segundoPremio.Length - 3), out _);
                    if (ehNumero)
                    {
                        numInvalido = false;
                    }
                }
            } while (numInvalido);
            Console.WriteLine($"O número do prêmio da LBV é {primeiroPremio.Substring(primeiroPremio.Length - 3)}.{segundoPremio.Substring(segundoPremio.Length - 3)}");

        }
    }
}