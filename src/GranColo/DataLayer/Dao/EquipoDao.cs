using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    public class EquipoDao
    {
        public IList<Equipo> getAll()
        {
            IList<Equipo> list = new List<Equipo>();
            string sql = "SELECT e.idEquipo, e.nombre, dt.nombre, e.lema, c.nombre " +
                " FROM Equipo e JOIN DirectorTecnico dt ON e.idDirectorTecnico = dt.idDirectorTecnico " +
                " JOIN Color c ON e.color = c.idColor " +
                " WHERE e.estado = 'S' ";

            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }

            return list;
        }

        public bool validarRepeat(Equipo equipo)
        {
            string sql = "SELECT * " +
                " FROM Equipo " +
                " WHERE nombre = @nombre " +
                " AND color = @idColor " +
                " AND estado='S' ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", equipo.Nombre);
            parametros.Add("idColor", equipo.Color.IdColor);

            DataTable rtados = DataManager.GetInstance().ConsultaSQLConParametros(sql, parametros);

            return rtados.Rows.Count > 0;
        }

        public bool modify(Equipo equipo)
        {
            string sql = " UPDATE Equipo " +
                " SET nombre = @nombre, idDirectorTecnico=@id_dt, lema=@lema, color=@color " +
                " WHERE idEquipo = @idEquipo ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", equipo.Nombre);
            parametros.Add("id_dt", equipo.DT.IdDirectorTecnico);
            parametros.Add("lema", equipo.Lema);
            parametros.Add("color", equipo.Color.IdColor);
            parametros.Add("idEquipo", equipo.IdEquipo);

            return DataManager.GetInstance().EjecutarSQL(sql, parametros)==1;

        }

        public bool remove(Equipo equipo)
        {
            string sql = " UPDATE Equipo " +
                " SET estado = 'N' " +
                " WHERE idEquipo = '" + equipo.IdEquipo + "' " ;

            return DataManager.GetInstance().EjecutarSQL(sql)>0;
        }

        public bool insertEquipo(Equipo equipo)
        {
            string sql = "INSERT INTO Equipo (nombre, idDirectorTecnico, lema, color, estado) " +
                " VALUES(@nombre, @idDirectorTecnico, @lema, @color, 'S') ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", equipo.Nombre);
            parametros.Add("idDirectorTecnico", equipo.DT.IdDirectorTecnico);
            parametros.Add("lema", equipo.Lema);
            parametros.Add("color", equipo.Color.IdColor);

            return DataManager.GetInstance().EjecutarSQL(sql, parametros)==1;
         
        }

        public IList<Equipo> getEquiposByFilters(Equipo equipo)
        {
            IList<Equipo> list = new List<Equipo>();

            string sql = "SELECT e.idEquipo, e.nombre, dt.nombre, e.lema, c.nombre " +
                " FROM Equipo e JOIN DirectorTecnico dt ON e.idDirectorTecnico = dt.idDirectorTecnico " +
                " JOIN Color c ON e.color=c.idColor " +
                " WHERE 1=1 ";
            if (!String.IsNullOrEmpty(equipo.IdEquipo.ToString()))
            {
                sql += " AND e.idEquipo =  '" + equipo.IdEquipo + "' "; 
            }
            if (!String.IsNullOrEmpty(equipo.Nombre))
            {
                sql += " AND e.nombre LIKE  '%" + equipo.Nombre + "%' ";
            }
            if (!String.IsNullOrEmpty(equipo.DT.Nombre))
            {
                sql += " AND  dt.nombre = '" + equipo.DT.Nombre + "' ";
            }
            if (!String.IsNullOrEmpty(equipo.Lema))
            {
                sql += " AND  e.lema LIKE '%" + equipo.Lema + "%' ";
            }
            if (!String.IsNullOrEmpty(equipo.Color.Nombre))
            {
                sql += " AND  c.nombre = '" + equipo.Color.Nombre + "' ";
            }
            sql += " AND e.estado='S' ";

            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);

            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        private Equipo ObjectMapping(DataRow row)
        {
            Equipo equipo = new Equipo();
            equipo.Color = new Color();
            equipo.DT = new DirectorTecnico();
            equipo.IdEquipo = Int32.Parse(row[0].ToString());
            equipo.Nombre = row[1].ToString();
            equipo.DT.Nombre = row[2].ToString();
            equipo.Lema = row[3].ToString();
            equipo.Color.Nombre = row[4].ToString();

            return equipo;
        }
    }
}
