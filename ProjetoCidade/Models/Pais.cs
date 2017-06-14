using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCidade.Models
{
    public class Pais : AbstractEntity
    {


        [Display(Name = "Pais:")]
        [Required(ErrorMessage = "Pais inválido!")]
        [StringLength(20, ErrorMessage = "Descrição do pais muito longa!")]
        public string nome { get; set; }


        [Display(Name = "Sigla do pais:")]
        [Required(ErrorMessage = "Sigla do pais inválida!")]
        [StringLength(2, ErrorMessage = "Sigla do pais muito longa!")]
        public string sigla { get; set; }

    }
}