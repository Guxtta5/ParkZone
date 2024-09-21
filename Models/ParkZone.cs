using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkZone.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
    
            Console.WriteLine("Qual é a placa do veículo que deseja estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Qual é a placa do veículo que ira retirar: ");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Quantas horas o veículo permaneceu no ParkZone? ");

                // dando entrada na quantidade de horas 
                string input = Console.ReadLine();
                int horas = int.Parse(input);
                // calculo sobra o total a se pagar 
                decimal valorTotal = precoPorHora * horas + precoInicial;


                veiculos.Remove(placa);
                Console.WriteLine($"O veículo com a Placa{placa} foi retirado....");
                Console.WriteLine($"O preço Total pela estadia do veículo é de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe esse veículo não conta em nosso sistemas...");
                Console.WriteLine("Confira se digitou a placa certa, caso esteja correta esse veiculo não foi estacionado aqui");
            }
        }

        public void ListarVeiculos()
        {
            //Verifica se tem algum veiculo no estabelecimento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                int contador = 0;
                foreach (var quantidade in veiculos)
                {
                    Console.WriteLine($"O N°{contador + 1} veículo - {quantidade}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há nenhums veículos estacionado..");
            }
        }       
    }
}