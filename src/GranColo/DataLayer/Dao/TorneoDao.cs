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
                " WHERE nombre LIKE '%" + oTorneo.nombre + "%' " +
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
                " SET nombre = '" + oTorneo.nombre + "' " +
                " WHERE idTorneo = '" + selected + "'";
            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);
        }

        internal IList<Torneo> getAllTorneos()
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
                " VALUES ('" + oTorneo.nombre + "', 'S' ) ";

            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);
        }

        public bool getRepeat(Torneo oTorneo)
        {
            string sql = " SELECT * " + 
                         " FROM Torneo " + 
                         " WHERE nombre = '" + oTorneo.nombre + "'";

            return (DataManager.GetInstance().ConsultaSQL(sql).Rows.Count == 1);
        }

        private Torneo ObjectMapping(DataRow row)
        {
            Torneo torneo = new Torneo();
            torneo.idFecha = Int32.Parse(row[0].ToString());
            torneo.nombre = row[1].ToString();
            torneo.estado = row[2].ToString();

            return torneo;
        }
    }
}
