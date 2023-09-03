// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//class program {

//	static void Main(string[] args)
//	{
//		Console.WriteLine("Hello World!");
//	}


//}

using PGE.Activo;

var miAuto = new Vehiculo(20);
Console.WriteLine("velocidad actual:"+miAuto.velocidad);
miAuto.acelerar(15);
Console.WriteLine("velocidad actual:" + miAuto.velocidad);


namespace PGE.Activo
{
	internal class Vehiculo
	{

		public decimal velocidad { get; set; }

		private string modelo { get; set; }

		public int anio { get; set; }

		public Vehiculo()
		{

		}

		public Vehiculo(decimal v_inicial)
		{
			velocidad = v_inicial;
		}

		/// <summary>
		/// este metodo es para acelerar
		/// </summary>
		/// <param name="v"> velocidad</param>
		public void acelerar(decimal v)
		{

			velocidad = velocidad + v;
			Console.WriteLine("velocidad:" + velocidad);
		}
		public void frenar(decimal v)
		{
			Console.WriteLine("velocidad" + velocidad + v);
		}
	}
}