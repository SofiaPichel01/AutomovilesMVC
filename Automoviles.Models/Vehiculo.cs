using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models
{
    [Table(name: "Vehiculos")]
    public class Vehiculo
    {
        // color para header
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Código Del vehículo")]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("nombre")]
        [Display(Name = "Modelo del Vehículo")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [Column("FechaDeLanzamiento")]
        [Display(Name = "Fecha de lanzamiento")]
        [DataType(DataType.DateTime)]
        public DateTime FechaDeLanzamiento { get; set; }

        //FK MARCA
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        //FK TIPO
        [Display(Name = "Tipo de vehículo")]
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

        //FK COLOR
        [Display(Name = "Color del vehículo")]
        public int ColorId { get; set; }
        public Color Color { get; set; }

        //FK SEGURO
        [Display(Name = "Empresa de seguro")]
        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }

        //FK COMBUSTIBLE
        [Display(Name = "Tipo de combustible necesario")]
        public int CombustibleId { get; set; }
        public Combustible Combustible { get; set; }

        //FK PAIS
        [Display(Name = "País de origen")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        

    }
}
