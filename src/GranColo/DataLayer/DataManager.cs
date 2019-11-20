using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public class DataManager
{
    private SqlConnection dbConnection;
    private SqlTransaction dbTransaction;

    private static DataManager instance = new DataManager();
    public DataManager()
    {
        dbConnection = new SqlConnection();
        var dataBaseName = ConfigurationManager.AppSettings["dataBaseName"];
        var string_conexion = ConfigurationManager.ConnectionStrings[dataBaseName].ConnectionString;
        dbConnection.ConnectionString = string_conexion;
    }

    public void BeginTransaction()
    {
        if (dbConnection.State == ConnectionState.Open)
            dbTransaction =  dbConnection.BeginTransaction();
    }

    public static DataManager GetInstance()
    {
        if (instance == null)
            instance = new DataManager();
            instance.Open();
        return instance;
    }

    public void Commit()
    {
        if (dbTransaction != null)
            dbTransaction.Commit();
    }

    public void Rollback()
    {
        if (dbTransaction != null)
            dbTransaction.Rollback();
    }
    public void Open()
    {
        if (dbConnection.State != ConnectionState.Open)
            dbConnection.Open();
    }

    

    public void Close()
    {
        if (dbConnection.State != ConnectionState.Closed)
            dbConnection.Close();
    }


    /// Resumen:
    ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
    /// Devuelve:
    ///      un objeto de tipo DataTable con el resultado de la consulta
    /// Excepciones:
    ///      System.Data.SqlClient.SqlException:
    ///          El error de conexión se produce:
    ///              a) durante la apertura de la conexión
    ///              b) durante la ejecución del comando.
    public DataTable ConsultaSQL(string strSql)
    {
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            cmd.Connection = dbConnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            return tabla;
        }
        catch (SqlException ex)
        {
            throw (ex);
        }
    }

    /// Resumen:
    ///      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
    ///      La función recibe por valor una sentencia sql como string y un diccionario de objetos como parámetros
    /// Devuelve:
    ///      un objeto de tipo DataTable con el resultado de la consulta
    /// Excepciones:
    ///      System.Data.SqlClient.SqlException:
    ///          El error de conexión se produce:
    ///              a) durante la apertura de la conexión
    ///              b) durante la ejecución del comando.
    public DataTable ConsultaSQLConParametros(string strSql, Dictionary<string, object> prs)
    {
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            cmd.Connection = dbConnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            
            //Agregamos a la colección de parámetros del comando los filtros recibidos
            foreach (var item in prs)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }

            tabla.Load(cmd.ExecuteReader());
            return tabla;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
    }

    /// Resumen:
    ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
    /// Devuelve:
    ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
    /// Excepciones:
    ///      System.Data.SqlClient.SqlException:
    ///          El error de conexión se produce:
    ///              a) durante la apertura de la conexión
    ///              b) durante la ejecución del comando.
    public int EjecutarSQL(string strSql, Dictionary<string, object> parametros = null)
    {
        // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        
        SqlCommand cmd = new SqlCommand();
        
        int rtdo = 0;

        // Try Catch Finally
        // Trata de ejecutar el código contenido dentro del bloque Try - Catch
        // Si hay error lo capta a través de una excepción
        // Si no hubo error
        try
        {
            cmd.Connection = dbConnection;
            cmd.Transaction = dbTransaction;
            cmd.CommandType = CommandType.Text;
            // Establece la instrucción a ejecutar
            cmd.CommandText = strSql;

            //Agregamos a la colección de parámetros del comando los filtros recibidos
            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

            // Retorna el resultado de ejecutar el comando
            rtdo = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return rtdo;
    }

    /// Resumen:
    ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
    /// Devuelve:
    ///      un valor entero
    /// Excepciones:
    ///      System.Data.SqlClient.SqlException:
    ///          El error de conexión se produce:
    ///              a) durante la apertura de la conexión
    ///              b) durante la ejecución del comando.
    public object ConsultaSQLScalar(string strSql)
    {
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.Connection = dbConnection;
            cmd.Transaction = dbTransaction;
            cmd.CommandType = CommandType.Text;
            // Establece la instrucción a ejecutar
            cmd.CommandText = strSql;
            return cmd.ExecuteScalar();
        }
        catch (SqlException ex)
        {
            throw (ex);
        }
    }

    public DataTable GenerarReporte(int idTorneo)
    {
        string strSql = "SELECT (j.nombre + ' ' + j.apellido) as jugador, t.nombre as torneo, Sum(puntaje) as puntaje, c.nombre as club" +
                        " FROM JugadorXFechaXTorneo jxf JOIN Jugador j ON jxf.idJugador = j.idJugador " +
                        " JOIN Torneo t ON jxf.idTorneo = t.idTorneo " +
                        " JOIN Club c ON c.idClub = j.idClub " +
                        " WHERE t.idTorneo=@idTorneo " +
                        " GROUP BY j.nombre + ' ' + j.apellido, t.nombre, c.nombre ";

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();

        try
        {
            cmd.Connection = dbConnection;
            cmd.Transaction = dbTransaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            cmd.Parameters.AddWithValue("@idTorneo", idTorneo);
            tabla.Load(cmd.ExecuteReader());
            return tabla;
        }
        catch (SqlException ex)
        {
            throw (ex);
        }
    }
    public DataTable GenerarReporteEquipoXJugador(int idTorneo)
    {
        string strSql = "SELECT (j.nombre + ' ' + j.apellido) as jugador, t.nombre as torneo, Sum(puntaje) as puntaje, e.nombre as equipo" +
            " FROM JugadorXFechaXTorneo jxf JOIN Jugador j ON jxf.idJugador=j.idJugador " +
            " JOIN Torneo t ON jxf.idTorneo = t.idTorneo " +
            " JOIN EquipoXJugador exj ON exj.idJugador=jxf.idJugador " +
            " JOIN Equipo e ON exj.idEquipo=e.idEquipo " +
            " WHERE t.idTorneo=@idTorneo " +
            " GROUP BY j.nombre + ' ' + j.apellido, t.nombre, e.nombre";

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();

        try
        {
            cmd.Connection = dbConnection;
            cmd.Transaction = dbTransaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            cmd.Parameters.AddWithValue("@idTorneo", idTorneo);
            tabla.Load(cmd.ExecuteReader());
            return tabla;
        }
        catch (SqlException ex)
        {
            throw (ex);
        }
    }
}