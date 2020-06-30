using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZV_CursusAdmin.App.Entities
{
    public class CursusInstantie
    {
        public int Id { get; set; } 
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDatum { get; set; }
        public virtual Cursus Cursus { get; set; }

    }
}