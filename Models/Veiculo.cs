using System;

namespace SistemaEstacionamento.Models {
    class Veiculo
    {
        public string Placa { get; private set; }
        public DateTime Entrada { get; private set; }

        public Veiculo(string placa)
        {
            Placa = placa;
            Entrada = DateTime.Now;
        }

        public double CalcularValorCobrado()
        {
            TimeSpan tempoEstacionado = DateTime.Now - Entrada;
            int horasEstacionado = (int)Math.Ceiling(tempoEstacionado.TotalHours);
            return horasEstacionado * 5.0; // Preço por hora
        }
    }
}