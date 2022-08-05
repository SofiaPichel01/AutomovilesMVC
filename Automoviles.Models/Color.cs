using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoviles.Models
{

    [Table(name: "Color")]
    public class Color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("Id")]
        [Display(Name = "Código De Color")]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("Nombre")]
        [Display(Name = "Color del vehículo")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
