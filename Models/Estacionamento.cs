using System;
using System.Collections.Generic;

namespace SistemaEstacionamento.Models
{
    class Estacionamento
    {
        private Queue<Veiculo> veiculosEstacionados = new Queue<Veiculo>();

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculosEstacionados.Enqueue(veiculo);
            Console.WriteLine($"Veículo com placa {veiculo.Placa} adicionado ao estacionamento.");
        }

        public Veiculo RemoverVeiculo()
        {
            if (veiculosEstacionados.Count > 0)
            {
                return veiculosEstacionados.Dequeue();
            }
            return null;
        }

        public void ListarVeiculos()
        {
            if (veiculosEstacionados.Count == 0)
            {
                Console.WriteLine("Estacionamento vazio.");
            }
            foreach (Veiculo veiculo in veiculosEstacionados)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}, Entrada: {veiculo.Entrada}");
            }
        }
    }
}
