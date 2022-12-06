namespace LP1.Aula4.Ex5
{
    internal class Aula4Ex5
    {
        /*
         * Seu objetivo é criar uma função que remova o primeiro e o último caractere de uma string.
         * Você recebe um parâmetro, a string original. Você não precisa se preocupar com strings 
         * com menos de dois caracteres.
         */
        static void Main(string[] args)
        {
            string frase;
            do
            {
                Console.Clear();
                Console.WriteLine("Escreva um texto com mais de 2 caracteres: ");
                frase = Console.ReadLine();
                if (frase != "")
                {
                    if (frase.Length > 2)
                    {
                        frase = frase.Remove(frase.Length - 1, 1).Remove(0, 1);
                        Console.WriteLine(frase);
                    } else {
                        frase = "";
                    }
                }
            } while (frase == "");
        }
    }
}