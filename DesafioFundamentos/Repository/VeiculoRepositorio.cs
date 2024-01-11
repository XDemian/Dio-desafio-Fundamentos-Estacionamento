using DesafioFundamentos.Models;

namespace Repository
{
    public class VeiculoRepositorio
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();

        public static void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public static List<Veiculo> ListarTodosVeiculos()
        {
            return veiculos;
        }

        public static bool ExisteVeiculoPorPlaca(string placa)
        {
            return veiculos.Any(e => e.Placa == placa);
        }

        public static Veiculo ListarUmVeiculo(string placa)
        {
            return veiculos.FirstOrDefault(e => e.Placa == placa);
        }

        public static void DeletarVeiculo(string placa)
        {
            var veiculo = ListarUmVeiculo(placa);
            veiculos.Remove(veiculo);
        }
    }
}