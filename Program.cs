using System;
using System.IO;
using Desafios;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("[Menu Desafio Target]");
            Console.WriteLine("1 - Desafio 1");
            Console.WriteLine("S - Sair");
            Console.Write("Escolha um valor entre 1 e 5 para acessar um desafio ou a letra S para sair: ");

            var opcao = Console.ReadLine().ToUpper();

            switch (opcao)
            {
                case "1":
                    Soma.Executar();
                    break;
                case "S":
                    Console.Clear();
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para reiniciar.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
