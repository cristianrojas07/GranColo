using GranColo.BusinessLayer.Entities;
using GranColo.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranColo.BusinessLayer.Services
{
    class ClubService
    {
        readonly ClubDao ClubDao = new ClubDao();
        public int Selected { get; set; }

        internal bool InsertarClub(Club oClub)
        {
            return ClubDao.InsertClub(oClub);
        }

        internal bool ModificarClub(Club oClub)
        {
            return ClubDao.ModifyClub(oClub, Selected);
        }

        internal bool EliminarClub()
        {
            return ClubDao.DeleteClub(Selected);
        }

        internal IList<Club> ObtenerTodosClubes()
        {
            return ClubDao.GetAllClub();
        }
    }
}
