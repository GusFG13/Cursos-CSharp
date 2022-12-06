using System.Data;
using System.Net;
using System.Runtime.Intrinsics.X86;

namespace LP1.Lista1.Ex1
{
    internal class Lista1Ex1
    {
        /*
         * Um estudante ia participar de uma feira de ciências e seu projeto tinha o tema "fotossíntese". 
         * Ele conseguiu um notebook emprestado, e queria um programa que lhe permitisse apresentar um 
         * texto dividido em partes, cada parte em uma tela, e o programa deveria mudar para a próxima 
         * tela ao toque de uma tecla. A tela inicial deve ser a palavra "FOTOSSÍNTESE" escrita com letras 
         * grandes. Faça o programa para o estudante, usando o texto abaixo, no qual cada parágrafo deve 
         * aparecer em uma tela diferente. 

         * Texto:
         * "A água e os sais minerais absorvidos pelas raízes sobem através dos vasos lenhosos do
         * caule e chegam às folhas.
         * Nas folhas, existe uma substância verde, a clorofila, que absone a energia luminosa do sol.
         * Ao mesmo tempo, por meio dos estômatos presentes nas folhas, a planta absorve gás carbônico do
         * ar.
         * Usando a energia solar, o gás carbônico e o hidrogênio contido na água retirada do solo,
         * após complicadas reações químicas, a planta produz açúcares (glicose). "
         */
        static void Main(string[] args)
        {
            string[] titulo = { 
                "  ______ ____ _______ ____   _____ _____ __ _   _ _______ ______  _____ ______ ",
                " |  ____/ __ \\__   __/ __ \\ / ____/ ____/_/| \\ | |__   __|  ____|/ ____|  ____|",
                " | |__ | |  | | | | | |  | | (___| (___|_ _|  \\| |  | |  | |__  | (___ | |__   ",
                " |  __|| |  | | | | | |  | |\\___ \\ ___ \\| || . ` |  | |  |  __|  \\___ \\|  __|  ",
                " | |   | |__| | | | | |__| |____) |___) | || |\\  |  | |  | |____ ____) | |____ ",
                " |_|    \\____/  |_|  \\____/|_____/_____/___|_| \\_|  |_|  |______|_____/|______|"};
            string[] texto = {"A água e os sais minerais absorvidos pelas raízes sobem através dos vasos lenhosos do caule e chegam às folhas.",
                            "Nas folhas, existe uma substância verde, a clorofila, que absone a energia luminosa do sol.",
                            "Ao mesmo tempo, por meio dos estômatos presentes nas folhas, a planta absorve gás carbônico do ar.",
                            "Usando a energia solar, o gás carbônico e o hidrogênio contido na água retirada do solo, após complicadas reações químicas, a planta produz açúcares (glicose)."};
            Console.Clear();
            for (int i = 0; i < titulo.Length; i++)
            {
                Console.WriteLine(titulo[i]);
            }
            Console.ReadKey(true);
            for (int i = 0; i< texto.Length; i++)
            {
                Console.Clear();
                Console.WriteLine(texto[i]);
                Console.ReadKey(true);
            }
 
        }
    }
}