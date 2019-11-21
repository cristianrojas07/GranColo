using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    public class EquipoService
    {
        EquipoDao oEquipoDao;
        public EquipoService()
        {
            oEquipoDao = new EquipoDao();
        }

        public IList<Equipo> obtenerTodos()
        {
            return oEquipoDao.getAll();
        }

        public IList<Equipo> obtenerEquiposConFiltros(Equipo equipo)
        {
            return oEquipoDao.getEquiposByFilters(equipo);
        }

        public bool insertarEquipo(Equipo equipo)
        {
            return oEquipoDao.insertEquipo(equipo);
        }

        public bool validarRepetido(Equipo equipo)
        {
            return oEquipoDao.validarRepeat(equipo);
        }

        public bool eliminar(Equipo equipo)
        {
            return oEquipoDao.remove(equipo);
        }

        public bool modificarEquipo(Equipo equipo)
        {
            return oEquipoDao.modify(equipo);
        }

        internal bool registrarJugadores(Equipo equipo)
        {
            return oEquipoDao.saveJugador(equipo);
        }

        public IList<Equipo> obtenerTodosEquiposXJugadores()
        {
            return oEquipoDao.getAllEquiposXJugadores();
        }


        public IList<Equipo> obtenerEquiposXJugadores(int idEquipo)
        {
            return oEquipoDao.getEquiposXJugadores(idEquipo);
        }

        public bool modificarEquipoXJugador(int equipo, int jugadorNuevo, int jugadorViejo)
        {
            return oEquipoDao.modifyEquipoXJugador(equipo, jugadorNuevo, jugadorViejo);
        }

        public bool eliminarEquipoXJugador(int idEquipo, int idJugador)
        {
            return oEquipoDao.removeEquipoXJugador(idEquipo, idJugador);
        }
    }
}
