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

        internal bool Crear(IList<FechaXTorneo> listaFechaXTorneo)
        {
            return FechaXTorneoDao.Create(listaFechaXTorneo);
        }
    }
}
