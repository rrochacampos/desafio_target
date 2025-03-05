namespace Desafios
{
    public class Soma
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("[Desafio 1: Soma]");
            int INDICE = 13, SOMA = 0, K = 0;
            
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine($"Valor da variável SOMA: {SOMA}");
            MenuPrincipal();
        }

        private static void MenuPrincipal()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}
