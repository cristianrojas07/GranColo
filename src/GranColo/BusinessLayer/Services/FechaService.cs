using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;

namespace GranColo.BusinessLayer.Services
{
    public class FechaService
    {
        FechaDao fechaDao = new FechaDao();
        public int selected { get; set; }
        public IList<Fecha> obtenerFechasPorNombre(Fecha fecha)
        {
            return fechaDao.getFechasByNombre(fecha);
        }

        public IList<Fecha> obtenerFechasPorId()
        {
            return fechaDao.getFechasById(selected);
        }

        public bool insertarFecha(Fecha oFecha)
        {
            return fechaDao.insertFecha(oFecha);
        }

        public bool modificarFecha(Fecha oFecha)
        {
            return fechaDao.modifyFecha(oFecha, selected);
        }

        public bool eliminarFecha()
        {
            return fechaDao.deleteFecha(selected);
        }

        internal IList<Fecha> obtenerTodasFechas()
        {
            return fechaDao.getAllFechas();
        }

        internal bool obtenerRepetidos(Fecha oFecha)
        {
            return fechaDao.getRepeat(oFecha);
        }
    }
}
