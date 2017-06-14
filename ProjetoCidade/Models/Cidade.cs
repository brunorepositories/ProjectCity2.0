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
        [Required(ErrorMessage = "Cidade inválida!")]
        [StringLength(20, ErrorMessage = "Descrição do Cidade muito longa!")]
        public string nome { get; set; }

        [Display(Name = "Estado:")]
        public int estado_id { get; set; }

        [ForeignKey("estado_id")]
        public virtual Estado estado { get; set; }

    }
}