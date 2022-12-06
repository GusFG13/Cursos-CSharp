namespace LP1.Lista1.Ex3
{
    internal class Lista1Ex3
    //Escreva um programa que lê nome e sobrenome, e mostra na tela as iniciais.
    {
        static void Main(string[] args)
        {
            string nome;
            string iniciais = "";
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
                        iniciais += palavra.First();
                    }
                }
           
            } while (nome == "");
            if (iniciais != "")
            {
                Console.WriteLine($"Suas iniciais são: {iniciais.ToUpper()}");    
            }
        }
    }
}