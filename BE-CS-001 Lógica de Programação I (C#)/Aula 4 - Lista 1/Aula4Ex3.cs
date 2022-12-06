namespace LP1.Aula4.Ex3
{
    internal class Aula4Ex3
    {
        //Faça um programa que receba uma frase mostre na tela essa frase com a informação " - Fim da frase" no final da mesma.
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
                    Console.WriteLine(frase + " - Fim da frase");
                }
            } while (frase == "");
        }
    }
}