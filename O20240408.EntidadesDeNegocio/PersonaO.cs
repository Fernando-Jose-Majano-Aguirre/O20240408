using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O20240408.EntidadesDeNegocio
{
    [Table(name: "Personas")]
    public class PersonaO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido"), MaxLength(50)]
        [Display(Name ="Nombre")]
        public string NombreO { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido"), MaxLength(50)]
        [Display(Name = "Apellido")]
        public string ApellidoO { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime FechaNacimientoO;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Sueldo")]
        public double SueldoO {  get; set; }
        public byte[]? status { get; set; }
        [MaxLength(500)]
        public string ComentarioO { get; set; }
    }
}
