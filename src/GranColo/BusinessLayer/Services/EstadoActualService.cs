using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    class EstadoActualService
    {
        readonly EstadoActualDao EstadoActualDao = new EstadoActualDao();
        public int Selected { get; set; }

        internal bool InsertarEstadoActual(EstadoActual oEstadoActual)
        {
            return EstadoActualDao.InsertEstadoActual(oEstadoActual);
        }

        internal bool ModificarEstadoActual(EstadoActual oEstadoActual)
        {
            return EstadoActualDao.ModifyEstadoActual(oEstadoActual, Selected);
        }

        internal bool EliminarEstadoActual()
        {
            return EstadoActualDao.DeleteEstadoActual(Selected);
        }

        internal IList<EstadoActual> ObtenerTodosEstadosActuales()
        {
            return EstadoActualDao.GetAllEstadoActual();
        }
    }
}
