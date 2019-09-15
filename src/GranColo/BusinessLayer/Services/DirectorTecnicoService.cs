using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    class DirectorTecnicoService
    {
        DirectorTecnicoDao oDTDao;

        public DirectorTecnicoService()
        {
            oDTDao = new DirectorTecnicoDao();
        }

        internal bool validarDirectorTecnico(DirectorTecnico oDT)
        {
            return oDTDao.validarDirectorTecnico(oDT);
        }
    }
}
