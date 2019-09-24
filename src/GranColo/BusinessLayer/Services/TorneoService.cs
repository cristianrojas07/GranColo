using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;

namespace GranColo.BusinessLayer.Services
{
    public class TorneoService
    {
        TorneoDao torneoDao = new TorneoDao();
        public int selected { get; set; }
        internal IList<Torneo> obtenerTorneosPorNombre(Torneo oTorneo)
        {
            return torneoDao.getTorneosByNombre(oTorneo);
        }

        internal bool insertarTorneo(Torneo oTorneo)
        {
            return torneoDao.insertTorneo(oTorneo);
        }

        internal bool modificarTorneo(Torneo oTorneo)
        {
            return torneoDao.modifyTorneo(oTorneo, selected);
        }

        internal bool eliminarFecha()
        {
            return torneoDao.deleteTorneo(selected);
        }

        internal IList<Torneo> obtenerTodosTorneos()
        {
            return torneoDao.getAllTorneos();
        }
    }
}
