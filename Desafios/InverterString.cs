namespace Desafios
{
    public class InverterString
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("[Desafio 5: Inverter String]");
            
        Console.Write("\nDigite uma string: ");

        string original = Console.ReadLine();
        string invertida = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];
        }

        Console.WriteLine("\nString original: " + original);
        Console.WriteLine("String invertida: " + invertida);

            MenuPrincipal();
        }

        private static void MenuPrincipal()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}
