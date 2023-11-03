using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotas.Clases
{
    public class ConstructorInscripcion
    {
        public string Id { get; set; }
        public string IdAlumno { get; set; }
        public string IdCurso { get; set; }
        public string IdMateria { get; set; }

        public ConstructorInscripcion() { }
    }
}
