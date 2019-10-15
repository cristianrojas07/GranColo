using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    class TipoDocumentoDao
    {
        internal bool InsertTipoDocumento(TipoDocumento oTipoDocumento)
        {
            throw new NotImplementedException();
        }

        internal bool ModifyTipoDocumento(TipoDocumento oTipoDocumento, int selected)
        {
            throw new NotImplementedException();
        }

        internal bool DeleteTipoDocumento(int selected)
        {
            throw new NotImplementedException();
        }

        internal IList<TipoDocumento> GetAllTipoDocumento()
        {
            List<TipoDocumento> list = new List<TipoDocumento>();
            string sql = " SELECT * FROM TipoDocumento ";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        private TipoDocumento ObjectMapping(DataRow row)
        {
            TipoDocumento TipoDocumento = new TipoDocumento();
            TipoDocumento.IdTipoDocumento = Int32.Parse(row[0].ToString());
            TipoDocumento.Nombre = row[1].ToString();
            return TipoDocumento;
        }
    }
}
