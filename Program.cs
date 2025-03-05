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
            Console.WriteLine("2 - Desafio 2");
            Console.WriteLine("3 - Desafio 3");
            Console.WriteLine("4 - Desafio 4");
            Console.WriteLine("S - Sair");
            Console.Write("Escolha um valor entre 1 e 5 para acessar um desafio ou a letra S para sair: ");

            var opcao = Console.ReadLine().ToUpper();

            switch (opcao)
            {
                case "1":
                    Soma.Executar();
                    break;
                case "2":
                    SequenciaFibonacci.Executar();
                    break;
                case "3":
                    FaturamentoDiario.Executar();
                    break;
                case "4":
                    FaturamentoMensal.Executar();
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
