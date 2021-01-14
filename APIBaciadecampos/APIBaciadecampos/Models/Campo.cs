using System;
using System.ComponentModel.DataAnnotations;

namespace APIBaciadecampos.Models
{
    public class Campo
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public double Area { get; set; }
        
        public string Operadora { get; set; }

    }
}
