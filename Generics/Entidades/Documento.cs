using Generics.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entidades
{
	public  class Documento : IEntidad
	{

        public int Id { get; set; }
		public string Numero { get; set; }

        public string Contenido { get; set; }
        public string UserCreador { get ; set ; }
    }
}
