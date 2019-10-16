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
                                            "           ,nroDoc        ",
                                            "           ,tipoDoc        ",
                                            "           ,costo)      ",
                                            "     VALUES                 ",
                                            "           (@nombre   ",
                                            "           ,@apellido          ",
                                            "           ,@idClub          ",
                                            "           ,@idPosicion          ",
                                            "           ,@idEstadoActual          ",
                                            "           ,@nroDoc          ",
                                            "           ,@tipoDoc          ",
                                            "           ,@costo)       ");

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

        internal bool modifyJugador(Jugador oJugador, int selected)
        {
            throw new NotImplementedException();
        }

        internal bool deleteJugador(int selected)
        {
            throw new NotImplementedException();
        }

        internal IList<Jugador> getAllJugador()
        {
            List<Jugador> list = new List<Jugador>();
            string sql = "SELECT j.idJugador, j.nombre, j.apellido, c.idClub, c.nombre, " +
                    " e.idEstadoActual, e.nombre, j.nroDoc, p.idPosicion, p.nombre, j.costo, t.idTipoDocumento, t.nombre" +
                    " FROM Jugador j JOIN Posicion p ON j.idPosicion = p.idPosicion  " +
                    " JOIN EstadoActual e ON j.idEstadoActual = e.idEstadoActual " +
                    " JOIN Club c ON j.idClub = c.idClub  " +
                    " JOIN TipoDocumento t ON j.tipoDoc = t.idTipoDocumento ";
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
