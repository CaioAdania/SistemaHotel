using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.Entities;
using SistemaHotel.Entities.Enums;

namespace SistemaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando alguns quartos
            List<Quarto> quartos = new List<Quarto>
        {
            new Quarto { Numero = 108, Tipo = TipoQuarto.Individual, Disponivel = true },
            new Quarto { Numero = 208, Tipo = TipoQuarto.Individual, Disponivel = true },
            new Quarto { Numero = 408, Tipo = TipoQuarto.Duplo, Disponivel = true },
            new Quarto { Numero = 428, Tipo = TipoQuarto.Duplo, Disponivel = true },
            new Quarto { Numero = 848, Tipo = TipoQuarto.Suite, Disponivel = true },
            new Quarto { Numero = 888, Tipo = TipoQuarto.Suite, Disponivel = true },
        };

            // Exibindo os quartos disponíveis
            Console.WriteLine("Quartos disponíveis:");
            foreach (var quarto in quartos)
            {
                if (quarto.Disponivel)
                    Console.WriteLine($"Número: {quarto.Numero}, Tipo: {quarto.Tipo}");
            }

            // Entrada de dados do hóspede
            Console.WriteLine();
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Hospede hospede = new Hospede { Nome = nome, Idade = idade};

            // escolhendo uma reserva
            Console.WriteLine();
            Console.Write("Qual Quarto deseja: ");
            int numeroQuartoEscolhido = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Tempo de estadia: ");
            int estadia = int.Parse(Console.ReadLine());
            Console.WriteLine();
           
            Quarto quartoEscolhido = quartos.Find(q => q.Numero == numeroQuartoEscolhido && q.Disponivel);

            if (quartoEscolhido != null)
            {
                Reserva reserva = new Reserva
                {
                    Hospede = hospede,
                    Quarto = quartoEscolhido,
                    DataEntrada = DateTime.Today,
                    DataSaida = DateTime.Today.AddDays(estadia)
                };

                reserva.Quarto.Disponivel = false;

                Console.WriteLine("Reserva feita com sucesso:");
                Console.WriteLine($"Hóspede: {reserva.Hospede.Nome}");
                Console.WriteLine($"Quarto: {reserva.Quarto.Numero}");
                Console.WriteLine($"Tipo: {reserva.Quarto.Tipo}");
                Console.WriteLine($"Data de Entrada: {reserva.DataEntrada.ToShortDateString()}");
                Console.WriteLine($"Data de Saída: {reserva.DataSaida.ToShortDateString()}");
                Console.WriteLine();
                Console.WriteLine("Obrigado e Aproveite a sua Estadia!");
            }
            else
            {
                Console.WriteLine("Quarto selecionado não está disponível ou não existe.");
            }
        }
    }
}
