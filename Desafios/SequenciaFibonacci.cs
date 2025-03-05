namespace Desafios
{
    public class SequenciaFibonacci
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("[Desafio 2: Sequência de Fibonacci]");
            Console.Write("Informe um número inteiro: ");
            
            int numeroInformado = int.Parse(Console.ReadLine());
            int primeiroNum = 0, segundoNum = 1, numAtual = 0;

            while (numAtual < numeroInformado)
            {
                numAtual = primeiroNum + segundoNum;
                primeiroNum = segundoNum;
                segundoNum = numAtual;
            }

            if (numAtual == numeroInformado)
            {
                Console.WriteLine($"O número {numeroInformado} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numeroInformado} não pertence à sequência de Fibonacci.");
            }
            MenuPrincipal();
        }

        private static void MenuPrincipal()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}
