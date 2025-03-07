namespace Desafios
{
    public static class FaturamentoMensal
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("[Desafio 4: Faturamento Mensal]");

            List<FaturamentoPorEstado> faturamentos = new List<FaturamentoPorEstado>
            {
                new FaturamentoPorEstado("SP", 67836.43),
                new FaturamentoPorEstado("RJ", 36678.66),
                new FaturamentoPorEstado("MG", 29229.88),
                new FaturamentoPorEstado("ES", 27165.48),
                new FaturamentoPorEstado("Outros", 19849.53)
            };

            double totalFaturamento = faturamentos.Sum(f => f.Valor);

            Console.WriteLine($"Valor total mensal da distribuidora: {totalFaturamento:C}");
            Console.WriteLine();

            foreach (FaturamentoPorEstado faturamento in faturamentos)
            {
                double percentual = faturamento.Valor / totalFaturamento * 100;
                Console.WriteLine($"Percentual de {faturamento.Estado}: {percentual:F2}%");
            }

            MenuPrincipal.Voltar();
        }
    }

    public class FaturamentoPorEstado
    {
        public string Estado { get; set; }
        public double Valor { get; set; }

        public FaturamentoPorEstado(string estado, double valor)
        {
            Estado = estado;
            Valor = valor;
        }
    }
}
