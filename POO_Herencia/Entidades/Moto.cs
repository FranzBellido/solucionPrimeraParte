using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Entidades
{
	public  class Moto : Vehiculo
	{
		
		public int Cilindrada { get; set; }
		public string Marca { get; set; }
		public int modelo { get; set; }

		

		public void Encender() {

			Console.WriteLine("encender Moto");
		}
	}
}
