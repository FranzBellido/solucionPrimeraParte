using POO_Herencia.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Entidades
{
	public class triangulo : Pieza, IEntidad
	{
		public override decimal Area()
		{
			throw new NotImplementedException();
		}

		protected override decimal Perimetro()
		{
			throw new NotImplementedException();
		}
	}
}
