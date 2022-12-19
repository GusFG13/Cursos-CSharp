using System;

namespace LP1.Lista3.Ex4
{
    internal class LP1Lista3Ex4
    {
        /*
         * 4. Crie um programa que pede para o usuário digitar o nome de cinco produtos e 
         *    o respectivo preço deles. Salve o nome e o preço em um dicionário.
         *    Depois, peça para o usuário informar o nome de um produto e uma quantidade; 
         *    em seguida, imprima o valor total.
         */
        static void Main(string[] args)
        {
            string produto;
            string strPreco;
            float preco;
            int i = 1;
            float quantidade;
            bool prodValido;
            Dictionary<string, float> tabPrecos = new Dictionary<string, float>();

            Console.WriteLine("Digite o preço de 5 produtos e seus respectivos preços:\n");
            do
            {
                produto = string.Empty;
                do
                {
                    Console.Write($"Digite o nome do {i}o. produto: ");
                    produto = Console.ReadLine();
                    if (produto != "")
                    {
                        //verifica se item já existe, se não existir insere item. Se existir avisa o usuário que nome já está cadastrado e pede novo nome
                        if (tabPrecos.ContainsKey(produto))
                        {
                            Console.WriteLine($"Nome \"{produto}\" já cadastrado.");
                            produto = string.Empty;
                        }
                    }
                } while (produto == "");
                do 
                {
                    Console.Write($"Digite o preço do {i}o. produto ({produto}): ");
                    strPreco = Console.ReadLine().Replace('.',',');
                } while (!float.TryParse(strPreco, out preco));

                tabPrecos.Add(produto, preco);
                i++;

                
            } while (i <= 5);
            Console.WriteLine("Produtos cadastrados com sucesso.\n");
            do
            {
                Console.Write($"Digite o nome do produto desejado: ");
                produto = Console.ReadLine();
                prodValido = tabPrecos.ContainsKey(produto);
            } while (!prodValido);
            do
            {
                Console.Write($"informe a quantidade: ");
            } while (!float.TryParse(Console.ReadLine(), out quantidade));

            Console.WriteLine($"O preço de {quantidade} unidades de \"{produto}\" é : {(quantidade * tabPrecos[produto]).ToString("0.00")}");
        }
    }
}