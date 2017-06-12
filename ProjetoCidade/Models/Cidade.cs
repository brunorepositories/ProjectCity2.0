using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoCidade.Models
{
    public class Cidade : AbstractEntity
    {
        [Display(Name = "Cidade:")]
        public string nomeCidade { get; set; }

        public int estado_id { get; set; }

        [ForeignKey("estado_id")]
        public virtual Estado estado { get; set; }

    }
}