using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotas.Clases
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdCurso { get; set; }
        public int IdMateria { get; set; }
        public int IdEstado { get; set; }


        public Inscripcion() { }
    }
}
