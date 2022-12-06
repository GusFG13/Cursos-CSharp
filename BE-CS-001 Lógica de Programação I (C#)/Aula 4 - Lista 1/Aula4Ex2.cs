namespace LP1.Aula4.Ex2
{
    internal class Aula4Ex2
    {
        //Faça um programa que receba uma frase e retorne na tela a mesma frase sem os espaços.
        static void Main(string[] args)
        {
            string frase;
            do
            {
                Console.Clear();
                Console.WriteLine("Escreva uma frase: ");
                frase = Console.ReadLine();
                if (frase != "")
                {
                    frase = frase.Replace(" ", "");
                    Console.WriteLine(frase);
                }
            } while (frase == "");
        }
    }
}