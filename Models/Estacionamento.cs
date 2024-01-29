using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_estacionamento.Models
{
    public class Estacionamento
    {
        public Estacionamento()
        {
            Veiculos = new List<string>();
        }
        private List<string> Veiculos;

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo: ");
            string placa = Console.ReadLine();
            Veiculos.Add(placa);
            Console.WriteLine("Pressione ENTER para avançar");
            Console.ReadLine();
            Console.Clear();
        }

        public void RemoverVeiculo(int initialRate, int hourRate)
        {
            if (Veiculos.Count == 0)
            {
                Console.WriteLine("Estacionamento vazio.");
                Console.WriteLine("Pressione ENTER para avançar");
                Console.ReadLine();
                Console.Clear();
                return;

            }
            Console.WriteLine("Informe a placa do veículo: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Informe quantas horas o veículo ficou: ");
            int.TryParse(Console.ReadLine(), out int hours);
            int tax = initialRate + (hours * hourRate);
            Veiculos.Remove(placa);
            Console.WriteLine($"O veículo de placa {placa} foi removido e o valor é de {tax:C}");
            Console.WriteLine("Pressione ENTER para avançar");
            Console.ReadLine();
            Console.Clear();
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Count == 0)
            {
                Console.WriteLine("Estacionamento vazio.");
                Console.WriteLine("Pressione ENTER para avançar");
                Console.ReadLine();
                Console.Clear();
                return;

            }
            for (int i = 0; i < Veiculos.Count; i++)
            {
                Console.WriteLine($"Veiculo {i + 1}: {Veiculos[i]}");
            }
            Console.WriteLine("Pressione ENTER para avançar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}