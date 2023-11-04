using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotas.Clases
{
    internal class ConstructorPersonas
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Carnet { get; set; }
        public int Telefono { get; set; }
        public int IdEstado{ get; set; }

        public ConstructorPersonas() { }
    }
}
