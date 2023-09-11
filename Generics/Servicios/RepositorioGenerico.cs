using Generics.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Servicios
{
	public class RepositorioGenerico <T> where T : IEntidad 
	{


        public T Entidad { get; set; }

        public T ObtenerObjeto(int Id) {

			Console.WriteLine("Consultando Base ");
			return Entidad;
		
		}

		public void GuardarObjeto() {

			Entidad.Id = 20;
			Entidad.UserCreador = "franz";
			Console.WriteLine("Guardando objeto ");
		
		}

	}
}
