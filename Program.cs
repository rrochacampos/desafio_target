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
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Sequência de Fibonacci");
            Console.WriteLine("3 - Faturamento Diário");
            Console.WriteLine("4 - Faturamento Mensal");
            Console.WriteLine("5 - Inverter String");
            Console.WriteLine("S - Sair");
            Console.Write("Escolha um valor entre 1 e 5 para acessar um desafio ou S para sair: ");

            string? opcao = Console.ReadLine() ?? "";

            switch (opcao.ToUpper())
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
                case "5":
                    InverterString.Executar();
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
