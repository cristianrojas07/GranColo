using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer;
using GranColo.DataLayer;

namespace GranColo.DataLayer.Dao
{
    class DirectorTecnicoDao
    {
        internal bool validarDirectorTecnico(DirectorTecnico oDT)
        {
            string sql = "SELECT t1.idDirectorTecnico " +
                " FROM DirectorTecnico t1 " + 
                " WHERE t1.nombreUsuario = '" + oDT.nombreUsuario + "'" +
                " AND t1.password = '" + oDT.password + "'";

            DataTable rtados  = DBHelper.getDBHelper().ConsultaSQL(sql);
            
            return (rtados.Rows.Count>0);
        }


        private DirectorTecnico ObjectMapping(DataRow row)
        {
            DirectorTecnico oDT = new DirectorTecnico();
            oDT.idDirectorTecnico = Int32.Parse(row[0].ToString());
            oDT.nombre = row[1].ToString();
            oDT.apellido = row[2].ToString();
            oDT.nroDoc = Int32.Parse(row[3].ToString());
            oDT.tipoDoc = Int32.Parse(row[4].ToString());
            oDT.nombreUsuario = row[5].ToString();
            oDT.password = row[6].ToString();
            oDT.email = row[7].ToString();
            oDT.idClubHincha = Int32.Parse(row[8].ToString());

            return oDT;
        }
        
    }
}
