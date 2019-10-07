using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    class FechaXTorneoDao
    {
        internal bool Create(IList<FechaXTorneo> listaFechaXTorneo)
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
    }
}
