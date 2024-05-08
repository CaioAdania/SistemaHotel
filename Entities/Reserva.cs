using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Entities
{
    internal class Reserva
    {
        public Hospede Hospede { get; set; }
        public Quarto Quarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

    }
}
