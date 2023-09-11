using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Entidades
{
	public partial class Auto  :Vehiculo
	{
		//public Auto(string Marca1, string Modelo1) : base(Marca1, Modelo1)
		//{
		//}

		public string Traccion { get; set; }

		public override void Encender()
		{
			Console.WriteLine("Enciende Auto");
		}

		public void Encender(int tiempo) {

			Console.WriteLine("enciende con tiempo:" + tiempo);
		}


	}
}
