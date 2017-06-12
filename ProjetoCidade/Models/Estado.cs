using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoCidade.Models
{
    public class Estado : AbstractEntity
    {

        [Display(Name = "Estado:")]
        public string nomeEstado { get; set; }

        
        public int pais_id { get; set; }

        [ForeignKey("pais_id")]
        public virtual Pais pais { get; set; }

    }
}