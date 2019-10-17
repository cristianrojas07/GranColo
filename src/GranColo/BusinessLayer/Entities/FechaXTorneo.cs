using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Entities
{
    public class FechaXTorneo
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

        public int IdFecha
        {
            get
            {
                return Fecha.IdFecha;
            }
        }

        public string TorneoNombre
        {
            get
            {
                return Torneo.Nombre;
            }
        }

        public int IdTorneo
        {
            get
            {
                return Torneo.IdTorneo;
            }
        }
    }
}
