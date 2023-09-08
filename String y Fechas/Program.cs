// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;

//var carater = 'k';

//string textoStr = "este es un texto";

//char[] cadena = { 'h', 'o', 'l', 'a' };

//var cadena2 = "esta es una concatenacion de cadenas :";

//Console.WriteLine( string.Format("{1} {2} la temperatura es {0} C  ", 23, 22,21));

int valor = 10;
int valor2 = 30;
string Cadena3 = $" la temperatura es {valor} C, y {valor2} F";

//Console.WriteLine(Cadena3);


//string cadena4 = Cadena3.ToLower();

//bool comparacion = Cadena3.Equals(cadena2);

//Console.WriteLine(comparacion);	

//int posicion=Cadena3.IndexOf("e");
//Console.WriteLine(posicion);

//bool contiene =Cadena3.Contains("la");

//Console.WriteLine(contiene);

string cadena = "66;9999;101;4;10;33";

//cadena = "sdkjfhskdf";
string[] valores = cadena.Split(";");

var cadena10 = String.Join(",", valores);
Console.WriteLine(cadena10);


//string cadena5 = valores[0];


StringBuilder sb1= new StringBuilder("este es un mensaje");

sb1.Append(Cadena3);

sb1.Append("otro texto añsldkaskldj alskdja ñlsdkjasñ ldkjas ñdlkajsd lñkasjdasd");


Console.WriteLine(sb1);






































//var mifecha = new DateTime(2022, 02, 1,14,30,3,DateTimeKind.Utc);

//Console.WriteLine(mifecha.ToString());

//var periodo = new TimeSpan(2, 3, 2);

//var FechaNuena= mifecha.Add(periodo);

//Console.WriteLine(FechaNuena.ToString());



//int comparacion = DateTime.Compare(mifecha, FechaNuena);

//Console.WriteLine(comparacion.ToString());	

//Console.WriteLine(FechaNuena.ToString("yyyy-MM-ddThh:mm:ss:ms"));


//Console.ReadKey();

