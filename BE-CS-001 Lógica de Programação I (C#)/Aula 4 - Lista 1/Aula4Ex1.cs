namespace LP1.Aula4.Ex1
{
    internal class Aula4Ex1
    {
        //Faça um programa que recebe uma frase e substitui todas as ocorrências de espaço por “#”. Mostre o resultado no console.
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
                    frase = frase.Replace(' ', '#');
                    Console.WriteLine(frase);
                }
            } while (frase == "");
        }
    }
}