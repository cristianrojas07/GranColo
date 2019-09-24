using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    public class FechaDao
    {
        public IList<Fecha> getFechasByNombre(Fecha fecha)
        {
            List<Fecha> list = new List<Fecha>();
            string sql = "SELECT * " +
                " FROM Fecha t1 " +
                " WHERE t1.nombre = '" + fecha.nombre + "' " +
                " AND t1.estado = 'S' ";
            DataTable rtados =  DBHelper.getDBHelper().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;

        }

        public bool modifyFecha(Fecha oFecha, int selected)
        {
            string sql = " UPDATE Fecha " +
                " SET nombre = '" + oFecha.nombre + "' " +
                " WHERE nroFecha = '" + selected + "'";

            return (DBHelper.getDBHelper().ejecutarSQL(sql) == 1);
        }

        internal IList<Fecha> getAllFechas()
        {
            List<Fecha> list = new List<Fecha>();
            string sql = " SELECT * FROM Fecha";
            DataTable rtados = DBHelper.getDBHelper().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        public bool deleteFecha(int selected)
        {
            string sql = " UPDATE Fecha " +
                " SET estado = 'N' " + 
                " WHERE nroFecha = '" + selected + "'";
            return (DBHelper.getDBHelper().ejecutarSQL(sql) == 1);
        }

        public bool insertFecha(Fecha oFecha)
        {
            string sql = " INSERT INTO Fecha ( nombre, estado ) " + 
                " VALUES ('" + oFecha.nombre + "', 'S' ) ";

            return (DBHelper.getDBHelper().ejecutarSQL(sql) == 1);

        }

        private Fecha ObjectMapping(DataRow row)
        {
            Fecha fecha = new Fecha();
            fecha.idFecha = Int32.Parse(row[0].ToString());
            fecha.nombre = row[1].ToString();
            fecha.estado = row[2].ToString();

            return fecha;
        }
    }
}
