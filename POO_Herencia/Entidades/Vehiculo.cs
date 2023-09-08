using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Entidades
{
	public  class Vehiculo
	{
		public decimal VelocidadMaxima { get; set; }
		public int NumeroRuedas { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }

   //     public Vehiculo(string marca,string modelo)
   //     {
			//Marca = marca;
			//Modelo = modelo;
   //     }


		virtual public void Encender() {

			Console.WriteLine("encendiento vehiculo");
		}


    }
}
