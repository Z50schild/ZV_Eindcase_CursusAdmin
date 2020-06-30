using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZV_CursusAdmin.App.Context;
using ZV_CursusAdmin.App.Entities;

namespace ZV_CursusAdmin.App.Controllers
{
    public class CursusInstantieController : ApiController
    {
        private CursusAdminContext db;

        public CursusInstantieController()
        {
            db = new CursusAdminContext();
        }
        public IEnumerable<CursusInstantie> GetCursusInstantie()
        {
            return db.CursusInstanties.ToList();
        }
    }
}
