using Generics.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Servicios
{
	public class RepositorioPersona

	{

        public Persona _Persona { get; set; }

        public Persona ObtenerPersona(int Id)
		{
			Console.WriteLine($"Consulta base por id={Id}");
			_Persona = new Persona() { Id = Id, nombre = "Sonia", Edad = 29};

			return _Persona;
		}

		public void GuardarPersona(Persona persona)
		{
			Console.WriteLine($"Guardando persona {persona.nombre} a la Base");
		}



	}







}


