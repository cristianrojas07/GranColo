using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    class FechaXTorneoService
    {
        FechaXTorneoDao FechaXTorneoDao = new FechaXTorneoDao();

        public bool Crear(IList<FechaXTorneo> listaFechaXTorneo)
        {
            return FechaXTorneoDao.Create(listaFechaXTorneo);
        }

        public IList<FechaXTorneo> obtenerTodos()
        {
            return FechaXTorneoDao.getAll();
        }

        public IList<FechaXTorneo> obtenerRegistrosConFiltros(Torneo torneo)
        {
            return FechaXTorneoDao.getRegistrosConFiltros(torneo);
        }

        public bool eliminar(FechaXTorneo fechaXTorneo)
        {
           return FechaXTorneoDao.remove(fechaXTorneo);
        }

        public bool modificar(FechaXTorneo fechaXTorneo, int fechaSeleccionada, int torneoSeleccionado)
        {
            return FechaXTorneoDao.modify(fechaXTorneo, fechaSeleccionada, torneoSeleccionado);
        }
    }
}
