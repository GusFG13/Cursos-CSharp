namespace LP1.Lista1.Ex2
{
    internal class Lista1Ex2
    {
        /*
         * Calcule as expressões abaixo, observando a precedência dos operadores. 
         * Escreva um programa que mostre na tela o resultado de cada expressão e 
         * confira seus cálculos.
         *   26 + 115 =
         *   20/(-2)/5 =
         *   20/22 =
         *   (3+9)/34 =
         *   (56/(3+2) - 154)/6-4 =
         *   4+322 -72/(9-2) =
         */
        static void Main(string[] args)
        {
            double eq1 = 26d + 115d;
            double eq2 = 20d / (-2d) / 5d;
            double eq3 = (20d / 22d);
            double eq4 = (3d + 9d) / 34d;
            double eq5 = (56d / (3d + 2d) - 154d) / (6d - 4d);
            double eq6 = 4d + 322d - 72d / (9d - 2d);

            Console.WriteLine($"26 + 115 = {eq1.ToString("0.###")}");
            Console.WriteLine($"20/(-2)/5 = {eq2.ToString("0.###")}");
            Console.WriteLine($"20/22 = {eq3.ToString("0.###")}");
            Console.WriteLine($"(3+9)/34 = {eq4.ToString("0.###")}");
            Console.WriteLine($"(56/(3+2) - 154)/6-4 = {eq5.ToString("0.###")}");
            Console.WriteLine($"4+322 -72/(9-2) = {eq6.ToString("0.###")}");
        }
    }
}