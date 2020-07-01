using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZV_CursusAdmin.App.Context;
using ZV_CursusAdmin.App.Entities;

namespace ZV_CursusAdmin.App.Repositories
{
    public class CursusInstantieRepository : ICursusInstantieRepository
    {
        private CursusAdminContext db;

        public CursusInstantieRepository(CursusAdminContext db)
        {
            this.db = db;
        }
        public IEnumerable<CursusInstantie> GetCursusInstantie()
        {
            return db.CursusInstanties.ToList();
        }
    }
}