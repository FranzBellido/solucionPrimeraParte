using POO_Herencia.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Entidades
{
	public class Circulo : IPieza,IServicio
	{
		public int Diametro { get ; set ; }
		public int Identificador { get ; set ; }

		public Circulo( int para)
        {
            
        }
        public Circulo(int p, string p2)
        {
            
        }
        public decimal ObtenerArea()
		{
			Console.WriteLine("Calculando Area");
			return 10;
		}

		public void GuardarDatoDiamtro() {
		 
			/// guardar

		}
		public decimal ObtenerPerimetro()
		{
			return Diametro * 3;
		}

		public decimal ObtenerPerimetro(int valor)
		{
			return Diametro * valor;
		}

		public void Agregar()
		{
			throw new NotImplementedException();
		}
	}
}
