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
    }
}
