using POO_Herencia.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Entidades
{
	public class Cuadrado : IPieza
	{
		public int Diametro { get; set ; }

		public void GuardarDatoDiamtro()
		{
			throw new NotImplementedException();
		}

		public decimal ObtenerArea()
		{
			Console.WriteLine("obteneindo Area");
			return 10;
		}

		public decimal ObtenerPerimetro()
		{
			Console.WriteLine("obteneido Perimetro");

			return 20;
		}
	}
}
