namespace LP1.Lista1.Ex4
{
    internal class Lista1Ex4
    {
        //Reescreva o programa anterior para mostrar na tela as letras finais do nome e sobrenome.
        static void Main(string[] args)
        {
            string nome;
            string finais = "";
            string[] palavras;
            do
            {
                Console.Clear();
                Console.WriteLine("Escreva seu nome completo:");
                nome = Console.ReadLine();
                if (nome != "")
                {
                    palavras = nome.Split(" ");
                    foreach (string palavra in palavras)
                    {
                        finais += palavra.Last();
                    }
                }

            } while (nome == "");
            if (finais != "")
            {
                Console.WriteLine($"Suas iniciais são: {finais.ToUpper()}");
            }
        }
    }
}