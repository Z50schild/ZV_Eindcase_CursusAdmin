using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using ZV_CursusAdmin.App.Entities;

namespace ZV_CursusAdmin.App.Context
{
    public class CursusAdminContext : DbContext
    {
        public CursusAdminContext() : base("CursusAdminConnectString")
        {
        }

        public static CursusAdminContext Create()
        {
            return new CursusAdminContext();
        }

        public DbSet<Cursus> Cursus { get; set; }
        public DbSet<CursusInstantie> CursusInstanties { get; set; }
    }
}