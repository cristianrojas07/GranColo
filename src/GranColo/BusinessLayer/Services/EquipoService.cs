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
    }
}
