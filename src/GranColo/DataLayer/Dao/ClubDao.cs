using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    class ClubDao
    {

        internal bool InsertClub(Club oClub)
        {
            throw new NotImplementedException();
        }

        internal bool ModifyClub(Club oClub, int selected)
        {
            throw new NotImplementedException();
        }

        internal bool DeleteClub(int selected)
        {
            throw new NotImplementedException();
        }

        internal IList<Club> GetAllClub()
        {
            List<Club> list = new List<Club>();
            string sql = " SELECT * FROM Club ";
            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);
            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        private Club ObjectMapping(DataRow row)
        {

            Club Club = new Club();
            Club.Localidad = new Localidad();
            Club.IdClub = Int32.Parse(row[0].ToString());
            Club.Nombre = row[1].ToString();
            Club.FechaFundacion = row[2].ToString();
            Club.NombreEstadio = row[3].ToString();
            Club.Aforo = Int32.Parse(row[4].ToString());
            Club.Calle = row[6].ToString();
            Club.Numero = Int32.Parse(row[7].ToString());
            Club.Localidad.IdLocalidad = Int32.Parse(row[5].ToString());
            return Club;
        }
    }
}
