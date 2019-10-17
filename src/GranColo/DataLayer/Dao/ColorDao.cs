using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranColo.BusinessLayer.Entities;

namespace GranColo.DataLayer.Dao
{
    public class ColorDao
    {
        public IList<Color> getAll()
        {
            IList<Color> list = new List<Color>();
            string sql = "SELECT * " +
                " FROM Color ";

            DataTable rtados = DataManager.GetInstance().ConsultaSQL(sql);

            foreach (DataRow row in rtados.Rows)
            {
                list.Add(ObjectMapping(row));
            }

            return list;
        }

        private Color ObjectMapping(DataRow row)
        {
            Color color = new Color();
            color.IdColor = Int32.Parse(row[0].ToString());
            color.Nombre = row[1].ToString();

            return color;

        }
    }
}
