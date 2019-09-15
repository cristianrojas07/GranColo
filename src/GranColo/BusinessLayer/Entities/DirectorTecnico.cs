using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer
{
    class DirectorTecnico
    {
        public int idDirectorTecnico { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int nroDoc { get; set; }
        public int tipoDoc { get; set; }
        public string nombreUsuario { get; set; } 
        public string password { get; set; }
        public string email { get; set; }
        public int idClubHincha { get; set; }

    }
}
