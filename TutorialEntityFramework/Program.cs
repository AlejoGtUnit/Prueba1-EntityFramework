using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {   
            using (var contexto = new ColegioContext("name=Colegio"))
            {
                var est = new Estudiante() { Nombre = "Pedro" };

                contexto.Estudiantes.Add(est);
                contexto.SaveChanges();
            }
        }
    }
}
