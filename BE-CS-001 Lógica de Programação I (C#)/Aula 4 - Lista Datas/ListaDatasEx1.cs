namespace LP1.Aula4.ListaDatasEx1
{
    internal class Program
    {
        /*
         * Faça um programa que receba 3 numeros inteiros, representando dia, mês e ano, respectivamente. Depois disso, exiba na tela uma frase como no exemplo:
         * Dia = 1 Mês = 12 Ano = 2022
         * Frase exibida = "Bom dia, hoje é 01 de dezembro de 2022."
         * Utilize a classe DateTime para criar a data e a formatação de string para pegar a data por extenso.
         */
        static void Main(string[] args)
        {
            short dia;
            short mes; 
            short ano;

            bool diaInvalido = true;
            bool mesInvalido = true;
            bool anoInvalido = true;
            bool dataValida = false;
            bool ehNum = false;

            DateTime data;
   
            //validação de entradas (apenas números)
            do
            {
                Console.Write("Digite o dia: ");
                ehNum = short.TryParse(Console.ReadLine(), out dia);
                if (ehNum && dia >= 1 && dia <= 31)
                {
                    diaInvalido = false;
                }
            } while (diaInvalido);
            ehNum = false;
            do
            {
                Console.Write("Digite o mês: ");
                ehNum = short.TryParse(Console.ReadLine(), out mes);
                if (ehNum && mes >= 1 && mes <= 12)
                {
                    mesInvalido = false;
                }
            } while (mesInvalido);
            ehNum = false;
            do
            {
                Console.Write("Digite o ano: ");
                ehNum = short.TryParse(Console.ReadLine(), out ano);
                if (ehNum && ano >= 0)
                {
                    anoInvalido = false;
                }
            } while (anoInvalido);

            //verificar se dia é válido no mês (31 em meses de 30 dias, ou 29/02 em anos não bissextos)
            if (dia == 31)
            {
                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    Console.WriteLine($"Dia inválido. {new DateTime(ano, mes, 01).ToString("MMMM").ToUpper()} tem apenas 30 dias");
                } 
                else if (mes == 2) 
                {
                    Console.WriteLine($"Dia inválido. FEVEREIRO tem menos de 30 dias");
                }
                else
                {
                    dataValida= true;
                }
            }
            else if (dia == 30 && mes == 2)
            {
                Console.WriteLine($"Dia inválido. FEVEREIRO tem menos de 30 dias");
            }
            else if (dia == 29 && mes == 2)
            {
                //verifica se é ano bissexto
                if ((((ano % 4 == 0) && (ano % 100 != 0)) || (ano % 400 == 0)))
                {
                    dataValida = true;
                }
                else
                {
                    Console.WriteLine($"Dia inválido. {ano} não é bissexto. FEVEREIRO tem apenas 28 dias");
                }
            }
            else
            {
                dataValida = true;
            }
            if (dataValida)
            {
                //imprimir mensagem. Exemplo:
                //"bom dia, hoje é 01 de dezembro de 2022."
                data = new DateTime(ano, mes, dia);
                Console.WriteLine($"bom dia, hoje é {data.ToString("dd 'de' MMMM 'de' yyyy")}.");
            }
        }
    }
}