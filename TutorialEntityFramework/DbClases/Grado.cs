using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutorialEntityFramework
{
    public class Grado
    {
        public Grado()
        {

        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        //Collection navigation property
        public IList<Estudiante> Estudiantes { get; set; }
    }
}