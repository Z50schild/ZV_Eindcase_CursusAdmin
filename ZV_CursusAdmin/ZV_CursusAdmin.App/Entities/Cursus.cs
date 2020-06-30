using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZV_CursusAdmin.App.Entities
{
    public class Cursus
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public string Titel { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }
        public int Duur { get; set; }
        public virtual List<CursusInstantie> CursusInstanties { get; set; }


    }
}