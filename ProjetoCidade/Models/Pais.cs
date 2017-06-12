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
        public string nomePais { get; set; }

    }
}