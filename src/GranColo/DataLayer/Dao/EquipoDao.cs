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

        public IList<Equipo> getAllEquiposXJugadores()
        {
            IList<Equipo> list = new List<Equipo>();
            string sql = "SELECT e.idEquipo, e.nombre, j.idJugador, j.nombre, j.apellido " +
                " FROM EquipoXJugador exj JOIN Equipo e ON exj.idEquipo = e.idEquipo " +
                " JOIN Jugador j ON exj.idJugador = j.idJugador" +
                " WHERE exj.estado='S' ";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                Equipo equipo = new Equipo();
                Jugador jugador = new Jugador();
                equipo.IdEquipo = Int32.Parse(row[0].ToString());
                equipo.Nombre = row[1].ToString();
                jugador.IdJugador = Int32.Parse(row[2].ToString());
                jugador.Nombre = row[3].ToString();
                jugador.Apellido = row[4].ToString();
                equipo.AgregarJugador(jugador);
                list.Add(equipo);
            }
            

            return list;
        }

        public bool removeEquipoXJugador(int idEquipo, int idJugador)
        {
            string sql = "DELETE EquipoXJugador " +
                " WHERE idEquipo=@idEquipo AND idJugador=@idJugador";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idJugador", idJugador);
            parametros.Add("idEquipo", idEquipo);
            return DataManager.GetInstance().EjecutarSQL(sql, parametros) == 1;
        }

        public bool modifyEquipoXJugador(int equipo, int jugadorNuevo, int jugadorViejo)
        {
            string sql = "UPDATE EquipoXJugador " +
                " SET idJugador=@idJugadorNuevo " +
                " WHERE idEquipo=@idEquipo AND idJugador=@idJugadorViejo";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idJugadorNuevo", jugadorNuevo);
            parametros.Add("idJugadorViejo", jugadorViejo);
            parametros.Add("idEquipo", equipo);
            return DataManager.GetInstance().EjecutarSQL(sql, parametros) == 1;
        }

        public IList<Equipo> getEquiposXJugadores(int idEquipo)
        {
            IList<Equipo> list = new List<Equipo>();
            string sql = "SELECT e.idEquipo, e.nombre, j.idJugador, j.nombre, j.apellido " +
                " FROM EquipoXJugador exj JOIN Equipo e ON exj.idEquipo = e.idEquipo " +
                " JOIN Jugador j ON exj.idJugador = j.idJugador " +
                " WHERE exj.estado='S' AND e.idEquipo=@idEquipo ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idEquipo", idEquipo);
            DataTable rtados = DataManager.GetInstance().ConsultaSQLConParametros(sql, parametros);
            foreach (DataRow row in rtados.Rows)
            {
                Equipo equipo = new Equipo();
                Jugador jugador = new Jugador();
                equipo.IdEquipo = Int32.Parse(row[0].ToString());
                equipo.Nombre = row[1].ToString();
                jugador.IdJugador = Int32.Parse(row[2].ToString());
                jugador.Nombre = row[3].ToString();
                jugador.Apellido = row[4].ToString();
                equipo.AgregarJugador(jugador);
                list.Add(equipo);
            }


            return list;
        }

        internal bool saveJugador(Equipo equipo)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                
                foreach (var jugador in equipo.GetJugadores())
                {
                    string sql = string.Concat("  INSERT INTO EquipoXJugador (idEquipo, idJugador, estado)   ",
                                            " VALUES (@id_equipo, @id_jugador, 'S')  ");



                    var parametros = new Dictionary<string, object>();
                    parametros.Add("id_equipo", equipo.IdEquipo);
                    parametros.Add("id_jugador", jugador.IdJugador);

                    dm.EjecutarSQL(sql, parametros);
                }
                dm.Commit();

            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
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
