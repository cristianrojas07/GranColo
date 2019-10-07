using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    public class TorneoDao
    {
        public IList<Torneo> getTorneosByNombre(Torneo oTorneo)
        {
            List<Torneo> list = new List<Torneo>();
            string sql = "SELECT * " +
                " FROM Torneo " + 
                " WHERE nombre LIKE '%" + oTorneo.Nombre + "%' " +
                " AND estado = 'S' ";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach(DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        public bool modifyTorneo(Torneo oTorneo, int selected)
        {
            string sql = " UPDATE Torneo " +
                " SET nombre = '" + oTorneo.Nombre + "' " +
                " WHERE idTorneo = '" + selected + "'";
            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);
        }

        public IList<Torneo> getAllTorneos()
        {
            List<Torneo> list = new List<Torneo>();
            string sql = " SELECT * FROM Torneo WHERE estado != 'N'";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        public IList<Torneo> getTorneosById(int selected)
        {
            List<Torneo> list = new List<Torneo>();
            string sql = "SELECT * " +
                " FROM Torneo " +
                " WHERE idTorneo = '" + selected + "' ";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        public bool deleteTorneo(int selected)
        {
            string sql = " UPDATE Torneo " +
                " SET estado = 'N' " +
                " WHERE idTorneo = '" + selected + "'";
            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);
        }

        public bool insertTorneo(Torneo oTorneo)
        {
            string sql = " INSERT INTO Torneo ( nombre, estado ) " +
                " VALUES ('" + oTorneo.Nombre + "', 'S' ) ";

            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);
        }

        public bool getRepeat(Torneo oTorneo)
        {
            string sql = " SELECT * " + 
                         " FROM Torneo " + 
                         " WHERE nombre = '" + oTorneo.Nombre + "' " +
                         " AND estado = 'S' ";

            return (DataManager.GetInstance().ConsultaSQL(sql).Rows.Count == 1);
        }

        private Torneo ObjectMapping(DataRow row)
        {
            Torneo torneo = new Torneo();
            torneo.IdTorneo = Int32.Parse(row[0].ToString());
            torneo.Nombre = row[1].ToString();
            torneo.Estado = row[2].ToString();

            return torneo;
        }
    }
}
