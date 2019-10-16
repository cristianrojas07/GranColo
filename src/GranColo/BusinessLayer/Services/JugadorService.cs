using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    class JugadorService
    {
        readonly JugadorDao JugadorDao = new JugadorDao();
        public int Selected { get; set; }

        internal bool InsertarJugador(Jugador oJugador)
        {
            return JugadorDao.insertJugador(oJugador);
        }

        internal bool ModificarJugador(Jugador oJugador)
        {
            return JugadorDao.modifyJugador(oJugador, Selected);
        }

        internal bool EliminarJugador()
        {
            return JugadorDao.deleteJugador(Selected);
        }

        internal IList<Jugador> ObtenerTodosJugadores()
        {
            return JugadorDao.getAllJugador();
        }

        internal bool ObtenerRepetidos(Jugador oJugador)
        {
            return JugadorDao.getRepeat(oJugador);
        }
    }
}
