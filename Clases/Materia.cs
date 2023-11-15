using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotas.Clases
{
	internal class Materia
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public int IdDocente { get; set; }
        public int IdEstado { get; set; }

        public Materia() { }
	}

}
