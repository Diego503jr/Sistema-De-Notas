using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotas.Clases
{
    internal class Usuario
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public string Nombre { get; set; }
        public string Carnet { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public int IdEstado { get; set; }
        public Usuario() { }
    }
}
