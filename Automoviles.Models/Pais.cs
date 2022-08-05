using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoviles.Models
{
    [Table(name: "Pais")]
    public class Pais
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("Id")]
        [Display(Name = "Código De Pais")]
        public int Id { get; set; }


        [StringLength(200)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("Nombre")]
        [Display(Name = "País de origen")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
