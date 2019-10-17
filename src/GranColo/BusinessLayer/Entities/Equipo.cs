using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Entities
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public DirectorTecnico DT { get; set; }
        public string Lema { get; set; }
        public Color Color { get; set; }
    }
}
