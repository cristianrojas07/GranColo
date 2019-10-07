using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Entities
{
    class FechaXTorneo
    {
        public Fecha Fecha { get; set; }
        public Torneo Torneo { get; set; }
        public string Estado { get; set; }

        
        public string FechaNombre
        {
            get
            {
                return Fecha.Nombre;
            }
        }

        public string TorneoNombre
        {
            get
            {
                return Torneo.Nombre;
            }
        }
    }
}
