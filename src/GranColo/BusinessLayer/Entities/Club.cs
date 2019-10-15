using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Entities
{
    class Club
    {
        public int IdClub { get; set; }
        public string Nombre { get; set; }
        public string FechaFundacion { get; set; }
        public string NombreEstadio { get; set; }
        public int Aforo { get; set; }
        public Localidad Localidad { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
    }
}
