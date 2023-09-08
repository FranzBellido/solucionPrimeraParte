using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Contratos
{
	public  interface IPieza
	{
        public int Diametro { get; set; }

		void GuardarDatoDiamtro();
		decimal ObtenerArea();
		decimal ObtenerPerimetro();
	}
}
