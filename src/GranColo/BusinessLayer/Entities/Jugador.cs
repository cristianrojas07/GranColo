using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Entities
{
    class Jugador
    {
        public int IdJugador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }    
        public Club Club { get; set; }
        public Posicion Posicion { get; set; }
        public EstadoActual EstadoActual { get; set; }
        public int NroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public decimal Costo { get; set; }
        public string Estado { get; set; }

        public string ClubNombre
        {
            get
            {
                return Club.Nombre;
            }
        }
        public string PosicionNombre
        {
            get
            {
                return Posicion.Nombre;
            }
        }
        public string EstadoActualNombre
        {
            get
            {
                return EstadoActual.Nombre;
            }
        }
        public string TipoDocumentoNombre
        {
            get
            {
                return TipoDocumento.Nombre;
            }
        }
    }
}
