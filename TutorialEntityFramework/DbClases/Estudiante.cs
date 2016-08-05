using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TutorialEntityFramework
{
    [Table("StudentInfo")]
    public class Estudiante
    {
        public Estudiante()
        {

        }

        [Key]
        public int Id { get; set; }

        [Column("Nombre", TypeName="ntext")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [NotMapped]
        public int? Edad { get; set; }

        public byte[] Foto { get; set; }
        public decimal Altura { get; set; }
        public float Peso { get; set; }
        public Maestro Maestro { get; set; }
        
        //ForeignKey property
        public Nullable<int> GradoId { get; set; }

        //Navigation property
        [ForeignKey("GradoId")]
        public virtual Grado Grado { get; set; }
    }
}
