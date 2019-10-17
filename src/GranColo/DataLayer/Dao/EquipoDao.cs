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
            string sql = "SELECT * " +
                " FROM Equipo ";

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
            equipo.DT.IdDirectorTecnico = Int32.Parse(row[2].ToString());
            equipo.Lema = row[3].ToString();
            equipo.Color.IdColor = Int32.Parse(row[4].ToString());

            return equipo;
        }
    }
}
