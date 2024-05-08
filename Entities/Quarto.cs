using SistemaHotel.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Entities
{
    internal class Quarto
    {
        public int Numero { get; set; }
        public TipoQuarto Tipo { get; set; }
        public bool Disponivel { get; set; }
    }
}
