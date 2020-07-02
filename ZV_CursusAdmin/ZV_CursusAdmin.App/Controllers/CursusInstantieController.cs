using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZV_CursusAdmin.App.Context;
using ZV_CursusAdmin.App.Entities;
using ZV_CursusAdmin.App.Repositories;

namespace ZV_CursusAdmin.App.Controllers
{
    public class CursusInstantieController : ApiController
    {
        private ICursusInstantieRepository cursusInstantieRepository;
       public CursusInstantieController()
        {
            this.cursusInstantieRepository = new CursusInstantieRepository(new CursusAdminContext());
        }

        public CursusInstantieController(ICursusInstantieRepository cursusInstantieRepository)
        {
            this.cursusInstantieRepository = cursusInstantieRepository;
        }

        [HttpGet]
        [Route("Api/CursusInstantie")]
        public IEnumerable<CursusInstantie> GetAllCursusInstanties()
        {
            var product = cursusInstantieRepository.GetAllCursusInstanties();

            return product;

        }
    }
}
