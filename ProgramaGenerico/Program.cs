namespace ProgramaGenerico
{
    //programa para treinamentos gerais
    internal class Program
    {
        static void Main(string[] args)
        {
            //enfeite
            Console.WriteLine("*******************************");
            Console.WriteLine("|||||||||||||||||||||||||||||||");

            //aqui coleta o nome
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\nSeja bem vindo, " + nome + "\n");
            

            //usa um for loop do tamanho do nome da pessoa, quanto maior, mais cervejas
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Número de Cervejas Artesanais que deseja tomar: " + i);
            }

            //demonstracao de uso de um dicionario (chave, valor)
            Dictionary<string, string> dicionario = new Dictionary<string, string>
            {

                    { "AC", "Acre" },
                    { "AL", "Alagoas" },
                    { "AP", "Amapá" },
                    { "AM", "Amazonas" },
                    { "BA", "Bahia" },
                    { "CE", "Ceará" },
                    { "DF", "Distrito Federal" },
                    { "ES", "Espírito Santo" },
                    { "GO", "Goiás" },
                    { "MA", "Maranhão" },
                    { "MT", "Mato Grosso" },
                    { "MS", "Mato Grosso do Sul" },
                    { "MG", "Minas Gerais" },
                    { "PA", "Pará" },
                    { "PB", "Paraíba" },
                    { "PR", "Paraná" },
                    { "PE", "Pernambuco" },
                    { "PI", "Piauí" },
                    { "RJ", "Rio de Janeiro" },
                    { "RN", "Rio Grande do Norte" },
                    { "RS", "Rio Grande do Sul" },
                    { "RO", "Rondônia" },
                    { "RR", "Roraima" },
                    { "SC", "Santa Catarina" },
                    { "SP", "São Paulo" },
                    { "SE", "Sergipe" },
                    { "TO", "Tocantins" }

            };

            //aqui coleta a sigla do estado, só funciona em letra Maiuscula
            Console.WriteLine("\nQual o melhor estado para se morar? Digite a Sigla com Letras Maiúsculas: ");

            //usando bloco de try catch pois basta digitar em letra minuscula que dará problema
            try
            {
                string insiraEstado = Console.ReadLine();
                string estadoBom = dicionario[insiraEstado];
                Console.WriteLine($"O melhor estado para se morar é: {estadoBom}");
            }
            catch
            {
                Console.WriteLine("Digitação Incorreta");
            }
            finally
            {
                Console.WriteLine("\nRepetindo: \n");
            }

            //agora testa de outra forma, com validação de input
            Console.WriteLine("Qual o melhor estado para se morar? Digite a Sigla com Letras Maiúsculas: ");

            string insiraEstado2 = Console.ReadLine();
            string nomeCompleto;

            //usa um metodo TryGetValue 
            if (dicionario.TryGetValue(insiraEstado2, out nomeCompleto))
            {
                //usa uma forma alternativa de inserir variaveis dentro da string, respectivamente
                Console.WriteLine("O melhor estado para se morar é {0}, ou seja, {1}.", insiraEstado2, nomeCompleto);
            }
            else
            {
                Console.WriteLine("Estado {0} não encontrado.\n", insiraEstado2);
            }

            //dessa forma abaixo precisa parenteses na criacao da lista
            //lista de inteiros, somente aceita valores inteiros
            List<int> Salario = new List<int>();
            Salario.Add(8000);
            Salario.Add(15000);
            Salario.Add(30000);

            Console.WriteLine("\nO salário de um Dev é de: {0} a {1}, podendo chegar a {2}", Salario[0], Salario[1], Salario[2]);
            Console.WriteLine("\nMas isso é com maior experiência.\n");

            //aqui uma forma mais compacta e rapida de inserir valores, nao precisa parenteses
            //lista double para ter casas decimais
            List<decimal> Salarinho = new List<decimal>
            {
                4589.51M,
                5514.34M,
                6521.22M
            };

            Console.WriteLine("No início da carreira espera-se {0} a {1}, podendo chegar a {2}.", Salarinho[0], Salarinho[1], Salarinho[2]);

            Console.WriteLine("\nQual salario gostaria de ter? \n");

            //mais uma lista, dessa vez com input de valor pelo usuario
            List<decimal> pedeValor = new List<decimal>();
            pedeValor.Add(decimal.Parse(Console.ReadLine()));

            Console.WriteLine($"\nO valor de {pedeValor[0]} parece digno");

            Console.WriteLine($"\nQue tal receber {pedeValor[0] * 2}, {nome}?");

            Console.WriteLine("\nBasta estudar e trabalhar muito :P");

        }
    }
}