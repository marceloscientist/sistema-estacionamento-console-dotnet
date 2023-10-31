using System;
using SistemaEstacionamento.Models;

namespace SistemaEstacionamento {
    class Program
    {
        static void Main(string[] args)
        {
           Estacionamento estacionamento = new Estacionamento();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Sair");
            
            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe a placa do veículo: ");
                        string placa = Console.ReadLine();
                        Veiculo veiculo = new Veiculo(placa);
                        estacionamento.AdicionarVeiculo(veiculo);
                        break;
                    case 2:
                        Veiculo veiculoRemovido = estacionamento.RemoverVeiculo();
                        if (veiculoRemovido != null)
                        {
                            Console.WriteLine($"Veículo com placa {veiculoRemovido.Placa} removido. Valor cobrado: R$ {veiculoRemovido.CalcularValorCobrado():F2}");
                        }
                        else
                        {
                            Console.WriteLine("Estacionamento vazio.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Veículos estacionados:");
                        estacionamento.ListarVeiculos();
                        break;
                    case 4:
                        Console.WriteLine("Saindo do sistema.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
        }
    }
}
