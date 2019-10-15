using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    class EstadoActualDao
    {
        internal bool InsertEstadoActual(EstadoActual oEstadoActual)
        {
            throw new NotImplementedException();
        }

        internal bool ModifyEstadoActual(EstadoActual oEstadoActual, int selected)
        {
            throw new NotImplementedException();
        }

        internal bool DeleteEstadoActual(int selected)
        {
            throw new NotImplementedException();
        }

        internal IList<EstadoActual> GetAllEstadoActual()
        {
            List<EstadoActual> list = new List<EstadoActual>();
            string sql = " SELECT * FROM EstadoActual ";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        private EstadoActual ObjectMapping(DataRow row)
        {
            EstadoActual EstadoActual = new EstadoActual();
            EstadoActual.IdEstadoActual = Int32.Parse(row[0].ToString());
            EstadoActual.Nombre = row[1].ToString();
            return EstadoActual;
        }
    }
}
