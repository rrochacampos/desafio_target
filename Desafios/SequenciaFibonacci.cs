namespace Desafios
{
    public static class SequenciaFibonacci
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("[Desafio 2: Sequência de Fibonacci]");
            int primeiroNum = 0, segundoNum = 1, numAtual = 0;
            int numeroInformado;

            while (true)
            {
                Console.Write("Digite um número inteiro: ");

                string? numeroEntrada = Console.ReadLine();

                if (int.TryParse(numeroEntrada, out numeroInformado))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            while (numAtual < numeroInformado)
            {
                numAtual = primeiroNum + segundoNum;
                primeiroNum = segundoNum;
                segundoNum = numAtual;
            }

            Console.WriteLine($"O número {numeroInformado} {(numAtual == numeroInformado ? "pertence" : "não pertence")} à sequência de Fibonacci.");

            MenuPrincipal.Voltar();
        }
    }
}
