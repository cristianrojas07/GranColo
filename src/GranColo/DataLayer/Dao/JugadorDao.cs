using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    class JugadorDao
    {
        internal bool insertJugador(Jugador oJugador)
        {
            string sql = string.Concat("INSERT INTO Jugador ",
                                            "           (nombre   ",
                                            "           ,apellido        ",
                                            "           ,idClub        ",
                                            "           ,idPosicion        ",
                                            "           ,idEstadoActual        ",
                                            "           ,estado                 ",
                                            "           ,nroDoc        ",
                                            "           ,tipoDoc        ",
                                            "           ,costo)      ",
                                            "     VALUES                 ",
                                            "           (@nombre   ",
                                            "           ,@apellido          ",
                                            "           ,@idClub          ",
                                            "           ,@idPosicion          ",
                                            "           ,@idEstadoActual          ",
                                            "           ,@estado                ",
                                            "           ,@nroDoc          ",
                                            "           ,@tipoDoc          ",
                                            "           ,@costo)       ");

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", oJugador.Nombre);
            parametros.Add("apellido", oJugador.Apellido);
            parametros.Add("idClub", oJugador.Club.IdClub);
            parametros.Add("idPosicion", oJugador.Posicion.IdPosicion);
            parametros.Add("idEstadoActual", oJugador.EstadoActual.IdEstadoActual);
            parametros.Add("estado", "S");
            parametros.Add("nroDoc", oJugador.NroDocumento);
            parametros.Add("tipoDoc", oJugador.TipoDocumento.IdTipoDocumento);
            parametros.Add("costo", oJugador.Costo);

            return (DataManager.GetInstance().EjecutarSQL(sql, parametros) == 1);
        }

        internal IList<Jugador> GetAllJugadorSinEquipo(string idEquipo)
        {
            List<Jugador> list = new List<Jugador>();
            string sql = "SELECT j.idJugador, j.nombre, j.apellido, c.idClub, c.nombre, " +
                    " e.idEstadoActual, e.nombre, j.nroDoc, p.idPosicion, p.nombre, j.costo, t.idTipoDocumento, t.nombre" +
                    " FROM Jugador j JOIN Posicion p ON j.idPosicion = p.idPosicion  " +
                    " JOIN EstadoActual e ON j.idEstadoActual = e.idEstadoActual " +
                    " JOIN Club c ON j.idClub = c.idClub  " +
                    " JOIN TipoDocumento t ON j.tipoDoc = t.idTipoDocumento " +
                    " WHERE j.estado='S' AND (j.idJugador NOT IN (SELECT exj.idJugador FROM EquipoXJugador exj WHERE exj.idEquipo = '"+idEquipo+"'))";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        internal IList<Jugador> GetJugadorSinEquipo(Dictionary<string, object> parametros)
        {
            List<Jugador> listadoJugadores = new List<Jugador>();

            var strSql = "SELECT j.idJugador, j.nombre, j.apellido, c.idClub, c.nombre, " +
                    " e.idEstadoActual, e.nombre, j.nroDoc, p.idPosicion, p.nombre, j.costo, t.idTipoDocumento, t.nombre" +
                    " FROM Jugador j JOIN Posicion p ON j.idPosicion = p.idPosicion  " +
                    " JOIN EstadoActual e ON j.idEstadoActual = e.idEstadoActual " +
                    " JOIN Club c ON j.idClub = c.idClub  " +
                    " JOIN TipoDocumento t ON j.tipoDoc = t.idTipoDocumento " +
                    " WHERE j.estado='S' AND 1=1";

            if (parametros.ContainsKey("costoDesde") && parametros.ContainsKey("costoHasta"))
                strSql += " AND (j.costo>=@costoDesde AND j.costo<=@costoHasta) ";
            if (parametros.ContainsKey("nombre"))
                strSql += " AND (j.nombre LIKE @nombre) ";
            if (parametros.ContainsKey("apellido"))
                strSql += " AND (j.apellido LIKE @apellido) ";
            if (parametros.ContainsKey("idPosicion"))
                strSql += " AND (p.idPosicion=@idPosicion) ";
            if (parametros.ContainsKey("idClub"))
                strSql += " AND (c.idClub=@idClub)  ";
            if (parametros.ContainsKey("idEquipo"))
                strSql += " AND (j.idJugador NOT IN (SELECT exj.idJugador FROM EquipoXJugador exj WHERE exj.idEquipo = @idEquipo))";

            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQLConParametros(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoJugadores.Add(ObjectMapping(row));
            }

            return listadoJugadores;
        }

        internal bool updatePuntaje(Jugador jugadorSeleccionado, int nroFechaSeleccionado, int idTorneoSeleccionado)
        {
            string sql = string.Concat("UPDATE JugadorXFechaXTorneo ",
                                       "SET puntaje=@puntaje ",
                                       "WHERE idJugador=@idJugador ",
                                       "AND nroFecha=@nroFecha ",
                                       "AND idTorneo=@idTorneo");

            var parametros = new Dictionary<string, object>();
            parametros.Add("puntaje", jugadorSeleccionado.Puntaje);
            parametros.Add("idJugador", jugadorSeleccionado.IdJugador);
            parametros.Add("nroFecha", nroFechaSeleccionado);
            parametros.Add("idTorneo", idTorneoSeleccionado);

            return (DataManager.GetInstance().EjecutarSQL(sql, parametros) == 1);
        }

        internal bool deletePuntajeJugador(Jugador jugador, int nroFecha, int idTorneo)
        {
            string sql = " DELETE FROM JugadorXFechaXTorneo " +
                " WHERE idJugador=@idJugador AND nroFecha=@nroFecha AND idTorneo=@idTorneo";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idJugador", jugador.IdJugador);
            parametros.Add("nroFecha", nroFecha);
            parametros.Add("idTorneo", idTorneo);
            return (DataManager.GetInstance().EjecutarSQL(sql, parametros) == 1);
        }

        internal IList<Jugador> GetJugadorConPuntaje(Dictionary<string, object> parametros)
        {
            List<Jugador> listadoJugadores = new List<Jugador>();
            
            var strSql = String.Concat("SELECT j.idJugador, j.nombre, j.apellido, c.idClub, c.nombre, p.idPosicion, p.nombre, j.costo, jxf.puntaje  ",
                "FROM JugadorXFechaXTorneo jxf JOIN Jugador j ON jxf.idJugador = j.idJugador ",
                "JOIN Posicion p ON j.idPosicion = p.idPosicion ",
                "JOIN Club c ON j.idClub = c.idClub ",
                "WHERE j.estado = 'S' AND (jxf.nroFecha=@nroFecha) AND (jxf.idTorneo=@idTorneo) AND 1=1 ");
            if (parametros.ContainsKey("costoDesde") && parametros.ContainsKey("costoHasta"))
                strSql += " AND (j.costo>=@costoDesde AND j.costo<=@costoHasta) ";
            if (parametros.ContainsKey("nombre"))
                strSql += " AND (j.nombre LIKE @nombre) ";
            if (parametros.ContainsKey("apellido"))
                strSql += " AND (j.apellido LIKE @apellido) ";
            if (parametros.ContainsKey("idPosicion"))
                strSql += " AND (p.idPosicion=@idPosicion) ";
            if (parametros.ContainsKey("idClub"))
                strSql += " AND (c.idClub=@idClub)  ";
            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQLConParametros(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                Jugador jugador = new Jugador();
                Club club = new Club();
                Posicion posicion = new Posicion();
                jugador.IdJugador = Int32.Parse(row[0].ToString());
                jugador.Nombre = row[1].ToString();
                jugador.Apellido = row[2].ToString();
                club.IdClub = Int32.Parse(row[3].ToString());
                club.Nombre = row[4].ToString();
                jugador.Club = club;
                posicion.IdPosicion = Int32.Parse(row[5].ToString());
                posicion.Nombre = row[6].ToString();
                jugador.Posicion = posicion;
                jugador.Costo = Int32.Parse(row[7].ToString());
                jugador.Puntaje = Int32.Parse(row[8].ToString());
                listadoJugadores.Add(jugador);
            }

            return listadoJugadores;
        }

        internal IList<Jugador> getAllJugadorConPuntaje(Dictionary<string, object> parametros)
        {
            List<Jugador> listadoJugadores = new List<Jugador>();

            var strSql = String.Concat("SELECT j.idJugador, j.nombre, j.apellido, c.idClub, c.nombre, p.idPosicion, p.nombre, j.costo, jxf.puntaje  ",
                "FROM JugadorXFechaXTorneo jxf JOIN Jugador j ON jxf.idJugador = j.idJugador ",
                "JOIN Posicion p ON j.idPosicion = p.idPosicion ",
                "JOIN Club c ON j.idClub = c.idClub ",
                "WHERE j.estado = 'S' AND (jxf.nroFecha=@nroFecha) AND (jxf.idTorneo=@idTorneo) AND 1=1 ");
            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQLConParametros(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                Jugador jugador = new Jugador();
                Club club = new Club();
                Posicion posicion = new Posicion();
                jugador.IdJugador = Int32.Parse(row[0].ToString());
                jugador.Nombre = row[1].ToString();
                jugador.Apellido = row[2].ToString();
                club.IdClub = Int32.Parse(row[3].ToString());
                club.Nombre = row[4].ToString();
                jugador.Club = club;
                posicion.IdPosicion = Int32.Parse(row[5].ToString());
                posicion.Nombre = row[6].ToString();
                jugador.Posicion = posicion;
                jugador.Costo = Int32.Parse(row[7].ToString());
                jugador.Puntaje = Int32.Parse(row[8].ToString());
                listadoJugadores.Add(jugador);
            }

            return listadoJugadores;
        }

        internal IList<Jugador> getAllJugadorSinPuntaje(Dictionary<string, object> parametros)
        {
            List<Jugador> list = new List<Jugador>();
            var sql = String.Concat("SELECT j1.idJugador, j1.nombre, j1.apellido, c1.idClub, c1.nombre, p.idPosicion, p.nombre, j1.costo ",
                "FROM Jugador j1 JOIN Club c1 ON j1.idClub = c1.idClub ",
                "JOIN Posicion p ON p.idPosicion = j1.idPosicion ",
                "WHERE j1.idJugador NOT IN(SELECT j.idJugador ",
                "FROM Jugador j JOIN Club c ON j.idClub = c.idClub ",
                "JOIN JugadorXFechaXTorneo jxt ON j.idJugador = jxt.idJugador ",
                "JOIN Fecha f ON f.nroFecha = jxt.nroFecha ",
                "JOIN Torneo t ON t.idTorneo = jxt.idTorneo ",
                "WHERE j.estado = 'S' AND (f.nroFecha=@nroFecha) AND (t.idTorneo=@idTorneo))");
            var rtados = (DataRowCollection)DataManager.GetInstance().ConsultaSQLConParametros(sql, parametros).Rows;
            foreach (DataRow row in rtados)
            {
                Jugador jugador = new Jugador();
                Club club = new Club();
                Posicion posicion = new Posicion();
                jugador.IdJugador = Int32.Parse(row[0].ToString());
                jugador.Nombre = row[1].ToString();
                jugador.Apellido = row[2].ToString();
                club.IdClub = Int32.Parse(row[3].ToString());
                club.Nombre = row[4].ToString();
                jugador.Club = club;
                posicion.IdPosicion = Int32.Parse(row[5].ToString());
                posicion.Nombre = row[6].ToString();
                jugador.Posicion = posicion;
                jugador.Costo = Int32.Parse(row[7].ToString());
                list.Add(jugador);
            }
            return list;
        }

        internal IList<Jugador> GetJugadorSinPuntaje(Dictionary<string, object> parametros)
        {
            List<Jugador> listadoJugadores = new List<Jugador>();

            var strSql = String.Concat("SELECT j1.idJugador, j1.nombre, j1.apellido, c1.idClub, c1.nombre, p.idPosicion, p.nombre, j1.costo ",
                "FROM Jugador j1 JOIN Club c1 ON j1.idClub = c1.idClub ",
                "JOIN Posicion p ON p.idPosicion = j1.idPosicion ",
                "WHERE j1.idJugador NOT IN(SELECT j.idJugador ",
                "FROM Jugador j JOIN Club c ON j.idClub = c.idClub ",
                "JOIN JugadorXFechaXTorneo jxt ON j.idJugador = jxt.idJugador ",
                "JOIN Fecha f ON f.nroFecha = jxt.nroFecha ",
                "JOIN Torneo t ON t.idTorneo = jxt.idTorneo ",
                "WHERE j.estado = 'S' AND (f.nroFecha=@nroFecha) AND (t.idTorneo=@idTorneo)) AND 1=1 ");
            if (parametros.ContainsKey("costoDesde") && parametros.ContainsKey("costoHasta"))
                strSql += " AND (j1.costo>=@costoDesde AND j1.costo<=@costoHasta) ";
            if (parametros.ContainsKey("nombre"))
                strSql += " AND (j1.nombre LIKE @nombre) ";
            if (parametros.ContainsKey("apellido"))
                strSql += " AND (j1.apellido LIKE @apellido) ";
            if (parametros.ContainsKey("idPosicion"))
                strSql += " AND (p.idPosicion=@idPosicion) ";
            if (parametros.ContainsKey("idClub"))
                strSql += " AND (c1.idClub=@idClub)  ";
            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQLConParametros(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                Jugador jugador = new Jugador();
                Club club = new Club();
                Posicion posicion = new Posicion();
                jugador.IdJugador = Int32.Parse(row[0].ToString());
                jugador.Nombre = row[1].ToString();
                jugador.Apellido = row[2].ToString();
                club.IdClub = Int32.Parse(row[3].ToString());
                club.Nombre = row[4].ToString();
                jugador.Club = club;
                posicion.IdPosicion = Int32.Parse(row[5].ToString());
                posicion.Nombre = row[6].ToString();
                jugador.Posicion = posicion;
                jugador.Costo = Int32.Parse(row[7].ToString());
                listadoJugadores.Add(jugador);
            }

            return listadoJugadores;
        }

        internal bool insertPuntajeJugador(List<Jugador> listJugadores, int idFecha, int idTorneo)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                foreach (var itemJugador in listJugadores)
                {
                    string sql = string.Concat("INSERT INTO JugadorXFechaXTorneo ",
                                            "           (idJugador  ",
                                            "           ,nroFecha   ",
                                            "           ,idTorneo         ",
                                            "           ,puntaje)      ",
                                            "     VALUES                 ",
                                            "           (@idJugador   ",
                                            "           ,@nroFecha   ",
                                            "           ,@idTorneo          ",
                                            "           ,@puntaje)       ");

                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("nroFecha", idFecha);
                    parametros.Add("idTorneo", idTorneo);
                    parametros.Add("idJugador", itemJugador.IdJugador);
                    parametros.Add("puntaje", itemJugador.Puntaje);
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

        internal IList<Jugador> getJugadorById(int selected)
        {
            List<Jugador> list = new List<Jugador>();
            string sql = "SELECT j.idJugador, j.nombre, j.apellido, c.idClub, c.nombre, " +
                    " e.idEstadoActual, e.nombre, j.nroDoc, p.idPosicion, p.nombre, j.costo, t.idTipoDocumento, t.nombre" +
                    " FROM Jugador j JOIN Posicion p ON j.idPosicion = p.idPosicion  " +
                    " JOIN EstadoActual e ON j.idEstadoActual = e.idEstadoActual " +
                    " JOIN Club c ON j.idClub = c.idClub  " +
                    " JOIN TipoDocumento t ON j.tipoDoc = t.idTipoDocumento " +
                    " WHERE j.idJugador="+ selected + "";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        internal IList<Jugador> GetJugadorByFilters(Dictionary<string, object> parametros)
        {
            List<Jugador> listadoJugadores = new List<Jugador>();

            var strSql = "SELECT j.idJugador, j.nombre, j.apellido, c.idClub, c.nombre, " +
                    " e.idEstadoActual, e.nombre, j.nroDoc, p.idPosicion, p.nombre, j.costo, t.idTipoDocumento, t.nombre" +
                    " FROM Jugador j JOIN Posicion p ON j.idPosicion = p.idPosicion  " +
                    " JOIN EstadoActual e ON j.idEstadoActual = e.idEstadoActual " +
                    " JOIN Club c ON j.idClub = c.idClub  " +
                    " JOIN TipoDocumento t ON j.tipoDoc = t.idTipoDocumento " +
                    " WHERE j.estado='S' AND 1=1";

            if (parametros.ContainsKey("costoDesde") && parametros.ContainsKey("costoHasta"))
                strSql += " AND (j.costo>=@costoDesde AND j.costo<=@costoHasta) ";
            if (parametros.ContainsKey("nombre"))
                strSql += " AND (j.nombre LIKE @nombre) ";
            if (parametros.ContainsKey("apellido"))
                strSql += " AND (j.apellido LIKE @apellido) ";
            if (parametros.ContainsKey("idPosicion"))
                strSql += " AND (p.idPosicion=@idPosicion) ";
            if (parametros.ContainsKey("idClub"))
                strSql += " AND (c.idClub=@idClub)  ";

            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQLConParametros(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoJugadores.Add(ObjectMapping(row));
            }

            return listadoJugadores;
        }

        internal bool modifyJugador(Jugador oJugador, int selected)
        {
            string sql = string.Concat("UPDATE Jugador ",
                                       "SET nombre=@nombre, apellido=@apellido, ",
                                       "idClub=@idClub, idPosicion=@idPosicion, ",
                                       "idEstadoActual=@idEstadoActual, nroDoc=@nroDoc, ",
                                       "tipoDoc=@tipoDoc, costo=@costo ",
                                       "WHERE idJugador=" + selected + "");

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", oJugador.Nombre);
            parametros.Add("apellido", oJugador.Apellido);
            parametros.Add("idClub", oJugador.Club.IdClub);
            parametros.Add("idPosicion", oJugador.Posicion.IdPosicion);
            parametros.Add("idEstadoActual", oJugador.EstadoActual.IdEstadoActual);
            parametros.Add("nroDoc", oJugador.NroDocumento);
            parametros.Add("tipoDoc", oJugador.TipoDocumento.IdTipoDocumento);
            parametros.Add("costo", oJugador.Costo);

            return (DataManager.GetInstance().EjecutarSQL(sql, parametros) == 1);
        }

        internal bool deleteJugador(int selected)
        {
            string sql = " UPDATE Jugador " +
                " SET estado = 'N' " +
                " WHERE idJugador = " + selected + "";
            return (DataManager.GetInstance().EjecutarSQL(sql) == 1);
        }

        internal IList<Jugador> getAllJugador()
        {
            List<Jugador> list = new List<Jugador>();
            string sql = "SELECT j.idJugador, j.nombre, j.apellido, c.idClub, c.nombre, " +
                    " e.idEstadoActual, e.nombre, j.nroDoc, p.idPosicion, p.nombre, j.costo, t.idTipoDocumento, t.nombre" +
                    " FROM Jugador j JOIN Posicion p ON j.idPosicion = p.idPosicion  " +
                    " JOIN EstadoActual e ON j.idEstadoActual = e.idEstadoActual " +
                    " JOIN Club c ON j.idClub = c.idClub  " +
                    " JOIN TipoDocumento t ON j.tipoDoc = t.idTipoDocumento " +
                    " WHERE j.estado='S' ";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        internal bool getRepeat(Jugador oJugador)
        {
            string sql = " SELECT * " +
                         " FROM Jugador " +
                         " WHERE nroDoc = " + oJugador.NroDocumento + "";

            return (DataManager.GetInstance().ConsultaSQL(sql).Rows.Count == 1);
        }

        private Jugador ObjectMapping(DataRow row)
        {
            Jugador Jugador = new Jugador();
            Jugador.Club = new Club();
            Jugador.Posicion = new Posicion();
            Jugador.EstadoActual = new EstadoActual();
            Jugador.TipoDocumento = new TipoDocumento();
            Jugador.IdJugador = Int32.Parse(row[0].ToString());
            Jugador.Nombre = row[1].ToString();
            Jugador.Apellido = row[2].ToString();
            Jugador.Club.IdClub = Int32.Parse(row[3].ToString());
            Jugador.Club.Nombre = row[4].ToString();
            Jugador.EstadoActual.IdEstadoActual = Int32.Parse(row[5].ToString());
            Jugador.EstadoActual.Nombre = row[6].ToString();
            Jugador.NroDocumento = Int32.Parse(row[7].ToString());
            Jugador.Posicion.IdPosicion = Int32.Parse(row[8].ToString());
            Jugador.Posicion.Nombre = row[9].ToString();
            Jugador.Costo = Int32.Parse(row[10].ToString());
            Jugador.TipoDocumento.IdTipoDocumento = Int32.Parse(row[11].ToString());
            Jugador.TipoDocumento.Nombre = row[12].ToString();
            return Jugador;
        }
    }
}
