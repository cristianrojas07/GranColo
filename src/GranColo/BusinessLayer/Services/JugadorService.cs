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

        internal IList<Jugador> ObtenerTodosJugadoresSinPuntaje(Dictionary<string, object> parametros)
        {
            return JugadorDao.getAllJugadorSinPuntaje(parametros);
        }

        internal bool ObtenerRepetidos(Jugador oJugador)
        {
            return JugadorDao.getRepeat(oJugador);
        }

        internal IList<Jugador> ConsultarJugadoresConFiltros(Dictionary<string, object> parametros)
        {
            return JugadorDao.GetJugadorByFilters(parametros);
        }

        internal bool actualizarPuntaje(Jugador jugadorSeleccionado, int nroFechaSeleccionado, int idTorneoSeleccionado)
        {
            return JugadorDao.updatePuntaje(jugadorSeleccionado, nroFechaSeleccionado, idTorneoSeleccionado);
        }

        internal IList<Jugador> ConsultarJugadoresSinPuntaje(Dictionary<string, object> parametros)
        {
            return JugadorDao.GetJugadorSinPuntaje(parametros);
        }

        internal IList<Jugador> ObtenerJugadorPorId()
        {
            return JugadorDao.getJugadorById(Selected);
        }

        internal bool insertarPuntajeJugador(List<Jugador> listJugadores, Dictionary<string, object> parametros)
        {
            return JugadorDao.insertPuntajeJugador(listJugadores, parametros);
        }

        internal IList<Jugador> ConsultarJugadoresConPuntaje(Dictionary<string, object> parametros)
        {
            return JugadorDao.GetJugadorConPuntaje(parametros);
        }

        internal IList<Jugador> ObtenerTodosJugadoresConPuntaje(Dictionary<string, object> parametros)
        {
            return JugadorDao.getAllJugadorConPuntaje(parametros);
        }

        internal bool EliminarPuntajeJugador(Jugador jugador, int nroFecha, int idTorneo)
        {
            return JugadorDao.deletePuntajeJugador(jugador, nroFecha, idTorneo);
        }
    }
}
