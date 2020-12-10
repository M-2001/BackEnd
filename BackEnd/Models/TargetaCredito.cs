using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class TargetaCredito
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName="varchar(100)")]
        public string titular { get; set; }
        [Required]
        [Column(TypeName ="varchar(16)")]
        public string NumeroTargeta { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string fechaExpiracion { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string cvv { get; set; }

    }
}
