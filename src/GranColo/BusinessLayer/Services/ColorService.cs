using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    public class ColorService
    {
        ColorDao oColorDao;

        public ColorService()
        {
            oColorDao = new ColorDao();
        }

        public IList<Color> obtenerTodos()
        {
            return oColorDao.getAll();
        }
    }
}
