using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    class PosicionService
    {
        readonly PosicionDao PosicionDao = new PosicionDao();
        public int Selected { get; set; }

        internal bool InsertarPosicion(Posicion oPosicion)
        {
            return PosicionDao.InsertPosicion(oPosicion);
        }

        internal bool ModificarPosicion(Posicion oPosicion)
        {
            return PosicionDao.ModifyPosicion(oPosicion, Selected);
        }

        internal bool EliminarPosicion()
        {
            return PosicionDao.DeletePosicion(Selected);
        }

        internal IList<Posicion> ObtenerTodosPosiciones()
        {
            return PosicionDao.GetAllPosicion();
        }
    }
}
