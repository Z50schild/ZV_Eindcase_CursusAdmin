using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZV_CursusAdmin.App.Entities;

namespace ZV_CursusAdmin.App.Repositories
{
    public interface ICursusInstantieRepository
    {
         IEnumerable<CursusInstantie> GetCursusInstantie();
    }
}