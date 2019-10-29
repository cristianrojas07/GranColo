using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Entities
{
    public class Equipo
    {
        private List<Jugador> _jugadores;

        public Equipo()
        {
            _jugadores = new List<Jugador>();
        }

        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public DirectorTecnico DT { get; set; }
        public string Lema { get; set; }
        public Color Color { get; set; }

        public List<Jugador> GetJugadores() { return _jugadores; }

        public void AgregarJugador(Jugador IdJugador)
        {
            _jugadores.Add(IdJugador);
        }
    }
}
