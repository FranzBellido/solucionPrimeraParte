using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Contratos
{
	public abstract class Pieza
	{
        public int Id2 { get; set; }

        public abstract decimal Area();
		protected abstract decimal Perimetro();

		//public static int Construir( int tamanio) {
		//	Console.WriteLine("construyendo objeto:"+ tamanio+10);
		//	return tamanio+10;
		//}

	}
}
