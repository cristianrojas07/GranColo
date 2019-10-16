using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    class FechaXTorneoDao
    {
        public bool Create(IList<FechaXTorneo> listaFechaXTorneo)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                foreach (var itemFechaXTorneo in listaFechaXTorneo)
                {
                    string sql = string.Concat("INSERT INTO FechaXTorneo ",
                                            "           (nroFecha   ",
                                            "           ,idTorneo         ",
                                            "           ,estado)      ",
                                            "     VALUES                 ",
                                            "           (@nroFecha   ",
                                            "           ,@idTorneo          ",
                                            "           ,@estado)       ");


                    var parametros = new Dictionary<string, object>();
                    parametros.Add("nroFecha", itemFechaXTorneo.Fecha.IdFecha);
                    parametros.Add("idTorneo", itemFechaXTorneo.Torneo.IdTorneo);
                    parametros.Add("estado", itemFechaXTorneo.Estado);
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

        public  bool modify(FechaXTorneo fechaXTorneo, int fechaSeleccionada, int torneoSeleccionado)
        {
            string sql = "UPDATE FechaXTorneo " +
                " SET nroFecha=@nroFecha, idTorneo=@idTorneo " +
                " WHERE nroFecha=@nroFechaSeleccionado AND idTorneo=@idTorneoSeleccionado ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idTorneo", fechaXTorneo.Torneo.IdTorneo);
            parametros.Add("nroFecha", fechaXTorneo.Fecha.IdFecha);
            parametros.Add("idTorneoSeleccionado", torneoSeleccionado);
            parametros.Add("nroFechaSeleccionado", fechaSeleccionada);
            return DataManager.GetInstance().EjecutarSQL(sql, parametros) == 1;
        }

        public bool remove(FechaXTorneo fechaXTorneo)
        {
            
            string sql = "DELETE FechaXTorneo " +
                " WHERE nroFecha=@nroFecha AND idTorneo=@idTorneo ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idTorneo", fechaXTorneo.Torneo.IdTorneo);
            parametros.Add("nroFecha", fechaXTorneo.Fecha.IdFecha);
            return DataManager.GetInstance().EjecutarSQL(sql, parametros) == 1;

        }

        public IList<FechaXTorneo> getRegistrosConFiltros(Torneo torneo)
        {
            IList<FechaXTorneo> list = new List<FechaXTorneo>();
            string sql = "SELECT t3.idTorneo, t3.nombre, t2.nroFecha, t2.nombre " +
                    " FROM FechaXTorneo t1 JOIN Fecha t2 ON t1.nroFecha = t2.nroFecha " +
                    " JOIN Torneo t3 ON t1.idTorneo = t3.idTorneo " +
                    " WHERE t1.estado='S' " +
                    " AND  t1.idTorneo= @idTorneo ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idTorneo", torneo.IdTorneo);
            DataTable rtados = DataManager.GetInstance().ConsultaSQLConParametros(sql, parametros);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        public IList<FechaXTorneo> getAll()
        {
            List<FechaXTorneo> list = new List<FechaXTorneo>();
            string sql = "SELECT t3.idTorneo, t3.nombre, t2.nroFecha, t2.nombre " +
                    " FROM FechaXTorneo t1 JOIN Fecha t2 ON t1.nroFecha = t2.nroFecha " +
                    " JOIN Torneo t3 ON t1.idTorneo = t3.idTorneo " +
                    " WHERE t1.estado='S' ";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        

        private FechaXTorneo ObjectMapping(DataRow row)
        {
            FechaXTorneo fechaXtorneo = new FechaXTorneo();
            fechaXtorneo.Torneo = new Torneo();
            fechaXtorneo.Fecha = new Fecha();
            fechaXtorneo.Torneo.IdTorneo = Int32.Parse(row[0].ToString());
            fechaXtorneo.Torneo.Nombre = row[1].ToString();
            fechaXtorneo.Fecha.IdFecha = Int32.Parse(row[2].ToString());
            fechaXtorneo.Fecha.Nombre = row[3].ToString();

            return fechaXtorneo;
        }
    }
}
