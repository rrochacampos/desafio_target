using System.Linq;
using Newtonsoft.Json;

namespace Desafios
{
    public static class FaturamentoDiario
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("[Desafio 3: Faturamento Diário]");

            string caminhoDoArquivo = "Data/dados.json";

            Faturamento[]? faturamentoDiario = LerArquivoJson(caminhoDoArquivo);

            if (faturamentoDiario == null || !faturamentoDiario.Any())
            {
                Console.WriteLine("Erro: O arquivo não contém dados válidos.");
                return;
            }

            List<Faturamento> faturamentos = faturamentoDiario.Where(faturamento => faturamento.Valor > 0).ToList();

            //Menor valor de faturamento
            double menorFaturamento = faturamentos.Min(faturamento => faturamento.Valor);

            //Maior valor de faturamento
            double maiorFaturamento = faturamentos.Max(faturamento => faturamento.Valor);

            //Média mensal
            double mediaMensal = faturamentos.Average(faturamento => faturamento.Valor);

            //Número de dias com faturamento superior à média mensal
            int diasAcimaDaMedia = faturamentos.Count(faturamento => faturamento.Valor > mediaMensal);

            Console.WriteLine($"Valor do menor faturamento: {menorFaturamento:C}");
            Console.WriteLine($"Valor do maior faturamento: {maiorFaturamento:C}");
            Console.WriteLine($"Valor da média mensal de faturamento: {mediaMensal:C}");
            Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaDaMedia}");

            MenuPrincipal.Voltar();
        }

        static Faturamento[]? LerArquivoJson(string caminho)
        {
            try
            {
                string json = File.ReadAllText(caminho);
                return string.IsNullOrWhiteSpace(json) ? null : JsonConvert.DeserializeObject<Faturamento[]>(json);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                return null;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Erro ao processar o JSON: {ex.Message}");
                return null;
            }
        }
    }

    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}
