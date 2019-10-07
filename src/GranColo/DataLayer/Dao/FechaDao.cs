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
                " FROM Fecha " +
                " WHERE nombre LIKE '%" + fecha.Nombre + "%' " +
                " AND estado = 'S' ";
            DataTable rtados =  DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;

        }

        public IList<Fecha> getFechasById(int selected)
        {
            List<Fecha> list = new List<Fecha>();
            string sql = "SELECT * " +
                " FROM Fecha " +
                " WHERE nroFecha = '" + selected + "' " ;
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;

        }

        public bool modifyFecha(Fecha oFecha, int selected)
        {
            string sql = " UPDATE Fecha " +
                " SET nombre = '" + oFecha.Nombre + "' " +
                " WHERE nroFecha = '" + selected + "'";

            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);
        }

        internal IList<Fecha> getAllFechas()
        {
            List<Fecha> list = new List<Fecha>();
            string sql = " SELECT * FROM Fecha WHERE estado != 'N'";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
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
            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);
        }

        public bool insertFecha(Fecha oFecha)
        {
            string sql = " INSERT INTO Fecha ( nombre, estado ) " + 
                " VALUES ('" + oFecha.Nombre + "', 'S' ) ";

            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);

        }

        public bool getRepeat(Fecha oFecha)
        {
            string sql = " SELECT * " +
                         " FROM Fecha " +
                         " WHERE nombre = '" + oFecha.Nombre + "' " +
                         " AND estado = 'S' ";

            return (DataManager.GetInstance().ConsultaSQL(sql).Rows.Count == 1);
        }

        private Fecha ObjectMapping(DataRow row)
        {
            Fecha fecha = new Fecha();
            fecha.IdFecha = Int32.Parse(row[0].ToString());
            fecha.Nombre = row[1].ToString();
            fecha.Estado = row[2].ToString();

            return fecha;
        }
    }
}
