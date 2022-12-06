namespace LP1.Aula4.ListaDatasEx2
{
    internal class Program
    {
        /*
         * Faça um programa que receba 6 numeros inteiros, representando dia, mês, ano, quantidade de 
         * dias que deverá ser adicionados nessa data, quantidade de meses que deverá ser adicionados 
         * nessa data e quantidade de anos que deverá ser adicionados nessa data, respectivamente. Exiba 
         * a data resultante.
         */
        static void Main(string[] args)
        {
            short dia;
            short mes;
            short ano;
            short somaDias;
            short somaMeses;
            short somaAnos;

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
            ehNum = false;

            //verificar se dia é válido no mês (31 em meses de 30 dias, ou 29/02 em anos não bissextos)
            if (dia == 31)
            {
                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    Console.WriteLine($"Data inválida. {new DateTime(ano, mes, 01).ToString("MMMM").ToUpper()} tem apenas 30 dias");
                }
                else if (mes == 2)
                {
                    Console.WriteLine($"Data inválida. FEVEREIRO tem menos de 30 dias");
                }
                else
                {
                    dataValida = true;
                }
            }
            else if (dia == 30 && mes == 2)
            {
                Console.WriteLine($"Data inválida. FEVEREIRO tem menos de 30 dias");
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
                    Console.WriteLine($"Data inválida. {ano} não é bissexto. FEVEREIRO tem apenas 28 dias");
                }
            }
            else
            {
                dataValida = true;
            }
            if (dataValida)
            {
                //imprimir mensagem.
                data = new DateTime(ano, mes, dia);
                Console.WriteLine($"A data informada é {data.ToString("dd/MM/yyyy")}.");
                do
                {
                    Console.Write("Digite o número de dias que deseja somar nesta data: ");
                    ehNum = short.TryParse(Console.ReadLine(), out somaDias);
                } while (!ehNum);
                ehNum = false;
                do
                {
                    Console.Write("Digite o número de meses que deseja somar nesta data: ");
                    ehNum = short.TryParse(Console.ReadLine(), out somaMeses);
                } while (!ehNum);
                ehNum = false;
                do
                {
                    Console.Write("Digite o número de anos que deseja somar nesta data: ");
                    ehNum = short.TryParse(Console.ReadLine(), out somaAnos);
                } while (!ehNum);
                data = data.AddDays(somaDias);
                data = data.AddMonths(somaMeses);
                data = data.AddYears(somaAnos);
                Console.WriteLine($"A data calculada é {data.ToString("dd/MM/yyyy")}.");
            }
        }
    }
}