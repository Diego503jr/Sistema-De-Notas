using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotas.Clases
{
    internal class ConstructorNotas
    {
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdMateria { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Nota4 { get; set; }
        public decimal Promedio { get; set; }

        public ConstructorNotas() { }
    }
}
