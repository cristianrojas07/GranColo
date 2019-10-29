using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Entities
{
    public class Equipo
    {
        private List<int> _jugadores;

        public Equipo()
        {
            _jugadores = new List<int>();
        }

        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public DirectorTecnico DT { get; set; }
        public string Lema { get; set; }
        public Color Color { get; set; }

        public List<int> GetJugadores() { return _jugadores; }

        public void AgregarJugador(int IdJugador)
        {
            _jugadores.Add(IdJugador);
        }
    }
}
