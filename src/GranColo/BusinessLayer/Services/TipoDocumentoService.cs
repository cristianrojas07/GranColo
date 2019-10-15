using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    class TipoDocumentoService
    {
        readonly TipoDocumentoDao TipoDocumentoDao = new TipoDocumentoDao();
        public int Selected { get; set; }

        internal bool InsertarTipoDocumento(TipoDocumento oTipoDocumento)
        {
            return TipoDocumentoDao.InsertTipoDocumento(oTipoDocumento);
        }

        internal bool ModificarTipoDocumento(TipoDocumento oTipoDocumento)
        {
            return TipoDocumentoDao.ModifyTipoDocumento(oTipoDocumento, Selected);
        }

        internal bool EliminarTipoDocumento()
        {
            return TipoDocumentoDao.DeleteTipoDocumento(Selected);
        }

        internal IList<TipoDocumento> ObtenerTodosTipoDocumentos()
        {
            return TipoDocumentoDao.GetAllTipoDocumento();
        }
    }
}
