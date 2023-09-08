using Generics.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entidades
{
	public  class Persona :IEntidad
	{
        public int Id { get; set; }

        public string  nombre { get; set; }

        public int Edad { get; set; }
		public string UserCreador { get ; set; }
	}
}
